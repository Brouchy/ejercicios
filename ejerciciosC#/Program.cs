using System;
using System.Collections.Generic;

namespace ejerciciosC_
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("ingrese 1 para el ejercicio 1");
            Console.WriteLine("ingrese 2 ´para el ejercicio 2");
            Console.WriteLine("ingrese 3 ´para el ejercicio 4");
            Console.Write("el ejercicio elejido es: ");
            int numeroDeEje = int.Parse(Console.ReadLine());
            switch (numeroDeEje)
            {
                case 1:
                    Console.WriteLine("ejercicio 1");
                    Ejercicio1();
                    break;
                case 2:
                    Console.WriteLine("ejercicio 2");
                    ejercicio3();
                    break;
                case 3:
                    Console.WriteLine("ejercicio 4");
                    Console.Write("ingrese cadena: ");
                    string cadena = Console.ReadLine().ToUpper();
                    Console.Write("ingrese desplazamiento: ");
                    int desplazamieneto = int.Parse(Console.ReadLine());
                    Ejercicio4(cadena, desplazamieneto);
                    break;

                default:
                    break;
            }

        }

        static void Ejercicio1()
        {

            try
            {
                List<int> ListaDeNumeros = new List<int>();
                for (int i = 0; i <= 2; i++)
                {
                    Console.Write("ingrese un numero: ");

                    int numero = int.Parse(Console.ReadLine());
                    ListaDeNumeros.Add(numero);
                }
                ListaDeNumeros.Sort();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("el numero menor es; " + ListaDeNumeros[0]);
                Console.WriteLine("el numero  del medio: " + ListaDeNumeros[1]);
                Console.WriteLine("el numero meyor es: " + ListaDeNumeros[2]);

            }
            catch(FormatException)
            {
                Console.Clear();
                Console.WriteLine("debe ingresar un numero");
                Ejercicio1();
            }
        }

        static void ejercicio3()
        {
            string salirDelBucle = "";
            int pares = 0;
            int contadorPares = 0;
            int contadorInpares = 0;
            int inpares = 0;

            do
            {
             try
            {
                    Console.Write("ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());
                    if (numero % 2 == 0)
                    {
                        pares += numero;
                        contadorPares++;
                    }
                        
                    else
                    {
                        inpares += numero;
                        contadorInpares++;
                    }   
                    
            }
            catch(FormatException)
            {
                salirDelBucle = "a";
            }
               

            } while (salirDelBucle != "a");
            Console.WriteLine("suma de numeros pares: " + pares);
            Console.WriteLine("suma de numeros impares: " + inpares);
            Console.WriteLine("contador pares: " + contadorPares);
            Console.WriteLine("contador inpares: " + contadorInpares);
            Console.WriteLine("");
            Console.WriteLine("");
            int promedioPares = pares / contadorPares;
            int promedioImpares = inpares / contadorInpares;
            if (promedioPares > promedioImpares)
            {
                Console.WriteLine("el promedio de numeros pares es mayor: " + promedioPares);
                Console.WriteLine("el promedio de numero impares es menor: " + promedioImpares);
            }
            else
            {
                Console.WriteLine("el promedio de numeros impares es mayor: " + promedioImpares);
                Console.WriteLine("el promedio de numero pares es menor: " + promedioPares);
            }
        }


        static void Ejercicio4(string palabra , int desp)
        {
            Console.Write("La palabra sifrada es: ");
            char[] sifrado = new char[palabra.Length];

            for(int i =0;i<palabra.Length;i++)
            {
                int letra = (int)palabra[i];

                if (letra>= 65 &&letra<= 90)
                {
                    int suma = letra + desp;
                    if(suma>90)
                    {
                        int resto = suma - 90+65;
                        sifrado[i] = (char)resto;
                    }
                    else { sifrado[i] = (char)suma; }
                }else { sifrado[i] = palabra[i]; }
                Console.Write(sifrado[i]);
            }


            

        }
    }
}

