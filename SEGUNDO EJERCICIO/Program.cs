using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tiziana Amicarella Girardi C.I 26.290.998 
//PROBLEMA NUMERO 3: INTERSECCION 

namespace SEGUNDO_EJERCICIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //creando el archivo
            /*StreamWriter archivo;
            archivo = new StreamWriter("inter.in");    
            string mensaje;
            mensaje = Console.ReadLine();
            archivo.WriteLine(mensaje);
            archivo.Close(); 
            Console.Clear();
            Console.WriteLine("Se a guardo archivo");*/
            
            //StreamReader archivo = new StreamReader("inter.in");
            /* -------------- OJO ------------------------------ */
            StreamReader archivo = new StreamReader("inter2.in"); //CASO PRUEBA ADICIONAL
            String linea;
            String[] cadena;
            int[] vector;
            int n;
            int No=0;
            int Si=0;
            int contadorX=0; //cuando son dif
            int contadorX1=0; //cuando son igual

            int contadorY=0; //cuando son dif
            int contadorY1=0; //cuando son igual

            int contadorD=0; //cuando son dif
            int contadorD1=0; //cuando son iguales
            
            int contadorI=0; //cuando son dif
            int contadorI2=0; //cuando son iguales

            int xinicio, yinicio,xfin,yfin; //LINEA
            int xizquierdo, yarriba, xderecho, yabajo; //RECTANGULO 
            /*string []intersec;
            //string []cant;*/

            n = Convert.ToInt16(archivo.ReadLine());
            vector = new int[n];

            Console.WriteLine("Entrada");
            //Console.WriteLine(" " + n);

            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("hola");
                linea = archivo.ReadLine();
                cadena = linea.Split(' ');
                
                xinicio = Convert.ToInt32(cadena[0]);
                yinicio = Convert.ToInt32(cadena[1]);
                xfin = Convert.ToInt32(cadena[2]);
                yfin = Convert.ToInt32(cadena[3]);

                xizquierdo = Convert.ToInt32(cadena[4]);
                yarriba =  Convert.ToInt32(cadena[5]);
                xderecho = Convert.ToInt32(cadena[6]);
                yabajo = Convert.ToInt32(cadena[7]);

                System.Console.WriteLine("LINEA: "+xinicio+" "+yinicio+" "+xfin+" "+yfin);
                System.Console.WriteLine("RECTANGULO: "+xizquierdo+" "+yarriba+" "+xderecho+" "+yabajo);
                
                //System.Console.WriteLine("ARRIBA"); 
                if(xinicio == xizquierdo){
                    contadorX1+=1; //1
                    //System.Console.WriteLine("se intersectan las X");
                }else{
                    contadorX+=1; //0
                    //System.Console.WriteLine("no i");
                }
                if(xinicio == yarriba){
                    contadorX1+=1; //0
                    //System.Console.WriteLine("se intersectan las X");
                }else{
                    contadorX+=1; //1
                    //System.Console.WriteLine("no i");
                }
                if(yinicio == xizquierdo){
                    contadorX1+=1;
                    //System.Console.WriteLine("se intersectan las X");
                }else{
                    contadorX+=1;
                    //System.Console.WriteLine("no i");
                }
                if (yinicio == yarriba)
                {
                    contadorX1+=1; //1
                    //System.Console.WriteLine("se intersectan las X");
                }else{
                    contadorX+=1;
                    //System.Console.WriteLine("no i");
                }
                if(contadorX != 0){
                    No+=1;
                    //System.Console.WriteLine("No intersectadas: "+contadorX);
                }
                if (contadorX1 >= 1)
                {   
                    Si+=1;
                   // System.Console.WriteLine("ARRIBA Intersectadas: "+contadorX);
                }
                //---------------------------------------------------------  
                //contadorY=0 cuando son difi * contadorY1=0 cuando son igual
                //System.Console.WriteLine("ABAJO");
                if(xfin == xderecho){
                    contadorY1+=1;
                }else{
                    contadorY+=1;
                }
                if(xfin == yabajo){
                    contadorY1+=1;
                }else{
                    contadorY+=1;
                }
                if(yfin == xderecho){
                    contadorY1+=1;
                }else{
                    contadorY+=1;
                }
                if(yfin == yabajo){
                    contadorY1+=1;
                }else{
                    contadorY+=1;
                }
                if(contadorY != 0){
                    No+=1;
                    //System.Console.WriteLine("No intersectadas: "+contadorY);
                }
                if (contadorY1 >= 1)
                {
                    Si+=1;
                    //System.Console.WriteLine("ABAJO intersectadas: "+contadorY1);
                }

                /*--------------------------------------------------------------------*/
                
               //System.Console.WriteLine("DIAGONAL 1");
                if(xinicio == xderecho){
                    contadorD1+=1;
                }else{
                    contadorD+=1;
                }
                if(xinicio == yabajo){
                    contadorD1+=1;
                }else
                {
                    contadorD+=1;
                }
                if (yinicio == xderecho)
                {
                    contadorD1+=1;
                }else
                {
                    contadorD+=1;
                }             
                if (yinicio == yabajo)
                {
                    contadorD1+=1;
                }else
                {
                    contadorD+=1;
                }
                if(contadorD != 0){
                    No+=1;
                    //System.Console.WriteLine("No intersectadas: "+contadorD);
                }
                if (contadorD1 >=1)
                {
                    Si+=1;
                    //System.Console.WriteLine("DIAGONAL intersectadas: "+contadorD1);
                }
                /*--------------------------------------------------------------------*/
                
                //System.Console.WriteLine("INVERSA 2");
                if(xfin == xinicio){
                    contadorI2+=1;
                }else
                {
                    contadorI+=1;
                }
                if (xfin == yinicio)
                {
                    contadorI2+=1;
                }else
                {
                    contadorI+=1;
                }
                if (yfin == xinicio)
                {
                    contadorI2+=1;
                }else
                {
                    contadorI+=1;
                }
                if(yfin == yinicio){
                    contadorI2+=1;
                }else
                {
                    contadorI+=1;
                }
                if(contadorI != 0){
                    No+=1;
                    //System.Console.WriteLine("No intersectadas: "+contadorI);
                }
                if (contadorI2 >=1)
                {
                    Si+=1;
                    //System.Console.WriteLine("INVERSAS intersectadas: "+contadorI2);
                }
                
                if(Si >=1){
                    System.Console.WriteLine("T");
                }else{
                    System.Console.WriteLine("F");
                }
            }
            archivo.Close();
            System.Console.ReadKey();
        }
    }
}
