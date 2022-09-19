using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaTime.Models;

namespace RazorPizzaTime.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public CustomPizzasModel Customed { get; set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice += Customed.BasePrice;

            if (Customed.TomatoSauce) { PizzaPrice += 1; }
            if (Customed.Cheese) { PizzaPrice += 1; }
            if (Customed.Chilli) { PizzaPrice += 1; }
            if (Customed.Chicken) { PizzaPrice += 1; }
            if (Customed.Tuna) { PizzaPrice += 1; }
            if (Customed.Beef) { PizzaPrice += 1; }
            if (Customed.Peperoni) { PizzaPrice += 1; }
            if (Customed.PineApple) { PizzaPrice += 10; }
            if (Customed.Mushroom) { PizzaPrice += 1; }

            return RedirectToPage("/Checkout/Checkout", new {Customed.CustomPizzaName, PizzaPrice});
        }
    }
}
