using System;
using System.Collections.Generic;
using CoffeeShopAPI.Models;

namespace CoffeeShopAPI.Interface
{
    public interface IMenu
    {
        List<Menu> GetMenues();
        Menu AddMenu(Menu menu);
    }
}
