using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//espacio de nombre 
namespace división
{
    //esta es la clase 
    class division
    {
        //atributos, caracterisiticas,campos 
        private double  num1;
        private double num2;

        public division (double n1, double n2)
        {
            //this sirve para asignar valor 
            this.num1 = n1;
            this.num2 = n2;
        }
        public division (double n1)
        {
            this.num1 = n1;
        }
        //Metodo 
        public double rdivi()
        {
            //return regresa vaalores 
            return (num1 / num2);

        }
    }
    //aqui termina la clase division 
}
//aqui termina el espacio de nombre 

