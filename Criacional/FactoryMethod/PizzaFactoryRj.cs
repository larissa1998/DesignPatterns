using FactoryMethod.Tipos;

namespace FactoryMethod
{
    public class PizzaFactoryRj : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new PizzaMussarelaRj();
            }
            if (tipo.Equals("C"))
            {
                return new PizzaCalabresaRj();
            }
            else return null;
        }
    }
}
