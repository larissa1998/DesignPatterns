﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;
using Builder.Product;

namespace Builder.Director
{
    public class Pizzaria
    {
        private readonly PizzaBuilder builder;

        public Pizzaria(PizzaBuilder builder)
        {
            this.builder = builder;
        }

        public void MontaPizza()
        {
            builder.CriarPizza();
            builder.PrepararMassa();
            builder.IncluirIngredientes();
        }

        public Pizza GetPizza()
        {
            return builder.GetPizza();
        }
    }
}
