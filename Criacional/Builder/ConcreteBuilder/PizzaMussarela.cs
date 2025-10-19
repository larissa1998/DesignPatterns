using Builder.Builder;

namespace Builder.ConcreteBuilder
{
    public sealed class PizzaMussarela : PizzaBuilder
    {
        public override void PrepararMassa()
        {
            pizza.TipoMassa = "Normal";
            pizza.TipoBorda = "Recheada";
            pizza.Tamanho = "Grande";

        }

        public override void IncluirIngredientes()
        {
            pizza.Ingredientes = new List<string> { "mussarela", "molho tomate", "oregano" };
        }
    }
}
