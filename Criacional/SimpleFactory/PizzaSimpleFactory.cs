namespace SimpleFactory
{
    public sealed class PizzaSimpleFactory
    {
        public static Pizza CriaPizza(string tipo)
        {
            Pizza pizza;

            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;

                case "M":
                    pizza = new PizzaMussarela();
                    break;

                default:
                    throw new ArgumentException("");
            }

            return pizza;
        }
    }
}
