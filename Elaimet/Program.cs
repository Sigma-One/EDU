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

            Cat catA = new Cat();
            catA._name = "spam";
            Console.WriteLine("Cat 1 name : " + catA.Name);
            catA.Name = "eggs";
            Console.WriteLine("Cat 1 name : " + catA.Name);

            Cat catB = new Cat(5, "foobar");
            Console.WriteLine("Cat 2 name : " + catB.Name + "\nCat 2 age  : " + catB.Age);
            /*Console.WriteLine("name  : " + horse.Name + "\nweight : " + horse.Weight + "\n");

            horse.Name = "Histamiini";
            horse.Weight = 89;

            Console.WriteLine("name  : " + horse.Name + "\nweight : " + horse.Weight);*/
        }
    }
}