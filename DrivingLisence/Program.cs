using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat.
            //Programm arvutab kasutaja vanuse.
            //Kui kasutaja on noorem kui 18, siis programm kuvab konsooli
            //"Oled liiga noor, et juhilube saada";
            //Kui kasutaja on vanem kui 18, siis programm kuvab konsooli
            //"Oled piisavalt vana, et juhilube saada."
            //Kui kasutaja on 18, siis programm kuvab konsooli
            //"Palju õnne! Nüüd sa saad juhilube taotleda"

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotleda.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
