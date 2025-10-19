using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
    public abstract class MassaAbstractFactory
    {
        public abstract MassaBase CriarMassa(TipoMassa tipoMassa);
        public static MassaAbstractFactory CriarFabricaMassas(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                {
                    return new PizzaFactory();
                }

                case TipoMassa.Bolo:
                {
                    return new BoloFactory();
                }

                default:
                    throw new ArgumentOutOfRangeException(nameof(TipoMassa), tipoMassa, null);
            }
        }
    }
}
