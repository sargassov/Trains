using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TrainsRepository
    {
        private Train[] trains = {
            new Train(),
            new Train("Электровоз 2ЭС7", "Синара", "Россия", 3, 120, true),
            new Train("Электровоз ЭП20", "Трансмашхолдинг", "Россия"),
            new Train("Паровоз П36", "Коломенсский завод", "СССР", 251, 125, false),
            new Train("Сапсан-Velaro", "Siemens", "Россия", 10, 350, true) };

        public Train[] GetTrains()
        {
            return trains;
        }
    }


}
