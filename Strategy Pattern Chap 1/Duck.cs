using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern_Chap_1
{
    public abstract class Duck
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
        }

        public virtual void Display()
        {
            Console.WriteLine("Generic Duck in the Duck class");
        }

        public virtual void Fly()
        {
            this.flyBehavior.Fly();
        }

        public virtual void Quack()
        {
            this.quackBehavior.Quack();
        }

        public virtual void SetFly(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public virtual void SetQuack(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
            : base(new FlyWithWings(), new QuackLikeMallard())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Mallard Duck Here");
        }
    }

    public class WoodDuck : Duck
    {
        public WoodDuck()
            : base(new CanNotFly(), new NoSound())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Wood Duck Here");
        }
    }
}
