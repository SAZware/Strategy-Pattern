using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_Chap_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck myDuck = new MallardDuck();
            HelperFunction(myDuck);

            Console.WriteLine();

            myDuck.SetFly(new FlyWithJetPropulsion());
            myDuck.SetQuack(new Squeak());
            HelperFunction(myDuck);

            Console.WriteLine();

            WoodDuck woodDuck = new WoodDuck();
            HelperFunction(woodDuck);

            Console.ReadLine();
        }

        static void HelperFunction(Duck duck)
        {
            duck.Display();
            duck.Fly();
            duck.Quack();
        }
    }


}
