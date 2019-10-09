using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
//Tiziana Amicarella Girardi C.I 26.290.998 
//PROBLEMA 1: FRACCIONES MIXTAS 

namespace diferido
{
    class Program
    {
        static void Main(string[] args)
        {
            //creando el archivo
            /*StreamWriter archivo;
            archivo = new StreamWriter("fracciones2.in");    
            string mensaje;
            mensaje = Console.ReadLine();
            archivo.WriteLine(mensaje);
            archivo.Close(); 
            Console.Clear();
            Console.WriteLine("Se a guardo archivo");*/

            //StreamReader archivo = new StreamReader("fracciones.in");
            /*-------------OJO------------------------------------ */
            StreamReader archivo = new StreamReader("fracciones2.in"); //CASO DE PRUEBA ADICIONAL
            string linea; //= String.Empty;
            int reciduo,cociente;
            string []numeros;
            
            try
            {   linea = archivo.ReadLine();
                numeros = new string[2];
                do{
                    while(linea != "0 0"){
                        numeros = linea.Split(" ");
                        //Console.WriteLine("  "+linea);
                        cociente = Convert.ToInt32(numeros[0]) / Convert.ToInt32(numeros[1]);
                        reciduo = Convert.ToInt32(numeros[0]) % Convert.ToInt32(numeros[1]);
                        System.Console.WriteLine(cociente +" "+reciduo+"/"+numeros[1]);
                        linea = archivo.ReadLine();
                    }
                }while(linea == null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            System.Console.ReadKey();
            archivo.Close();
        }
    }
}
