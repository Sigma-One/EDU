using System;

/**
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Horse ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Horse -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle. 
**/


namespace Elaimet {
    internal class Program {
        private static void Main(string[] args) {
            Horse horse = new Horse();

            Console.WriteLine("name  : " + horse.Name + "\nweight : " + horse.Weight + "\n");

            horse.Name = "Histamiini";
            horse.Weight = 89;

            Console.WriteLine("name  : " + horse.Name + "\nweight : " + horse.Weight);
        }
    }
}