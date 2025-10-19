namespace AbstractFactory.Domain.Products
{
    public sealed class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa() : base("Pizza calabresa", Enums.TipoMassa.Pizza)
        {
            Ingredientes.Add("Com calabresa");
        }
    }
}
