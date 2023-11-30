using System;

namespace Day5
{
    class Parent { 
       
    int a=10,b=20,c=30;
        protected void pro() {
            Console.WriteLine("I am Protected");
        }
        public void Walk()
        {
            Console.WriteLine("Walking");
            Console.WriteLine("{0},{1}",a,b);
        }
        public void Talk()
        {
            Console.WriteLine("Taklink");
            Console.WriteLine(c);
        }
    }
}
