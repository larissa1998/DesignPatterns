namespace SimpleFactory
{
    public class Pizzaria
    {
        public static void SolicitaPizza()
        {
            Console.WriteLine("Pizzaria");
            Console.WriteLine("Qual pizza");
            var tipo = Console.ReadLine();

            try
            {
                Pizza pizza = PizzaSimpleFactory.CriaPizza(tipo);
                pizza.Preparar();
                pizza.Assar(10);
                pizza.Embalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
