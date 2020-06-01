﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Abstract
{
    public interface IShopNetwork
    {
        void CreateReservation(string shop, string product, int countOfProducts);
        List<string> GetShops(string nameOfProduct);
        List<string> GetProducts();


    }
}