using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Infrastructure.Data.Interfaces;

namespace TDD.Infrastructure.Data.Repositories
{
    public class Persegi : IPersegi
    {
        public double Panjang { get; set; }
        public double Lebar { get; set; }

        public Persegi(double panjang, double lebar)
        {
            Panjang = panjang;
            Lebar = lebar;

            if(double.IsInfinity(panjang) || double.IsInfinity(lebar))
            {
                throw new Exception("Panjang atau Lebar tak terhingga, tidak valid");
            }
        }

        public double Keliling()
        {
            double keliling = 2*(Panjang + Lebar);

            return keliling;
        }

        public double Luas()
        {
            double luas = Panjang * Lebar;

            if (double.IsInfinity(luas))
            {
                throw new Exception("Luas tak terhingga, tidak valid");
            }

            return luas;
        }
    }
}
