using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeShopAPI.Interface;
using CoffeeShopAPI.Models;
using GraphQlProject.Data;

namespace CoffeeShopAPI.Service
{
    public class MenuService:IMenu
    {
        private GraphQLDbContext _dbContext;

        public MenuService(GraphQLDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Menu AddMenu(Menu menu)
        {
            _dbContext.Menus.Add(menu);
            _dbContext.SaveChanges();
            return menu;
        }

        public List<Menu> GetMenues()
        {
            return _dbContext.Menus.ToList();
        }
    }
}
