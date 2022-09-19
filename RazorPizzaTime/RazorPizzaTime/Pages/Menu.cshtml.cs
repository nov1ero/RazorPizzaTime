using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaTime.Models;

namespace RazorPizzaTime.Pages
{
    public class MenuModel : PageModel
    {
        public List<CustomPizzasModel> FakeMenuDB = new List<CustomPizzasModel>()
        {
            new CustomPizzasModel() { ImageTitle = "Margerita", CustomPizzaName="Margerita", BasePrice=2, TomatoSauce =true, Cheese=true,FinalPrice=4},
            new CustomPizzasModel() { ImageTitle = "Bolognese", CustomPizzaName="Bolognese", BasePrice=2, TomatoSauce =true, Cheese=true,Beef=true, FinalPrice=5},
            new CustomPizzasModel() { ImageTitle = "Hawaiian", CustomPizzaName="Hawaiian", BasePrice=2, TomatoSauce =true, Cheese=true,Chicken=true, PineApple=true, FinalPrice=15},
            new CustomPizzasModel() { ImageTitle = "Carbonara", CustomPizzaName="Carbonara", BasePrice=2, TomatoSauce =true, Cheese=true, Chicken=true, Mushroom= true,FinalPrice=6},
            new CustomPizzasModel() { ImageTitle = "MeatFeast", CustomPizzaName="MeatFeast", BasePrice=2, TomatoSauce =true, Cheese=true,Chicken=true, Beef=true, FinalPrice=6},
            new CustomPizzasModel() { ImageTitle = "Mushroom", CustomPizzaName="Mushroom", BasePrice=2, TomatoSauce =true, Cheese=true, Mushroom=true, FinalPrice=5 },
            new CustomPizzasModel() { ImageTitle = "Pepperoni", CustomPizzaName="Pepperoni", BasePrice=2, TomatoSauce =true, Cheese=true,Peperoni=true, FinalPrice=5},
            new CustomPizzasModel() { ImageTitle = "Seafood", CustomPizzaName="Seafood", BasePrice=2, TomatoSauce =true, Cheese=true, Tuna=true, FinalPrice=5},
            new CustomPizzasModel() { ImageTitle = "Vegetarian", CustomPizzaName="Vegetarian", BasePrice=2, TomatoSauce =true, Cheese=true,Mushroom=true, PineApple=true, FinalPrice=12},
        };
        public void OnGet()
        {
        }
    }
}
