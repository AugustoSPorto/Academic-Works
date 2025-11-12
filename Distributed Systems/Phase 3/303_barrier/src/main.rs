use std::sync::{Arc, Barrier};
use std::thread;

fn main() {
    let barrier = Arc::new(Barrier::new(4));
    let mut handles = vec![];

    for thread_id in 0..4 {
        let barrier_clone = Arc::clone(&barrier);
        
        // Use `move` para mover as variáveis para dentro da thread
        let handle = thread::spawn(move || {
            println!("Thread {} iniciou sua tarefa", thread_id);

            // =============================================//
            // Tarefa escolhida para exemplo: contar até 10
            for i in 1..=10 {
                println!("Thread {}: contador = {}", thread_id, i);
            }
            // =============================================//

            println!("Thread {} aguardando na barreira...", thread_id);
            barrier_clone.wait(); // sincronização aqui
            println!("Thread {} passou pela barreira!", thread_id);
        });

        handles.push(handle);
    }

    // Espera todas as threads terminarem antes de encerrar
    for handle in handles {
        handle.join().unwrap();
    }

    println!("Todas as threads passaram pela barreira e terminaram!");
}
