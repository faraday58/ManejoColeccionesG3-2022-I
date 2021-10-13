using System;
using System.Collections;

namespace ManejoColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList cadenasNumeros = new ArrayList();

            cadenasNumeros.Add("Uno");
            cadenasNumeros.Add("Dos");
            cadenasNumeros.Add("Tres");

            Console.WriteLine("Capacidad: {0}", cadenasNumeros.Capacity);
            for (int i =0; i  < cadenasNumeros.Count; i++    )
            {
                Console.WriteLine(" {0} posición: {1} ",cadenasNumeros[i],i);
            }

            cadenasNumeros.Remove("Dos");
            Console.WriteLine("El objeto Dos fue eliminado");
            for (int i = 0; i < cadenasNumeros.Count; i++)
            {
                Console.WriteLine(" {0} posición: {1}", cadenasNumeros[i],i);
            }
            Console.WriteLine("Capacidad: {0}", cadenasNumeros.Capacity);

            Console.WriteLine("Posición  del objeto 'Tres': {0} ", cadenasNumeros.IndexOf("Tres"));
            //Agregando valores numéricos a la colección
            cadenasNumeros.Add(4);
            cadenasNumeros.Add(5);
            for (int i = 0; i < cadenasNumeros.Count; i++)
            {
                if ( i > 1   )
                {
                    int numero = (int)cadenasNumeros[i];
                    Console.WriteLine("{0 }", numero + 2);
                }
                else
                {
                    Console.WriteLine(" {0} posición: {1}", cadenasNumeros[i], i);
                }
                
                
            }





            Console.ReadLine();
        }
    }
}
