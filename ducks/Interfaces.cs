using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ducks
{
    public interface IFlyBehavior
    {
        void fly();
    }

    public interface IQuackBehavior
    {
        void quack();
    }
}
