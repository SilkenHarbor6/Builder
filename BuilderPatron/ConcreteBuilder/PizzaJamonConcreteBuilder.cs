using BuilderPatron.Builder;
using BuilderPatron.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatron.ConcreteBuilder
{
    public class PizzaJamonConcreteBuilder : PizzaBuilder
    {
        Pizza oPizza = new Pizza();
        public void BuildIngrediente()
        {
            oPizza.SetIngrediente("Jamon");
        }

        public void BuildMasa()
        {
            oPizza.SetMasa("Americana");
        }

        public void BuildTipo()
        {
            oPizza.SetTipo("Gigante");
        }

        public Pizza GetPizza()
        {
            return this.oPizza;
        }
    }
}
