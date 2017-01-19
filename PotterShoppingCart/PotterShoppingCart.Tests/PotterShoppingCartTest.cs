using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart.Tests
{


    [TestClass]
    public class PotterShoppingCartTest
    {


        public PotterShoppingCartTest() {
         
        }

        [TestMethod]
        public void 第一集買了一本_其他都沒買_價格應為_100_mult_1_is_100() {
            //arrange
            var target = new PotterShopoingCart();
            var order = new Book() {Name = "Harry Potter Vol.1" , Volume = 1,Price = 100 };
            var expected = 100;

            //act
            var actual = target.CalculatePrice(order);

            //assert
            //Assert.Fail();
            Assert.AreEqual(expected, actual);
        }



    }


}
