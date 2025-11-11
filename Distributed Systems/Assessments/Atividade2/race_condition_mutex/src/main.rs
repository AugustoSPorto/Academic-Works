use std::sync::{Arc, Mutex};
use std::thread;
 
fn main() {
    // Contador compartilhado entre threads (Arc) e protegido por Mutex
    let counter = Arc::new(Mutex::new(0));
    let mut handles = vec![];

    // Cria 10 threads
    for _ in 0..10 {
        let counter_clone = Arc::clone(&counter); // Clona a referência compartilhada

        let handle = thread::spawn(move || {
            for _ in 0..1000 {
                // Bloqueia o Mutex para acesso exclusivo
                let mut num = counter_clone.lock().unwrap();
                *num += 1; // Incrementa o valor
                // O Mutex é liberado automaticamente ao sair do escopo
            }
        });

        handles.push(handle); // Guarda o handle da thread
    }

    // Espera todas as threads terminarem
    for h in handles {
        h.join().unwrap();
    }

    // Mostra o resultado final
    println!("Resultado final (Mutex): {}", *counter.lock().unwrap());
}
