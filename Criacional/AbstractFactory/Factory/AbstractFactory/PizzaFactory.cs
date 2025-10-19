using System;
using System.Collections.Generic;
using AbstractFactory.Domain.Enums;
using AbstractFactory.Domain.Products;

namespace AbstractFactory.Factory.AbstractFactory
{
    public sealed class PizzaFactory : MassaAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                    return new PizzaMussarela();
                case TipoPizza.Calabresa:
                    return new PizzaCalabresa();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
