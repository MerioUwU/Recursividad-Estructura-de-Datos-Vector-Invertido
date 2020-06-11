using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir_vector_con_recursividad
{
    class Program
    {
        static int[] vectorA;//usas el vector global para usar sus parametros como limite

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tamaño del vector: ");
            vectorA = new int[int.Parse(Console.ReadLine())];//defines el tamaño del vector
            Console.Clear();
            for (int i = 0; i < vectorA.Length; i++)//llenas vector
            {
                Console.WriteLine("dame el dato #{0}",i+1);
                vectorA[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            int[] vectorB = new int[vectorA.Length];//creas un vector del tamaño del vector A, este es el que vamos a llenar al reves
            Revertir(0,vectorA.Length,vectorB);//metodo recursivo, ver abajo como sirve antes de avanzar en esta parte del main, mandas un 0 como contador, el tamaño del vector A como limite y el vectorB que ahora mismo esta vacio
            Console.WriteLine("Este es el vector original: ");//despliega vector original
            Desplegar(vectorA);//metodo despliegue
            Console.WriteLine("\nEste es el vector revertido: ");//despliega vector invertido
            Desplegar(vectorB);//metodo despliegue
            Console.ReadKey();//fin del programa
        }
        static void Revertir(int count , int limit, int[] vectorB)//ahora mismo cuando llamas el vector es 0, tamaño vector A y un vector B vacio
        {
            if (count < vectorA.Length && limit > 0)//doble condicion, mientras el contador sea menor al tamaño del vector A o B, y el limitante sea mayor a 0, ocurrira esto, posiblemente puedes usar cualquiera de las dos, elige la que prefieras
            {
                limit--;//el limite es el tamaño del vectorA, lo primero que haremos es restarle una unidad
                vectorB[count] = vectorA[limit];//el vector b en la posicion Count es igual al vector a en la posicion limit lta 
                count++;//sumamos un valro al contador, si sumamos el count antes o el limit despues, la ecuacion no sirve porque las posiciones serian incorrectas
                Revertir(count, limit, vectorB);//mandas tres cosas, el contador cojn una unidad mas, el limite con una menos, y el vector b con un elemento mas
            }
            //no necesitas else,si el if no se cumple el metodo se termina solo
        }
        static void Desplegar(int[] vector)//metodo despliegue, mandas un vector a o b y lo despliega de izquierda a derecha
        {
            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ",vector[i]);
            }
        }
    }
}
