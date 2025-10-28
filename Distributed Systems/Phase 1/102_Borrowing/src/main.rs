// 2. Borrowing: Crie uma struct Rectangle com campos width e height.
// Implemente métodos para calcular área e perímetro usando &self.

use std::io;

struct Rectangle {
    width: f64,
    height: f64,
}

// Implementação dos métodos para a struct Rectangle
impl Rectangle {
    fn new(width: f64, height: f64) -> Self {
        Rectangle{width, height}
    }

    fn area(&self) -> f64 {
        self.width * self.height
    }

    fn perimeter(&self) -> f64 {
        (self.width + self.height) * 2.0
    }
}

fn main() {
    let mut width = String::new();
    let mut height = String::new();

    println!("Inform the width of the rectangle: ");
    io::stdin()
        .read_line(&mut width)
        .expect("Failed to read the width");

    println!("Inform the height of the rectangle: ");
    io::stdin()
        .read_line(&mut height)
        .expect("Failed to read the height");

    // Convertendo input para f64
    let width: f64 = width.trim().parse().expect("Please type a number!");
    let height: f64 = height.trim().parse().expect("Please type a number!");

    // Criando o retângulo
    let rectangle = Rectangle::new(width,height);

    println!("\nThis rectangle has an area of: {}u² and a perimeter of {}u!", rectangle.area(), rectangle.perimeter());
    
}
