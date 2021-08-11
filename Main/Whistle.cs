using System;

namespace Main {
    public class Whistle {
        private readonly string _sound;

        public Whistle(string sound) {
            this._sound = sound;
        }

        public void MakeSound() {
            Console.WriteLine(this._sound);
        }
    }
}