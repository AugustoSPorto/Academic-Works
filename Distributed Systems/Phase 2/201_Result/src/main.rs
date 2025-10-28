use std::io;

struct Calculator {
    num1: f64,
    num2: f64,
    operator: String,
}

impl Calculator {
    // Construtor retornando Self
    fn new(num1: f64, num2: f64, operator: String) -> Self {
        Calculator { num1, num2, operator }
    }

    // Método que realiza o cálculo e retorna Result<f64, String>
    fn calculate(&self) -> Result<f64, String> {
        match self.operator.trim() {
            "+" => Ok(self.num1 + self.num2),
            "-" => Ok(self.num1 - self.num2),
            "*" | "x" => Ok(self.num1 * self.num2),
            "/" => {
                if self.num2 == 0.0 {
                    Err("Erro: divisão por zero!".to_string())
                } else {
                    Ok(self.num1 / self.num2)
                }
            }
            _ => Err(format!("Invalid operator")),
        }
    }
}

fn main() {
    let mut num1 = String::new();
    let mut num2 = String::new();
    let mut operator = String::new();

    println!("Type the first number:");
    io::stdin().read_line(&mut num1).expect("Failed to read line");
    let num1: f64 = num1.trim().parse().expect("Failed to parse number");

    println!("Type the second number:");
    io::stdin().read_line(&mut num2).expect("Failed to read line");
    let num2: f64 = num2.trim().parse().expect("Failed to parse number");

    println!("Type the operation (+, -, *, /):");
    io::stdin().read_line(&mut operator).expect("Failed to read line");
    let operator = operator.trim().to_string(); // Remove espaço

    let calculator = Calculator::new(num1, num2, operator.clone()); 

    let result = calculator.calculate();

    // Tratando o resultado usando pattern matching
    match result {
        Ok(value) => println!("\nResultado => {} {} {} = {}", num1, operator, num2, value),
        Err(error) => println!("{}", error),
    } 
}
