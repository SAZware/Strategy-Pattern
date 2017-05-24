using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_Chap_1
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying!!!");
        }
    }

    public class CanNotFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No Fly...I'm Stuck on the Groud!!!");
        }
    }

    public class FlyWithJetPropulsion : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Zoom,Zoom,Zoo...I'm Flying w/ Jet Propulsion!!!");
        }
    }

    public class QuackLikeMallard : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I Quack like a Mallard!!!");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I Squeak!!!");
        }
    }

    public class NoSound : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("No Sound from Me!!!");
        }
    }

}

