﻿using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            PaymentCard card = new PaymentCard(50);
            
            Console.WriteLine(card);
            
            card.EatAffordably();
            
            Console.WriteLine(card);
            
            card.EatTastily();
            card.EatAffordably();
            
            Console.WriteLine(card);
        }
    }
}