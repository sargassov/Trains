using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*выбрал вариант 9 - поезд*/

    partial class Train
    {
        public string trainWhistle() { return "ГудООООООООООООООООООК!!!!\n"; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TrainsRepository trainsrepository = new TrainsRepository();
            for(short x = 0; x < trainsrepository.GetTrains().Length; x++)
            {
                Console.Write(x + 1 + ". ");
                Console.Write(trainsrepository.GetTrains()[x].Welcome());
                Console.WriteLine($"{trainsrepository.GetTrains()[x].Description}.\n Производитель " +
                    $"{trainsrepository.GetTrains()[x].Manufactured}.\n Страна эксплуатации " +
                    $"{trainsrepository.GetTrains()[x].CountryOfUsing}.\n Количество изготовленных единиц " +
                    $"{trainsrepository.GetTrains()[x].ValueOfUnits}.\n Конструкционная скорость " +
                    $"{trainsrepository.GetTrains()[x].ConstructionSpeed}.\n Электрическая тяга = " +
                    $"{trainsrepository.GetTrains()[x].IsElectric}.\n Находится в эксплуатации " +
                    $"{Train.CompanyUser}.\n Необходимы {Train.Mashinists} машиниста.");

                Console.Write(trainsrepository.GetTrains()[x].trainWhistle());
                Console.Write(trainsrepository.GetTrains()[x].LetsGo());

                trainsrepository.GetTrains()[x].LetsGo();
            }
        }
    }
}
