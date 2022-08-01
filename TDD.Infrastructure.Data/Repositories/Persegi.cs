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
            throw new NotImplementedException();
        }

        public double Luas()
        {
            throw new NotImplementedException();
        }
    }
}
