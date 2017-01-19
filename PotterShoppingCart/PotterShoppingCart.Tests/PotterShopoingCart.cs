using System;

namespace PotterShoppingCart.Tests
{
    internal class PotterShopoingCart
    {
        public PotterShopoingCart()
        {
        }

        internal int CalculatePrice(Book order)
        {
            return order.Price;
        }
    }
}