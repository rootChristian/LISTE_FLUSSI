/***********************************************************************
************ Author:    Christian KEMGANG NGUESSOP *********************
********* Description: Create function with parameters: List and to Sum
 and return two lists when the summer equals valor sum in input  *******
***********************************************************************/


using System;
using System.Collections.Generic;

namespace lISTE_FLUSSI
{
    class Program
    {
        static void Main(string[] args)
        {
            const double subTotale1 = 371.02;
            const double subTotale2 = 7728.59;
            List<double> importi = new List<double> { 108.97, 222.93, 90.63, 22.39, 532.63, 129.13, 233.74, 120.32, 3047.62, 111.1, 
                                                      187.82, 261.49, 226.2, 1915.78, 148.1, 140.29, 108.05, 121.4, 257.44, 66, 47.58};

            //Console.WriteLine("\nRisultato delle due liste\n");
            ListeDettagliateSuddividi(subTotale1, subTotale2, importi);

            Console.WriteLine("\nPress any board to quit!\n");

            /*
            Console.WriteLine("\n\nPrima lista\n");

            ListeDettagliate(subTotale1, importi);

            Console.WriteLine("\n\nSeconda lista\n");

            ListeDettagliate(subTotale2, importi);
            */
        }
        
        private static System.Collections.IList ListeDettagliateSuddividi(double subTot1, double subTot2, List<double> dati)
        {
            //List of the list
            List<List<double>> Liste = new List<List<double>>();

            List<double> L1 = new List<double> { };
            List<double> L2 = new List<double> { };

            for (int i = 0; i < dati.Count; i++)
            {
                double sum = 0, sum2 = 0;

                for (int j = i; j < dati.Count; j++)
                {
                    sum += dati[j];
                    sum = Math.Round(sum, 2);

                    sum2 += dati[j];
                    sum2 = Math.Round(sum2, 2);

                    if (sum == subTot1)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            L1.Add(dati[k]);
                        }
                        break;
                    }

                    if (sum == subTot2)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            L2.Add(dati[k]);
                        }
                        break;
                    }
                }
            }

            //List L1 and L2 inside Liste  
            Liste.Add(L1);
            Liste.Add(L2);
            /*
            //Stamp the result
            int a = 0, b = 0;
            foreach (var L in Liste)
            {
                a += 1;
                Console.WriteLine("************************");
                Console.WriteLine("L{0} : ", a);

                foreach (var item in L)
                {
                    b += 1;
                    Console.WriteLine("Importo {0}: {1}", b, item);
                }

                b = 0;

                Console.WriteLine("\n");
            }*/

            return Liste;
            
        }

        /*
        private static void ListeDettagliate(double subTot1, List<double> dati)
        {
            List<double> L = new List<double> { };

            for (int i = 0; i < dati.Count; i++)
            {
                double sum = 0;

                for (int j = i; j < dati.Count; j++)
                {
                    sum += dati[j];
                    sum = Math.Round(sum, 2);

                    if (sum == subTot1)
                    {
                        for (int k = i; k <= j; k++)
                        {
                            L.Add(dati[k]);
                        }
                        break;
                    }
                }
            }

            double result = 0;
            foreach (var item in L)
            {
                result += item;
                result = Math.Round(result, 2);
                Console.WriteLine("Importo : {0}", item);
            }
            Console.WriteLine("\nImporto totale nella lista : {0}", result);
        }
        */

        /*
        // Function to list details
        private static void ListeDettagliate(double subTot1, double subTot2, List<double> dati)
        {
            //List of the list
            List<List<double>> Liste = new List<List<double>>();

            List<double> L1 = new List<double> { };
            List<double> L2 = new List<double> { };
            //List<double> appoggio1 = new List<double> { };
            //List<double> appoggio2 = new List<double> { };

            //Insert in the list element not above the subTotal
            foreach (var val in dati)
            {
                if (val <= subTot1)
                {
                    L1.Add(val);
                    for (int i1 = 0; i1 < L1.Count; i1++)
                    {
                        double totale = 0;

                        for (int i2 = i1; i2 < L1.Count; i2++)
                        {
                            totale += L1[i2];
                            totale = Math.Round(totale, 2);
                            
                            if (totale == subTot1)
                            {
                                L1.Clear();
                                L1.Add(i2);
                                Console.WriteLine("Total import L1: {0}", totale);
                                //Console.WriteLine("Index import L1: {0}", i1);
                                break;
                            }
                        }
                    }
                }

                if (val <= subTot2)
                {
                    L2.Add(val);
                    for (int j1 = 0; j1 < L2.Count; j1++)
                    {
                        double totale2 = 0;

                        for (int j2 = j1; j2 < L2.Count; j2++)
                        {
                            totale2 += L2[j2];
                            totale2 = Math.Round(totale2, 2);

                            if (totale2 == subTot2)
                            {
                                L2.Clear();
                                L2.Add(j2);
                                Console.WriteLine("Total import L2: {0}", totale2);
                                //Console.WriteLine("Index import L2: {0}", j1);
                                break;
                            }
                        }
                    }
                }
            }

            //List L1 and L2 inside Liste  
            Liste.Add(L1);
            Liste.Add(L2);

            int i = 0, j = 0;

            //Stamp the result
            foreach (var L in Liste)
            {
                i += 1;
                Console.WriteLine("************************");
                Console.WriteLine("L{0} : ", i);

                foreach (var item in L)
                {
                    j += 1;
                    Console.WriteLine("Importo {0}: {1}", j, item);
                }

                j = 0;

                Console.WriteLine("\n");
            }
        }*/
    }
}
