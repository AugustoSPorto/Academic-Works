fn handle_state(state: ConnectionState) {
    match state {
        ConnectionState::Connected => println!("Conectado!"),
        ConnectionState::Disconnected => println!("Desconectado"),
        ConnectionState::Error(msg) => println!("Erro: {}", msg),
    }
}