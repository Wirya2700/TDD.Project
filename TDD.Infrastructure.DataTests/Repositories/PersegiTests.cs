using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Infrastructure.Data.Repositories.Tests
{
    [TestClass()]
    public class PersegiTests
    {
        [TestMethod()]
        public void PersegiTest_Infinity_Panjang_Lebar()
        {
            try
            {
                Persegi persegi = new Persegi(double.MaxValue + double.MaxValue, double.MaxValue + double.MaxValue);

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "Panjang atau Lebar tak terhingga, tidak valid");
            }
        }

        [TestMethod()]
        public void TestPersegi_Hitung_Luas()
        {
            Persegi persegi = new Persegi(10, 10);

            Assert.IsTrue(persegi.Luas() == 100);
        }

        [TestMethod()]
        public void PersegiTest_Hitung_Luas_Infinity()
        {
            try
            {
                Persegi persegi = new Persegi(double.MaxValue, double.MaxValue);

                persegi.Luas();

                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message == "Luas tak terhingga, tidak valid");
            }
        }

        [TestMethod()]
        public void TestPersegi_Hitung_Keliling()
        {
            Persegi persegi = new Persegi(10, 10);

            Assert.IsTrue(persegi.Keliling() == (2 * (persegi.Panjang + persegi.Lebar)));
        }

        [TestMethod()]
        public void PersegiTest_Hitung_Keliling_Infinity()
        {
            Assert.Fail();
        }
    }
}