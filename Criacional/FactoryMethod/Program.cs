namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args) 
        {
            var localescolhido = Console.ReadLine();
            var pizzaEscolhida = Console.ReadLine();

            try
            {
                PizzaFactoryMethod pizzaria = PizzariaSimpleFactory.CriarPizzaria(localescolhido);

                var pizza = pizzaria.MontaPizza(pizzaEscolhida);

                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("Sucesso");
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString()); 
            }
        }
    }
}
//regras de negócios exige mais do que a criação do produto