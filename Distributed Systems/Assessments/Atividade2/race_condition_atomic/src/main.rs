use std::sync::atomic::{AtomicI32, Ordering};
use std::sync::Arc;
use std::thread;

fn main() {
    // Contador atômico compartilhado entre threads
    let counter = Arc::new(AtomicI32::new(0));
    let mut handles = vec![];

    // Cria 10 threads
    for _ in 0..10 {
        let counter_clone = Arc::clone(&counter);

        let handle = thread::spawn(move || {
            for _ in 0..1000 {
                // Incrementa de forma atômica (sem precisar de Mutex)
                counter_clone.fetch_add(1, Ordering::Relaxed);
            }
        });

        handles.push(handle);
    }

    // Espera todas as threads terminarem
    for h in handles {
        h.join().unwrap();
    }

    // Lê o valor final do contador
    println!("Resultado final (Atomic): {}", counter.load(Ordering::Relaxed));
}
