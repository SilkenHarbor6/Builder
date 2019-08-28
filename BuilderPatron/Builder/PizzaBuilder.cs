using BuilderPatron.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatron.Builder
{
    public interface PizzaBuilder
    {
        //metodos necesarios para construir la pizza, segun los atributos de la clase
        void BuildMasa();
        void BuildIngrediente();
        void BuildTipo();
        //metodo para obtener el producto ya construido
        Pizza GetPizza();
    }
}
