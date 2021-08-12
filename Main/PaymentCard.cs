using System;

namespace Main {
    public class PaymentCard { 

        private double _saldo;

        public PaymentCard(double saldo) {
            this._saldo = saldo;
        }

        public override String ToString() {
            return "There are " + _saldo + " euros on the card";
        }
    }
}