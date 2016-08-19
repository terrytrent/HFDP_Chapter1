using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ducks;

namespace MiniDuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();


            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}
