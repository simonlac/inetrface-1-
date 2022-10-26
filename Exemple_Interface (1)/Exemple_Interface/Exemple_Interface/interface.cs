using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_Interface
{
    class Program
    {
        interface IAnimal
        {
            string Name { get; }
            void Move();
        }

        class Dog : IAnimal
        {
            private string name;
            
            // On implémente la propriét Name ici.
            public string Name
            {
                get {return name;}
            }
            // Le constructeur de la classe Dog
            public Dog(string p_name)
            {
                name = p_name;
            }

            // On implémente la méthode Move ici.
             public void Move()
            {
                Console.WriteLine("{0} bouge.", name);
            }
        }
        
        static void Main(string[] args)
        {
            Dog d1 = new Dog("Bob");
            d1.Move();
            // Stocker un objet de type Dog dans un autre type : IAnimal
            IAnimal d2 = new Dog("Jon");
            d2.Move();
            Console.ReadKey();
        }

    }
}
