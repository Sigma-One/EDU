using System;

namespace Main {
    public class Product {
        private readonly string _name;
        private readonly int _amount;
        private readonly double _price;

        public Product(
            string name,
            int amount,
            double price
        ) {
            this._name = name;
            this._amount = amount;
            this._price = price;
        }

        public void PrintProduct() {
            Console.WriteLine(this._name + ", price " + this._price + ", " + this._amount + " pcs");
        }
    }
}