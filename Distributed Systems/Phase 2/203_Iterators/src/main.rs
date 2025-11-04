// 3. Iteradores: Dada uma lista de números, use iteradores para encontrar a média dos números maiores que 10.

fn main() {
    let numbers: Vec<i32> = vec![9, 12, 13, 14, 15];

    let numbers_filtered: Vec<i32> = numbers.iter()                 // Cria um iterador sobre referências aos elementos
                                            .filter(|&&x| x > 10)   // Filtra números maiores que 10
                                            .cloned()               // Desreferencia as referências
                                            .collect();             // Coleta em um novo vetor

    let length = numbers_filtered.len();

    // Calcula a média
    if length > 0 {
        let sum: i32 = numbers_filtered.iter()      // Cria um iterador sobre referências aos elementos  
                                        .sum();     // Soma os elementos

        let average_ht10: f32 = sum as f32 / length as f32; // Calcula a média como f32 (para casos em que não seja inteiro)

        println!("Média dos números maiores que 10: {}", average_ht10); 

    } 
    else {
        println!("Nenhum número maior que 10 encontrado.");
    };
}
