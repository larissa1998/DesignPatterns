namespace AbstractFactory.Domain.Products
{
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base("Pizza mussarela", Enums.TipoMassa.Pizza)
        {
            Ingredientes.Add("Com mussarela");
        }
    }
}
