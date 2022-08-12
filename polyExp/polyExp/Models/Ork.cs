using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyExp.Models
{
    public class Ork : Karakter
    {
        Random random = new Random();

        public override int Hizlan()
        {
            return random.Next(5, 15);
        }
    }
}
