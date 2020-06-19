using System;

namespace Examen2019opcional
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[,] matriz;

            matriz = new int[10, 10];



            for(int fila = 0; fila <10; fila++)
            {

                for (int columna = 0; columna <10; columna++)
                {

                    matriz[fila, columna] = 0;
                    


                }


            }
            

            Persona persona = new Persona();
       
            //Portaaviones 
            Console.WriteLine("Escriba la fila del centro donde quiere ubicar su Portaaviones");
            int Portaavionesf = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la columna del centro donde quiere ubicar su Portaaviones");
            int Portaavionesv = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la orientacion del Portaaviones 1-Horizontal 2-Vertical");
            int HVPortaaviones = Convert.ToInt16(Console.ReadLine());
            //Fragata
            Console.WriteLine("Escriba la fila del centro donde quiere ubicar su Fragata");
            int Fragataf = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la columna del centro donde quiere ubicar su Fragata");
            int Fragatav = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la orientacion de la fragata 1-Horizontal 2-Vertical");
            int HVFragata = Convert.ToInt16(Console.ReadLine());
            //Submarino
            Console.WriteLine("Escriba la fila del centro donde quiere ubicar su Submarino");
            int Submarinof = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la columna del centro donde quiere ubicar su Submarino");
            int Submarinov = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la orientacion del submarino 1-Horizontal 2-Vertical");
            int HVSubmarino = Convert.ToInt16(Console.ReadLine());
            //Reparador
            Console.WriteLine("Escriba la fila del centro donde quiere ubicar su Reparador");
            int Reparadorf = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la columna del centro donde quiere ubicar su Reparador");
            int Reparadorv = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la orientacion del submarino 1-Horizontal 2-Vertical");
            int HVreparador = Convert.ToInt16(Console.ReadLine());
            // Radar
            Console.WriteLine("Escriba la fila del centro donde quiere ubicar su Radar");
            int Radarf = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la columna del centro donde quiere ubicar su Radar");
            int Radarv = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Escriba la orientacion del submarino 1-Horizontal 2-Vertical");
            int HVradar = Convert.ToInt16(Console.ReadLine());








        }


    }



}

        
    

