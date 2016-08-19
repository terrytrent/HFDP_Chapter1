using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
