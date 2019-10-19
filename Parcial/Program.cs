using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //pedir impuesto
            float IMP;
            short CUOT;

            Console.WriteLine("INGRESE VALOR DEL IMPUESTO: ");
            IMP = float.Parse(Console.ReadLine());
            CPaquete.setIMPUESTO(IMP);

            //crear instancia
            CPaquete NUEVO;

            string DET;
            short PAQ;
            


            Console.WriteLine("INGRESE NUMERO DE PAQUETE: ");
            PAQ = short.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE DETALLE DEL PAQUETE: ");
            DET = Console.ReadLine();

            NUEVO = new CPaquete(PAQ, DET);

            Console.WriteLine("ESCRIBA PRECIO DEL PAQUETE: ");

            NUEVO.setPrecio(int.Parse(Console.ReadLine()));

            Console.WriteLine("INGRESE CANTIDAD DE CUOTAS: ");
            CUOT = short.Parse(Console.ReadLine());
            NUEVO.setCuotas(CUOT);
            


            //informar datos recientes

             Console.WriteLine(NUEVO.ToString());
            Console.ReadLine();

            


            //crear instancia
            CPaquete NUEVO2;


            Console.WriteLine("INGRESE NUMERO DE PAQUETE: ");
            PAQ = short.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE DETALLE DEL PAQUETE: ");
            DET = Console.ReadLine();

            NUEVO2 = new CPaquete(PAQ, DET);

            Console.WriteLine("ESCRIBA PRECIO DEL PAQUETE: ");

            NUEVO2.setPrecio(int.Parse(Console.ReadLine()));

            Console.WriteLine("INGRESE CANTIDAD DE CUOTAS: ");
            CUOT = short.Parse(Console.ReadLine());
            NUEVO2.setCuotas(CUOT);



            //informar datos recientes

            Console.WriteLine(NUEVO2.ToString());
            Console.ReadLine();

            if (NUEVO.esMasBaratoQue(NUEVO2) == true)

                Console.WriteLine("EL PRIMER PAQUETE ES MAS BARATO. ");

            else
                Console.WriteLine("EL SEGUNDO PAQUETE ES MAS BARATO. ");

            Console.ReadLine();



        }
    }
}
