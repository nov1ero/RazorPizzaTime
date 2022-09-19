namespace RazorPizzaTime.Models
{
    public class CustomPizzasModel
    {
        public string? ImageTitle { get; set; }
        public string CustomPizzaName { get; set; }
        public int BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool PineApple { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Beef { get; set; }
        public bool Chilli { get; set; }
        public bool Chicken { get; set; }
        public float FinalPrice { get; set; }

    }
}
