using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            Product banana = new Product("Banana", 13, 1.1);
            
            banana.PrintProduct();
        }
    }
}