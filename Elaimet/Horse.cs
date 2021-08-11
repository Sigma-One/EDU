using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{   //Esitellään luokka eli class. Koodi olisi voinut olla Program.cs tiedostossa mutta selkeyden takia luomme jokaisen luokan
    //omaan tiedostoonsa
    public class Horse
    {
        //Alla konstruktori jossa ei ola parametreja, joten kaikki luokasta 
        //synnytetyt oliot ovat samanlaisia. Konstruktorin tunnistaa siitä
        // ettei siinä ole palautustyyppiä ja metodin _name on sama kuin luokannimi
        public Horse()
        {
            //Konstruktorissa voi olla oletusarvoja
            //Luokan sisällä voidaan käyttää privaatti kenttiä
            Name = "";
            Weight = 0;
        }
        //getterillä ja setterillä annetaan luokan ulkopuolisille sovelluksille mahdollisuus 
        //asettaa tai hakea kenttiä
        public string Name { get; set; }
        public int Weight { get; set; }
    }
}
