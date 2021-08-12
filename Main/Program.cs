using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            PaymentCard card = new PaymentCard(5);
            
            Console.WriteLine(card);
            
            card.EatTastily();
            
            Console.WriteLine(card);
            
            card.EatTastily();

            Console.WriteLine(card);
        }
    }
}