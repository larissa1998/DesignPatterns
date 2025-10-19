using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
    public sealed class BoloFactory : MassaAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;

            switch (tipoBolo)
            {
                case TipoBolo.chocolate:
                    return new BoloChocolate();
                case TipoBolo.Laranja:
                    return new BoloLaranha();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
