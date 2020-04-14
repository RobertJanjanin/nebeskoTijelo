using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nebeskoTijelo
{
    class Planet
    {
        class Planet : NebeskoTijelo
        {
            public Planet(double brzinaOkoOsi, double brzinaOkoSunca)
            {
                BrzinaOkoOsi = brzinaOkoOsi;
                BrzinaOkoSunca = brzinaOkoSunca;
            }
}
