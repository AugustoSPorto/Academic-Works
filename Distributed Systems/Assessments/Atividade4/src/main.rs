use rand::Rng;
use rayon::prelude::*;
use rayon::ThreadPoolBuilder;
use std::time::Instant;

fn main() {
    let n = 100;     
    let threads = 8;  

    println!("Multiplicação Matriz-Vetor (n = {}, threads = {})", n, threads);

    // Cria pool local com número desejado de threads
    let pool = ThreadPoolBuilder::new().num_threads(threads).build().unwrap();

    // Definindo matriz e vetor aleatórios
    let mut rng = rand::thread_rng();
    let matrix: Vec<f64> = (0..n*n).map(|_| rng.gen_range(0.0..1.0)).collect();
    let vector: Vec<f64> = (0..n).map(|_| rng.gen_range(0.0..1.0)).collect();

    //  SEQUENCIAL 
    let start = Instant::now();
    let mut out_seq = vec![0.0; n];
    for i in 0..n {
        let mut s = 0.0;
        for j in 0..n {
            s += matrix[i*n + j] * vector[j];
        }
        out_seq[i] = s;
    }
    let seq_time = start.elapsed().as_secs_f64();
    println!("Tempo sequencial: {} s", seq_time);

    //  PARALELO 
    let start = Instant::now();
    let out_par: Vec<f64> = pool.install(|| {
        matrix
            .par_chunks(n)
            .map(|row| row.iter().zip(&vector).map(|(a, b)| a * b).sum())
            .collect()
    });
    let par_time = start.elapsed().as_secs_f64();
    println!("Tempo paralelo: {} s", par_time);

    // Calculando Speedup e Eficiência
    let speedup = seq_time / par_time;
    let efficiency = speedup / threads as f64;

    println!("Speedup = {:.2}x", speedup);
    println!("Efficiency = {:.2}%", efficiency * 100.0);

    // Evita otimização eliminar o cálculo
    assert!(out_seq.len() == out_par.len());
}
