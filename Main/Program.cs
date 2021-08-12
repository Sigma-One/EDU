using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            PaymentCard card = new PaymentCard(5);
            
            card.Charge(15);
            
            Console.WriteLine(card);
            
            card.Charge(10);
            card.Charge(200);
            
            Console.WriteLine(card);
        }
    }
}