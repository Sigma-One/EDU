using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            Debt debt = new Debt(25, 1.1);
            
            debt.PrintAmount();
            debt.WaitOneYear();
            debt.PrintAmount();
            debt.WaitOneYear();
            debt.PrintAmount();
        }
    }
}