﻿using ShopListApp.Models;

using System.Collections.Generic;

namespace ShopListApp.Dtos
{
    public class AddShopItem
    {
        public ShopItem ShopItems { get; set; }
        public List<Shop> AllShops { get; set; }
    }
}