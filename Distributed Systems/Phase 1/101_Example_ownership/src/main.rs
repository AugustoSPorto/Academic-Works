// 1. Ownership: Implemente uma função que recebe uma String, adiciona um sufixo
// e retorna a string modificada sem fazer cópias desnecessárias.

use std::io;

fn main() {
    println!("Enter a phrase:");
    let mut phrase = String::new();

    io::stdin()
        .read_line(&mut phrase)             // lê input do usuário
        .expect("Failed to read line");     // trata erros


    println!("znEnter a suffix:");
    let mut suffix = String::new();

    io::stdin()
        .read_line(&mut suffix)
        .expect("Failed to read line");

        
    println!("\nPhrase + Suffix = {}{}", phrase.trim(), suffix); // trim remove espaço \n do final
}
