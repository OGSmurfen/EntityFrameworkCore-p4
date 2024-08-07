
using GettingStarted_EFCore_p4.Data;
using GettingStarted_EFCore_p4.Models;




using ContosoPizzaContext _context = new ContosoPizzaContext();


Product pizzaFungi = new Product()
{
    Name = "Fungi",
    Price = 12M
};

Product pizzaQuatro = new Product()
{
    Name = "Quattro Formagi",
    Price = 12M
};

_context.Products.Add(pizzaFungi);
_context.Add(pizzaQuatro);

_context.SaveChanges();
