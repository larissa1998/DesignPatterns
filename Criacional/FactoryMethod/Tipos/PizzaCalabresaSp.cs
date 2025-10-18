namespace FactoryMethod.Tipos
{
    public class PizzaCalabresaSp : Pizza
    {
        public PizzaCalabresaSp()
        {
            Nome = "Calabresa SP";
            Massa = "Massa fina sp";
            Molho = "molho paulista";
            Ingredientes.Add("Queijo Calabresa");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}
