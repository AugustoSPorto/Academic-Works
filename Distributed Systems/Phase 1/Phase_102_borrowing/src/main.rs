// Borrowing permite referências temporárias sem transferir ownership

fn main() {
    let s1 = String::from("hello");
    let len = calculate_length(&s1); // Empresta s1
    println!("'{}' tem {} caracteres", s1, len); // s1 ainda é válido
}

fn calculate_length(s: &String) -> usize {
    s.len()
} // s sai de escopo, mas não é liberada (apenas emprestada)


// Regras de Borrowing: 
// 1. Você pode ter uma referência mutável OU várias referências imutáveis 
// 2. Referências devem sempre ser válidas (não podem apontar para memória liberada)