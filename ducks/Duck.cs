using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks
{
    public class Duck
    {
        public IFlyBehavior flyBehvaior;
        public IQuackBehavior quackBehavior;

        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehvaior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }

        public virtual void performQuack()
        {
            quackBehavior.quack();
        }

        public virtual void performFly()
        {
            flyBehvaior.fly();
        }

        public virtual void swim() { }

        public virtual void display() { }
    }
}
