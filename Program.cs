using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Instrucciones
{
    class Program
    {
        static void Main(string[] args)
        {
           //goto

            for (int id = 1; id<=10; id++)
            {
                Thread.Sleep(800);
                if(id == 8)
                {
                    goto liquidacion;
                }
                Console.WriteLine(id);

            }

        liquidacion:
            Console.WriteLine("se envio al dpto de contabilidad");
            Console.ReadKey();

        }
    }
}
