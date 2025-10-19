using Builder.Builder;

namespace Builder.ConcreteBuilder
{
    public sealed class PizzaCalabresa : PizzaBuilder
    {
        public override void PrepararMassa()
        {
            pizza.TipoMassa = "Grossa";
            pizza.TipoBorda = "Normal";
            pizza.Tamanho = "Grande";
        }

        public override void IncluirIngredientes()
        {
            pizza.Ingredientes = new List<string> { "calabresa em fatias", "molho tomate" };
        }
    }
}
