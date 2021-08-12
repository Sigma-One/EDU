using System;


namespace Main {
    internal class Program {
        private static void Main(string[] args) {
            MusicTrack garden = new MusicTrack("In The Garden", 10910);
            
            Console.WriteLine("Track " + garden.Name + " length is " + garden.Length + " seconds");
        }
    }
}