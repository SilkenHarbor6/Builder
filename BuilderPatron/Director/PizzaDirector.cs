using BuilderPatron.Builder;
using BuilderPatron.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatron.Director
{
    public class PizzaDirector
    {
        //se crea una variable del tipo de la interfaz
        private PizzaBuilder PizzaBuilder;
        public void SetBuilder(PizzaBuilder pb)
        {
            this.PizzaBuilder = pb;
        }
        //se pide el objeto construido al concreteBuilder y se retorna al cliente
        public Pizza GetPizza()
        {
            return PizzaBuilder.GetPizza();
        }
        //se le indica al concrete builder que construya la pizza
        public void BuildPizza()
        {
            PizzaBuilder.BuildMasa();
            PizzaBuilder.BuildIngrediente();
            PizzaBuilder.BuildTipo();
        }
    }
}
