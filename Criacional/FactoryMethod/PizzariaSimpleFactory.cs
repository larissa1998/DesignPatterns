namespace FactoryMethod
{
    public class PizzariaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;

            switch (local)
            {
                case "S":
                    pizzaria = new PizzaFactorySP();
                    break;
                case "R":
                    pizzaria = new PizzaFactoryRj();
                    break;
                default:
                    throw new Exception("");
            }

            return pizzaria;
        }
    }
}
