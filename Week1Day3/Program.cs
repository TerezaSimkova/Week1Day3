using System;
using System.Collections.Generic;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
        {

            //routine();
            //Menu();


            //Array

            //int[] primoArray = new int[5];  //valore di default di array è zero
            //primoArray[0] = 3;
            //primoArray[1] = 10;
            //primoArray[2] = 13;
            //primoArray[3] = 55;
            //primoArray[4] = 8;

            ////cerco la possizione al base di valore con indexOf()

            ////uso ciclo for perchè so numero dei elementi
            ////array ha dimensione fissa
            //Console.WriteLine($"Stampa il mio primo array.\n");
            //for (int i = 0; i < primoArray.Length; i++)
            //{
            //    Console.Write($"{primoArray[i]}\t");
            //}

            //int[] numeri = { 1, 2, 45, 67, 70 };

            //string[] nomi = { "Renata", "Tereza", "Alessandra" };

            //List<int> listaNumeri = new List<int>();
            //listaNumeri.Add(23);
            //listaNumeri.Add(45);
            //int elementi = listaNumeri.Count;
            //Console.WriteLine($"LA lista contiene {elementi} elementi.");


            //Esercizio

            int[] secondoArray = new int[4];
            secondoArray[0] = 5;
            secondoArray[1] = 3;
            secondoArray[2] = 8;
            secondoArray[3] = 6;

            Console.WriteLine($"Indovina il numero:");
            int numero = int.Parse(Console.ReadLine());
            int result = 0;

            //for (int i = 0; i < secondoArray.Length; i++)
            //{
            //    result = numero;
            //    if (secondoArray[i] != numero)
            //    {

            //        Console.WriteLine("Hai Perso!");
            //        break;

            //    }
            //}
            for (int i = 0; i < secondoArray.Length; i++)
            {
                result = numero;
                if (secondoArray[i] == numero)
                {

                    Console.WriteLine("Hai Vinto!");
                    break;

                }
                else
                {
                  
                    if (secondoArray[i] != numero)
                    {

                        Console.WriteLine("Hai Perso!");
                        break;

                    }
                }
               
            } 
                
            


            //switch (numero)
            //{

            //    case 1:
            //        result = 5;
            //        Console.WriteLine("Hai vinto!");
            //        break;
            //    case 2:
            //        result = 3;
            //        Console.WriteLine("Hai vinto!");

            //        break;
            //    case 3:
            //        result = 8;
            //        Console.WriteLine("Hai vinto!");

            //        break;
            //    case 4:
            //        result = 6;
            //        Console.WriteLine("Hai vinto!");

            //        break;

            //    default:
            //        Console.WriteLine("Hai perso, prova di nuovo:");
            //        break;
            //}





        }


        private static void routine()
        {
            int a = 1;
            int b = 2;

            int somma = 0;
            somma = Sum(a, b);

            Console.WriteLine(somma);

            int var1 = 10;
            cambioValore(var1);
            Console.WriteLine($"Cambiato a {var1}."); //fa solo copia e modifiche non sono state riportate nella variabile

            int var2 = 20;
            cambioValorePerRif(ref var2);//nonfaccio solo copia ma voglio operare con quella variabile e la modifichi
            Console.WriteLine($"Cambiato a {var2}.");

            int n = 2;
            int m = 10;
            int sommaNM = SommaDopoIncremento(ref n, m);
            Console.WriteLine($"Lavariabile n vale: {n}");//3 perchè si rescrive con la sua modifica
            Console.WriteLine($"Lavariabile m vale: {m}");//10 questo non si rescrive
            Console.WriteLine($"Lavariabile somma vale: {sommaNM}");//14


            //out

            int x1 = 2;
            int x2 = 3;
            int prodotto; //mi preparo una variabile per il prodotto p
            int diffX1X2 = DifferenzaEProdotto(x1, x2, out prodotto); //oppure la puoi dichiarare diretamente dentro: out int prodotto, senza dichiararla prima
            Console.WriteLine($"Prodotto è {prodotto}");
            Console.WriteLine($"La differenza è {diffX1X2}");

            //Try parse

            Menu();
            Console.WriteLine($"Inserisci la tua scleta:");
            // int scelta = int.Parse(Console.ReadLine()); a volte crea dei problemi se utente inserisce altro
            //bool verificaCheSiaIntero = int.TryParse(Console.ReadLine(), out int scelta); //fa verifica e ti da vero o falso, se va bene si salva la scelta nella variabile scelta
            //Console.WriteLine($"la scelta del utente è: {scelta}"); // garantisce che utente sceglie un numero non altro

            int scelta;
            while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 1 || scelta > 3)
            {
                Console.WriteLine("Scelta errata! Riprova:");
            }
            Console.WriteLine($"la scelta del utente è: {scelta}");
        }

        // mideve restituire la differenza ma anche avere il output dei due valori passati in input.
        private static int DifferenzaEProdotto(int x, int y, out int p) //p la passi per riferimento e poi la inizializzi pure sotto
        {
            int diff = x - y;
            p = x * y;
            return diff;
        }


        //Scrivere una funz.che prende in ingresso 2 interi(il 1 per riferimento,il 2 per valore) li incrementa di 1 e restituisce la loro somma
        private static int SommaDopoIncremento(ref int x, int y)
        {
            x++;
            y++;
            return x + y;
        }

        private static void cambioValore(int x)
        {
            x = 5; //cambia valore del var1 che entra dentro int x
            Console.WriteLine($"Cambiato da 10 a {x}.");
        }

        private static void cambioValorePerRif(ref int x)
        {
            x = 5; //cambia valore del var1 che entra dentro int x
            Console.WriteLine($"Cambiato da 10 a {x}.");
        }

        // int tipo di ritorno, int a e b tipi di parametro
        private static int Sum(int x, int y)
        {
            int z = x + y;
            return z;
        }
        private static void Menu()
        {
            Console.WriteLine("menu****");
            Console.WriteLine("1. opzione 1");
            Console.WriteLine("2. opzione 2");
            Console.WriteLine("3. opzione 3");
        }

        //overloading,cambia tipo di ingresso

        private static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        private static int Sum(ref int x, int y, int z)
        {
            return x + y + z;
        }

        private static int Sum(double a, double b)//cambio tipo della firma ,oppure posso mettere double già al posto di int
        {
            return (int)(a + b); //faccio il cast al int, cambio tipo 
        }
    }
}
