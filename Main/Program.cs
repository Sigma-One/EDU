using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            Whistle duckWhistle = new Whistle("Quack");
            Whistle roosterWhistle = new Whistle("Peef");
            
            duckWhistle.MakeSound();
            roosterWhistle.MakeSound();
        }
    }
}