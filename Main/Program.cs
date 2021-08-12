using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            Measure m = new Measure();

            while (!m.full()) {
                Console.WriteLine("Not Full, currently " + m.value());
                m.add();
            }
            
            Console.WriteLine("Full, currently " + m.value());
            
            m.subtract();
            
            Console.WriteLine("Not Full, currently " + m.value());
        }
    }
}