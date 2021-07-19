using System;
using System.Collections.Generic;
using CoffeeShopAPI.Models;

namespace CoffeeShopAPI.Interface
{
    public interface ISubMenu
    {
        List<SubMenu> GetSubMenus();
        List<SubMenu> GetSubMenus(int menuId);
        SubMenu AddSubMenu(SubMenu subMenu);
    }
}
