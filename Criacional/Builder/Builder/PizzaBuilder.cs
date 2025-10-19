using Builder.Product;

namespace Builder.Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza { get; set; }
        public void CriarPizza()
        {
            pizza = new Pizza();
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
        public abstract void PrepararMassa();
        public abstract void IncluirIngredientes();
    }
}
