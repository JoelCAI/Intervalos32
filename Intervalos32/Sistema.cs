using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalos32
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");


            DateTime fechaUno = Validador.ValidarFechaIngresada("\n Ingrese la primera fecha");

            DateTime fechaDos = Validador.ValidarFechaIngresada("\n Ingrese la segunda fecha");

            TimeSpan intervaloTiempo = fechaDos.Subtract(fechaUno) ;
            Console.Clear();

            
            Console.WriteLine("\n La diferencia de días entre ambas fechas es: " +
                             "\n Intervalo de tiempo en años es: " + intervaloTiempo.TotalDays/365 + "."+
                             "\n Intervalo de tiempo en meses es: " + intervaloTiempo.TotalDays/30  + "." +
                             "\n Intervalo de tiempo en días es: " + intervaloTiempo.Days/1 + "." );

            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
