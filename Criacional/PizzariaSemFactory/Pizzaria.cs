using System.Threading.Channels;

namespace PizzariaSemFactory
{
    public class Pizzaria
    {
        public static void SolicitarPizza()
        {
            PizzaCalabresa pizza1;
            PizzaMussarela pizza2;

            Console.WriteLine("Pizzaria");
            Console.WriteLine("Informe a pizza");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            if (pizzaEscolhida.Equals("C"))
            {
                pizza1 = new PizzaCalabresa();
                pizza1.Preparar();
                pizza1.Assar(10);
                pizza1.Embalar();
            } else if (pizzaEscolhida.Equals("M"))
            {
                pizza2 = new PizzaMussarela();
                pizza2.Preparar();
                pizza2.Assar(10);
                pizza2.Embalar();
            }
        }
    }
}
