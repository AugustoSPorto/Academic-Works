// 1. Threads Básicas: Implemente o problema do Produtor-Consumidor usando channels.
// Um produtor gera números de 1 a 100, e um consumidor os imprime.

use std::sync::mpsc;
use std::thread;
//use std::time::Duration;

fn main() {
    // Cria um canal (sender, receiver)
    let (tx, rx) = mpsc::channel();

    // Consumidor
    let consumer = thread::spawn(move || {
        for received in rx {
            println!("Consumiu: {}", received);
        }
    });

    // Produtor
    let producer = thread::spawn(move || {
        for i in 1..=100 {                              //1..=100 significa 1 a 100, enquanto 1..100 significa 1 a 99 
            tx.send(i).unwrap();
            println!("Produziu: {}", i);

            // Evita que a saída imprima muito rápido (pode imprimir um consumidor antes do seu respectivo produtor)
            //thread::sleep(Duration::from_millis(10));
        }
    });

    // Aguarda as threads terminarem para que o programa principal não finalize antes delas
    producer.join().unwrap();
    consumer.join().unwrap();
}
