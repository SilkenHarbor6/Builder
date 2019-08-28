using BuilderPatron.Builder;
using BuilderPatron.ConcreteBuilder;
using BuilderPatron.Director;
using BuilderPatron.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatron
{
    class Program
    {
        public static PizzaDirector Pdirector = new PizzaDirector();

        public static void MostrarPizza()
        {
            Pizza pizza = Pdirector.GetPizza();
            Console.WriteLine("El tipo de masa es: {0}",pizza.GetMasa());
            Console.WriteLine("El ingrediente de la pizza es: {0}", pizza.GetIngrediente());
            Console.WriteLine("El tipo de la pizza es: {0}", pizza.GetTipo());
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            PizzaBuilder pb;
            bool flag=true;
            do
            {
                //menu
                Console.Clear();
                Console.WriteLine("Ingrese el tipo de pizza que desea:");
                Console.WriteLine("1-Jamon");
                Console.WriteLine("2-Peperonni");
                Console.WriteLine("3-Hawaiana");
                Console.WriteLine("4-Salir");
                //seleccion de opcion en el menu
                int ind = Convert.ToInt32(Console.ReadLine());
                //accion segun el indice seleccionado
                Console.Clear();
                switch (ind)
                {
                    case 1:
                        pb = new PizzaJamonConcreteBuilder();
                        Pdirector.SetBuilder(pb);
                        Pdirector.BuildPizza();
                        MostrarPizza();
                        break;
                    case 2:
                        pb = new PizzaConcreteBuilder();
                        Pdirector.SetBuilder(pb);
                        Pdirector.BuildPizza();
                        MostrarPizza();
                        break;
                    case 3:
                        pb = new PizzaHawaianaCB();
                        Pdirector.SetBuilder(pb);
                        Pdirector.BuildPizza();
                        MostrarPizza();
                        Console.ReadKey();
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("El indice ingresado no es valido");
                        Console.ReadKey();
                        break;
                }
                
            } while (flag);
            
        }
    }
}
