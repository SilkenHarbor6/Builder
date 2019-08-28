using BuilderPatron.Builder;
using BuilderPatron.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatron.ConcreteBuilder
{
    class PizzaHawaianaCB : PizzaBuilder
    {
        Pizza Opizza = new Pizza();
        public void BuildIngrediente()
        {
            Opizza.SetIngrediente("Piña y jamon");
        }

        public void BuildMasa()
        {
            Opizza.SetMasa("Napolitana");
        }

        public void BuildTipo()
        {
            Opizza.SetTipo("Hawaiana");
        }

        public Pizza GetPizza()
        {
            return Opizza;
        }
    }
}
