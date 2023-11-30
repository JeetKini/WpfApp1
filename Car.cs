using System;

namespace Day5
{
    class Car :Vehical {
        
        public Car(string name)
            :base(name)
        {
            Console.WriteLine(name);

        }
    }
}
