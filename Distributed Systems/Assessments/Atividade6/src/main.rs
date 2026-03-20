use mpi::traits::*;
use std::time::Instant;

fn compute_pi(world: &impl Communicator, n: usize) {
    let rank = world.rank();
    let size = world.size() as usize;

    let h = 1.0 / n as f64;

    let mut local_sum = 0.0;

    // Cada processo calcula parte dos pontos
    for i in (rank as usize..n).step_by(size) {
        let x = h * (i as f64 + 0.5);
        local_sum += 4.0 / (1.0 + x * x);
    }

    local_sum *= h;

    let mut global_sum = 0.0;

    // Reduce (soma de todos processos)
    world.all_reduce_into(&local_sum, &mut global_sum, &mpi::collective::SystemOperation::sum());

    if rank == 0 {
        println!("Pi aproximado: {}", global_sum);
    }
}

fn main() {
    let universe = mpi::initialize().unwrap();
    let world = universe.world();

    let rank = world.rank();

    let n = 1_000_000; // número de pontos (ajuste se quiser)

    world.barrier();

    let start = Instant::now();

    compute_pi(&world, n);

    world.barrier();

    let duration = start.elapsed();

    if rank == 0 {
        println!("Tempo: {:?}", duration);
    }
}