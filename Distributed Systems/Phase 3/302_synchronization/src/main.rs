// 2. Sincronização: Crie 5 threads que incrementam um contador compartilhado 1000 vezes cada.
// Use Arc<Mutex<i32>> e verifique que o resultado final é 5000.

// Arc compartilha a posse do contador entre múltiplas threads.
// Mutex garante que apenas uma thread possa modificar o contador por vez.
use std::sync::{Arc, Mutex};
use std::thread;

fn main() {
    // Contador compartilhado, inicializado em 0, protegido por Mutex e compartilhado via Arc
    let counter = Arc::new(Mutex::new(0));
    let mut handles = vec![];

    // Cria 5 threads
    for _thread in 0..5 {
        // Clona o Arc para compartilhar o contador entre as threads
        let counter_clone = Arc::clone(&counter);

        let handle = thread::spawn(move || {
            for _ in 0..1000 {
                // Bloqueia o mutex para acesso exclusivo
                let mut num = counter_clone.lock().unwrap();
                *num += 1;

                //println!("Thread {} incrementou para {}", _thread , num);

            } // Mutex é liberado automaticamente ao final do escopo
        });
        handles.push(handle);
    }

    // Espera todas as threads terminarem
    for handle in handles {
        handle.join().unwrap();
    }

    // Verifica o resultado final
    println!("Resultado final: {}", *counter.lock().unwrap());
}
