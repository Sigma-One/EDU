using System;

namespace Main {
    public class Debt {
        private readonly double _interest;
        private double _amount;

        public Debt(
            double amount,
            double interest
        ) {
            this._amount = amount;
            this._interest = interest;
        }

        public void PrintAmount() {
            Console.WriteLine(_amount + "€");
        }

        public void WaitOneYear() {
            this._amount *= this._interest;
        }
    }
}