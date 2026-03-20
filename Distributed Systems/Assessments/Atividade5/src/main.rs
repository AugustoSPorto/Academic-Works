use mpi::traits::*;
use std::time::Instant;

fn run_test(world: &impl Communicator, iterations: i32) {
    let rank = world.rank();
    let partner_rank = 1 - rank;

    let mut ping_pong_count = 0;

    world.barrier();

    let start = if rank == 0 {
        Some(Instant::now())
    } else {
        None
    };

    while ping_pong_count < iterations {
        if rank == ping_pong_count % 2 {
            ping_pong_count += 1;
            world.process_at_rank(partner_rank).send(&ping_pong_count);
        } else {
            world
                .process_at_rank(partner_rank)
                .receive_into(&mut ping_pong_count);
        }
    }

    if rank == 0 {
        let duration = start.unwrap().elapsed();
        let latency = duration / (iterations * 2) as u32;

        println!("---------------------------------");
        println!("Mensagens: {}", iterations);
        println!("Tempo total: {:?}", duration);
        println!("Latência média por mensagem: {:?}", latency);
    }
}

fn main() {
    let universe = mpi::initialize().unwrap();
    let world = universe.world();
    let size = world.size();

    if size != 2 {
        if world.rank() == 0 {
            println!("Este programa requer exatamente 2 processos");
        }
        return;
    }

    run_test(&world, 1000);
    run_test(&world, 10_000);
    run_test(&world, 100_000);
}