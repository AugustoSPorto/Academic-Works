use std::sync::{Arc, Condvar, Mutex};
use std::thread;
use std::time::Duration;

#[derive(Clone)]
struct SharedQueue<T> {
    data: Arc<(Mutex<Vec<T>>, Condvar, Condvar)>,
    capacity: usize,
}

impl<T> SharedQueue<T> {
    pub fn new(capacity: usize) -> Self {
        SharedQueue {
            data: Arc::new((Mutex::new(Vec::new()), Condvar::new(), Condvar::new())),
            capacity,
        }
    }

    pub fn push(&self, item: T) {
        let (lock, not_empty, not_full) = &*self.data;
        let mut buffer = lock.lock().unwrap();

        while buffer.len() == self.capacity {
            buffer = not_full.wait(buffer).unwrap();
        }

        buffer.push(item);
        not_empty.notify_one();
    }

    pub fn pop(&self) -> T {
        let (lock, not_empty, not_full) = &*self.data;
        let mut buffer = lock.lock().unwrap();

        while buffer.is_empty() {
            buffer = not_empty.wait(buffer).unwrap();
        }

        let item = buffer.remove(0);
        not_full.notify_one();

        item
    }
}

fn main() {
    let queue = SharedQueue::new(10);
    let num_producers = 3;
    let num_consumers = 2;
    let items_per_producer = 50;

    let mut list_producers = vec![];
    let mut list_consumers = vec![];

    // ---- PRODUCERS ----
    for p in 1..=num_producers {
        let queue_producers = queue.clone();

        list_producers.push(thread::spawn(move || {

            for i in 1..=items_per_producer {
                println!("|* Producer {p} produced {i} *|");
                queue_producers.push((p, i));
                thread::sleep(Duration::from_millis(10));
            }
        }));
    }

    // ---- CONSUMERS ----
    for c in 1..=num_consumers {
        let queue_consumers = queue.clone();

        list_consumers.push(thread::spawn(move || {
            loop {
                let (producer, item) = queue_consumers.pop();
                
                // Encerra a thread do consumidor ao receber sentinela
                if producer == -1 {
                    break;
                }

                println!("-- Consumer {c} consumed {item} from producer {producer}");
                thread::sleep(Duration::from_millis(50));
            }
        }));
    }

    // Esperar os produtores terminarem
    for p in list_producers {
        p.join().unwrap();
    }

    // Enviar sentinelas para consumidores e evitar deadlock na espera (tambem chamado de poison pill)
    for _ in 0..num_consumers {
        queue.push((-1, -1));
    }

    // Esperar consumidores terminarem
    for c in list_consumers {
        c.join().unwrap();
    }

    println!("ALL PRODUCERS AND CONSUMERS HAVE FINISHED!!!");
}