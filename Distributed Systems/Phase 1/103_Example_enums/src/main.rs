// 3. Enums: Crie um enum Message que pode representar diferentes
// tipos de mensagens (Text, Image, Video) com dados associados.
// Implemente uma função que processa cada tipo


enum MessageTypes {
    Text(String),
    Image { url:String, width:u32, height:u32 },
    Video { url:String, duration:f64 },
}


fn process_message(message: MessageTypes) {
    match message {
        MessageTypes::Text(content) => {
            println!("Processed text message:\n {}\n", content);
        }
        MessageTypes::Image { url, width, height } => {
            println!("Processed image message:\n - URL: {};\n - Width: {} pixels;\n - Height: {} pixels.\n", url, width, height);
        }
        MessageTypes::Video { url, duration } => {
            println!("Processed video message:\n - URL: {};\n - Duration: {} seconds.\n", url, duration);
        }
    }
}


fn main() {
    // Exemplo de mensagem de texto
    let text = String::from("Hello, this is a text message.");
    let text_message = MessageTypes::Text(text);

    // Exemplo de mensagem de imagem
    let url = String::from("http://example.com/image.png");
    let width: u32 = 600;
    let height: u32 = 400;
    let image_message = MessageTypes::Image { url, width, height};

    // Exemplo de mensagem de vídeo
    let url = String::from("http://example.com/video.mp4");
    let duration: f64 = 187.5; 
    let video_message = MessageTypes::Video { url, duration };

    // Processando as mensagens
    process_message(text_message);
    process_message(image_message);
    process_message(video_message);
}
