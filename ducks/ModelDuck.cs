using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehvaior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
