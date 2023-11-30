using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program
    {
        
        
        public static int add(int a,int b) {
            int c = a + b;
            return c;
        }
       
        public static int add(int a, int b,int c)
        {
            int d = a + b+c;
            return d;
        }

        static void Main(String[] args)
        {

            //var student = new Student (1,"jeet");
            //Console.WriteLine("{0} , {1}",student.id ,student.name);
            //Console.WriteLine(student.name +"  " +student.id);

            //Console.WriteLine(add(10, 10));
            //Console.WriteLine(add(10,20,30));

            //StringBuilder sb = new StringBuilder("Hello ");
            //sb.Append(student.name);
            //Console.WriteLine(sb);
            //sb.AppendLine();
            //Console.WriteLine(sb.ToString());
            //Console.WriteLine(sb.Insert(10," kini" ));
            //Console.WriteLine(sb.Replace("Hello","Hii"));
            //Console.WriteLine(sb.Length);

            // var boy = new Boy();
            // Console.WriteLine(boy.idea);
            //// boy.idea = 20;
            // Console.WriteLine(boy.idea);

            // var t=new TimeSpan(1,2,3);
            // Console.WriteLine(t);

            //var child=new Child();
            //child.Talk();
            //child.Walk();

            /*var migrate=new DbMigrator(new Logger());
            //var logger = new Logger();
            //var install = new Installer(logger);
            //migrate.Migrate();
            //install.Install();
            ////Console.WriteLine(Installer.id);
            //logger.logger("Done With the Setup");

            //var p=new Program();
            //p.pro();*/

            //var c = new Car("jeet");

            Shape shape = new Circle();//upcasting
                                       //Console.WriteLine(shape.a);


            //Circle circle1 = (Circle)shape;//downcasting
            //Console.WriteLine(circle1.a);
            //Console.WriteLine(circle1.b);

            //Circle cc=shape as Circle;
            //Console.WriteLine(cc.a);
            //Console.WriteLine(cc.b);

            //if (shape is Shape)
            //{
            //    Console.WriteLine("true");
            //}

            //Boxing
            //int i = 15;
            //Object obj = i;
            //Console.WriteLine(obj);
            //obj = 35;
            ////unboxing
            //bool num = (bool)obj;
            //Console.WriteLine(num);
           



















        }
    }
}
