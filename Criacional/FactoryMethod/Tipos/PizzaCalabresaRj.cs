namespace FactoryMethod.Tipos
{
    public class PizzaCalabresaRj : Pizza
    {
        public PizzaCalabresaRj()
        {
            Nome = "Calabresa RJ";
            Massa = "Massa fina RJ";
            Molho = "molho RJ";
            Ingredientes.Add("Queijo RJ");
            Ingredientes.Add("Azeitonas RJ");
        }
    }
}
