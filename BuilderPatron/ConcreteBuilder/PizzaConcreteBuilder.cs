using BuilderPatron.Builder;
using BuilderPatron.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatron.ConcreteBuilder
{
    //Implementacion de la interfaz
    public class PizzaConcreteBuilder : PizzaBuilder
    {
        Pizza oPizza = new Pizza();
        //adaptacion de los metodos segun el tipo de producto que se desee construir
        public void BuildMasa()
        {
            oPizza.SetMasa("Napolitana");
        }

        public Pizza GetPizza()
        {
            return this.oPizza;
        }

        public void BuildIngrediente()
        {
            oPizza.SetIngrediente("Peperonni");
        }

        public void BuildTipo()
        {
            oPizza.SetTipo("Normal");
        }
    }
}
