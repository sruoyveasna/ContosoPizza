using ContosoPizza.Models;
namespace ContosoPizza.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas { get; }
        static PizzaService()
        {
            Pizzas = [
                new Pizza { Id = 1, Name = "Margherita", Price = 8.90f, Size = "M", Description = "for four members", IsGlutenFree = true },
                new Pizza { Id = 2, Name = "Pepperoni", Price = 9.90f, Size = "L", Description = "for five members", IsGlutenFree = false },
                new Pizza { Id = 3, Name = "Hawaiian", Price = 10.90f, Size = "XL", Description = "for six members", IsGlutenFree = false },
                new Pizza { Id = 4, Name = "Veggie Delight", Price = 9.50f, Size = "M", Description = "for four members", IsGlutenFree = true }
            ];
        }
        public static List<Pizza> GetAll() => Pizzas;

        public static Pizza? GetById(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public static void Add(Pizza pizza)
        {
            pizza.Id = Pizzas.Count + 1;
            Pizzas.Add(pizza);
        }
        public static void Delete(int id)
        {
            var pizza = GetById(id);
            if (pizza is null)
                return;
            Pizzas.Remove(pizza);
        }
        public static void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index == -1)
                return;
            Pizzas[index] = pizza;
        }

    }
}
