use std::collections::HashMap;

use std::fs::File;
use std::io::Read;

fn main() {
    match read_file("data.txt") {
        Ok(data) => {
            println!("File read successfully.\n");
            let words_detected = count_words(data);

            println!("Word count:");
            for (word, count) in &words_detected {
                println!("{}: {}", word, count);
            }
        }
        Err(e) => eprintln!("Error reading file: {}", e),
    }
}

fn read_file(path: &str) -> Result<String, std::io::Error> {
    let mut file = File::open(path)?;
    let mut contents = String::new();
    file.read_to_string(&mut contents)?;
    Ok(contents)
}

fn count_words(data: String) -> HashMap<String, u32> {
    let mut words_counted: HashMap<String, u32> = HashMap::new();

    for word in data.split_whitespace() {
        // Prepara palavra
        let clean_word = word
            .trim_matches(|c: char| !c.is_alphanumeric())   // Remove não alfanuméricos (pontuação)
            .to_lowercase();                                // Converte para minúsculas 

        // Conta palavra
        if !clean_word.is_empty() {

            if words_counted.contains_key(&clean_word) {
                // Obtém o valor atual
                // OBS.: o get retorna uma Option (Some()) como visto no print abaixo
                let current = words_counted.get(&clean_word);
                // println!("Current value for {}: {:?}", clean_word, current);

                // Assim, desempacotamos o valor dentro do Some() 
                let current = current.unwrap();

                // Incrementa a contagem
                words_counted.insert(clean_word, current + 1);
            }
            else {
                words_counted.insert(clean_word, 1);
            }
        }
    }

    words_counted
}
