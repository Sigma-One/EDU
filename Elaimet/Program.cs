using System;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/


namespace Elaimet {
    internal class Program {
        private static void Main(string[] args) {
            Hevonen hevonen = new Hevonen();

            Console.WriteLine("nimi  : " + hevonen.Nimi + "\npaino : " + hevonen.Paino + "\n");

            hevonen.Nimi = "Histamiini";
            hevonen.Paino = 89;

            Console.WriteLine("nimi  : " + hevonen.Nimi + "\npaino : " + hevonen.Paino);
        }
    }
}