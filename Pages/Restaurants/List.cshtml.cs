using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restarauntData;

        public string Message { get; private set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration config, 
                        IRestaurantData restarauntData)
        {
            this.config = config;
            this.restarauntData = restarauntData;
        }

        public void OnGet()
        {
            //Message = config["Message"];
            Restaurants = restarauntData.GetAllRestaurants();
        }
    }
}
