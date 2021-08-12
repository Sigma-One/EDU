using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            PaymentCard card_a = new PaymentCard(20);
            PaymentCard card_b = new PaymentCard(30);
            
            card_a.EatTastily();
            card_b.EatAffordably();
            
            Console.WriteLine("Pekka: " + card_a);
            Console.WriteLine("Matti: " + card_b);
            
            card_a.Charge(20);
            card_b.EatTastily();
            
            Console.WriteLine("Pekka: " + card_a);
            Console.WriteLine("Matti: " + card_b);
            
            card_a.EatAffordably();
            card_b.EatAffordably();
            card_b.Charge(50);
            
            Console.WriteLine("Pekka: " + card_a);
            Console.WriteLine("Matti: " + card_b);
        }
    }
}