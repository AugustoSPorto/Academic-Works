// Ownership é o conceito central de Rust. Cada valor tem um único “dono” e é liberado quando o dono sai de escopo.

fn main() {
    let s1 = String::from("hello");
    let s2 = s1; // s1 foi "movido" para s2
    // println!("{}", s1); // ERRO: s1 não é mais válido
    println!("{}", s2); // OK
}

