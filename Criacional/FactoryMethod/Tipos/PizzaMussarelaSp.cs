namespace FactoryMethod.Tipos
{
    public class PizzaMussarelaSp : Pizza
    {
        public PizzaMussarelaSp() {
            Nome = "Mussarela SP";
            Massa = "Massa fina sp";
            Molho = "molho paulista";
            Ingredientes.Add("Queijo mussarela");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}
