using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CarLibrary;

namespace SharedCarLibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shared assembly client");
            SportCar c = new SportCar("Pencil Light",120,90);
            c.TurboBoost();
                        
            c.TurnOnRadio(true, MusicMedia.musicCd);
            Console.WriteLine(c.ToString());
            c.CarGift(c);
            Console.ReadLine();

        }
    }
}
