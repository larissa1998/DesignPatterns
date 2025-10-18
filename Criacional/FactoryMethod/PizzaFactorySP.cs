using FactoryMethod.Tipos;

namespace FactoryMethod
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new PizzaMussarelaSp();
            }
            if (tipo.Equals("C"))
            {
                return new PizzaCalabresaSp();
            }
            else return null;
        }
    }
}
