using System;

namespace Main {
    public class PaymentCard { 

        private double _saldo;

        public PaymentCard(double saldo) {
            this._saldo = saldo;
        }

        public void EatAffordably() {
            this._saldo -= 2.60;
            if (this._saldo < 0) { this._saldo += 2.60; }
        }

        public void EatTastily() {
            this._saldo -= 4.60;
            if (this._saldo < 0) { this._saldo += 4.60; }
        }

        public void Charge(double amount) {
            if (amount > 0) {
                this._saldo += amount;
            }
        }
        
        public override String ToString() {
            return "There are " + _saldo + " euros on the card";
        }
    }
}