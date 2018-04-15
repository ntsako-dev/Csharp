using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Diagnostics.Debug;

namespace Classes
{
    class Program
    {

        public class Person
        {

           
            public String name;
            public void Introduce(String to)
            {
                Console.WriteLine("Hi {0}, I am {1}", to, name);
                
            }
        }

        static void Main(string[] args)
        {
            var person = new Person();
            person.name = "Ntsako";
            person.Introduce("Mboweni");

            Console.WriteLine("");
            Console.WriteLine("");

            FileStreamer fs = new FileStreamer();
            fs.openCustFile();
            fs.readCustFile();
            Console.WriteLine(fs.GetCustData());


        }
    }
}
