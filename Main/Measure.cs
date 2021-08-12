using System;

namespace Main {
    public class Measure {
        private int _value = 0;

        public void add() {
            if (_value < 5) { _value++; }
        }
        
        public void subtract() {
            if (_value > 0) { _value--; }
        }

        public int value() {
            return this._value;
        }

        public bool full() {
            if (_value == 5) { return true; }
            return false;
        }
    }
}