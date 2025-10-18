namespace FactoryMethod.Tipos
{
    public class PizzaMussarelaRj : Pizza
    {
        public PizzaMussarelaRj()
        {
            Nome = "Mussarela Rj";
            Massa = "Massa fina Rj";
            Molho = "molho Rj";
            Ingredientes.Add("Queijo Rj");
            Ingredientes.Add("Azeitonas Rj");
        }
    }
}
