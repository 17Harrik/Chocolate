using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBar boost = new ChocolateBar("Boost", 31.5, false, 163);
            ChocolateBar rolo = new ChocolateBar("Rolo", 41.6, false, 200);

            boost.Eat();
            rolo.Eat();

        }
    }
}
