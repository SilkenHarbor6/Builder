using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatron.Model
{
    public class Pizza
    {
        //declaracion de atributos
        private String Masa { get; set; }
        private String Ingrediente { get; set; }
        private String Tipo { get; set; }
        //metodos para obtener los valores
        #region setters
            public void SetMasa(String masa)
            {
                this.Masa = masa;
            }
            public void SetTipo(String tipo)
            {
                this.Tipo = tipo;
            }
            public void SetIngrediente(String ingrediente)
            {
                this.Ingrediente = ingrediente;
            }
        #endregion
        //metodos para asignar los valores
        #region getters
            public String GetMasa()
            {
                return this.Masa;
            }
            public String GetTipo()
            {
                return this.Tipo;
            }
            public String GetIngrediente()
            {
                return this.Ingrediente;
            }
        #endregion

    }
}
