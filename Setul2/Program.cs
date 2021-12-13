using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2
{
    class Program
    {
        static void Main(string[] args)
        {

            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();???
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();?
            //P15();
            //P16();
            P17();
        }

        /// <summary>
        /// Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. 
        /// De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 
        /// </summary>
        private static void P17()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            int deschis = 0;
            int incuibare = 0;
            int a = 0;

            Console.Write("Introduceti  numerele :");
            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if (b == 0)
                {
                    deschis = deschis + 1;
                }
                else
                {
                    deschis = deschis - 1;
                }
                Console.WriteLine("Incuibare = "  + a);

                if (deschis >= 1)
                {
                    incuibare = incuibare + 1;
                    if (incuibare > a)
                    {
                        a = incuibare;
                        incuibare = 0;
                    }
                }
                else
                {
                    incuibare = 0;
                }

                if(deschis < 0)
                {
                    i = n;
                }

            }

            if (deschis != 0)
            {
                Console.Write("Secventa incorecta !! ");
            }
            else
            {
                Console.Write("Secventa corecta si nivel maxim de incuibare : {0} ." ,a);
            }
        }

        /// <summary>
        /// O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). 
        /// Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
        /// </summary>
        private static void P16()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Primul numar din secventa este : ");
            int a = int.Parse(Console.ReadLine());

            int c = a;

            bool var = true;

            Console.Write("Introduceti restul numerelor :");
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if (var)
                {
                    if (b >= a)
                    {
                        a = b;
                    }
                    else
                    {
                        var = false;
                        a = b;
                    }
                }
                else
                {
                    if (a >= b)
                    {
                        a = b;
                    }
               }

                if(i == n - 1)
                {
                    if(c<b)
                    {
                        var = true;
                    }
                }
            }

            if (var)
                Console.Write("Secventa bitonica rotita !! ");
            else
                Console.Write("Secventa nu este bitonica rotita !! "); 
        }

        /// <summary>
        /// O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. 
        /// De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica.
        /// </summary>
        private static void P15()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Primul numar din secventa este : ");
            int a = int.Parse(Console.ReadLine());



            bool var = true;
            bool var2 = false;

            Console.Write("Introduceti restul numerelor :");
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if (var)
                {
                    if (b >= a)
                    {
                        a = b;
                    }
                    else
                    {
                        var = false;
                        a = b;
                    }
                }
                else
                {
                    if (a >= b)
                    {
                        a = b;
                    }
                    else
                    {
                        var2 = true;
                    }
                }
            }

            if(var2)
                 Console.Write("Secventa bitonica !! ");
            else
                Console.Write("Secventa nu este bitonica !! ");


        }


        /// <summary>
        /// O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona 
        /// prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
        /// </summary>
        private static void P14()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Primul numar din secventa este : ");
            int a = int.Parse(Console.ReadLine());

            int c = a;

            bool var = true;
            bool var2 = false;

            Console.Write("Introduceti restul numerelor :");
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if (b > a)
                {
                    a = b;
                }
                else
                {
                   var = false;
                }

                if (i == n - 1)
                {
                    if (c > b)
                        var2 = true;
                    else
                        var = true;
                }                             
            }
            if (var)
                Console.Write("Secventa monoton descrescatoare rotita !!");
            if (var2)
                Console.Write("Secventa monoton crescatoare rotita !!");
            if(!var && var2)
                Console.Write("Nu este secventa monotona rotita !!");

        }

            /// <summary>
            /// O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive
            /// (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
            /// </summary>

            private static void P13()
            {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Primul numar din secventa este : ");
            int a = int.Parse(Console.ReadLine());

            int c = 0;
            bool var = true;
            bool var2 = false;

            Console.Write("Introduceti restul numerelor :");
            for (int i = 1; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if(b>a)
                {
                    a = b;
                }
                else
                {
                    c = a;
                    var = false;
                }

                if(i == n-1)
                {
                    if (c > b)
                        var2 = true;
                }
                
            }
            if (var)
                Console.Write("Numerele introduse sunt in ordine crescatoare =>Secventa crescatoare rotita .");
            if (var2)
                Console.Write("Secventa crescatoare rotita !!");
            else
                Console.Write("Nu este secventa crescatoare rotita !!");




            }


        /// <summary>
        /// Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant,
        /// zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
        /// </summary>
        private static void P12()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Primul numar din secventa este : ");
            int a = int.Parse(Console.ReadLine());

            bool var= false;
            int aux = 0 ;

            Console.Write("Introduceti restul numerelor :");
            for(int i = 1; i <n;i++)
            {
                int c = int.Parse(Console.ReadLine());

                if (a == 0)
                {
                    n = a;
                    continue;
                    
                }
                if(a == 0)
                {
                    c = a;
                    var = false;
                    continue;
                }
                if(a == c +1)
                {
                    if(var)
                    {
                        c = a;
                        continue;
                    }
                    aux++;
                    var = true;

                }
                else 
                {
                    var = false;
                }

                c = a;
            }
            Console.Write("Sunt {0} grupuri de numere consecutive diferite de zero .", aux);
        }


        /// <summary>
        /// Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
        /// </summary>
        private static void P11()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a > 10)
                {
                    int aux = 0;
                    while (a!=0)
                    {
                        int b = a % 10;
                        aux = aux * 10 + b;
                        a = a / 10;
                    }
                    sum = sum + aux;
                }
                else
                {
                    sum = sum + a;
                }
                
            }
            Console.Write("Suma inverselor acestor numere este : {0} .", sum);
        }


        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
        /// </summary>
        private static void P10()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            int aux = 0;
            int nr = 1;
           
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a == aux)
                {
                    nr++;                    
                }

                aux = a;
            }

            Console.Write("Numarul maxim de numere consecutive egale din secventa este : {0} .", nr);
        }


        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare
        /// </summary>
        private static void P9()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            int aux = 0;
            int a = 0;
            int i = 0;
            

            while (i < n && aux <2 )
            {
                int b = int.Parse(Console.ReadLine());

                if (b > a)
                {
                    if (aux < 0)
                    {
                        aux = 2;
                    }
                    else
                    {
                        aux = 1;
                    }
                }
                else
                {
                    if (b < a)
                    {
                        if (aux > 0)
                        {
                            aux = 2;
                        }
                        else
                        {
                            aux = -1;
                        }
                    }
                }
                a = b;
                i++;
            }
                    
         
            switch(aux)
            {
                case 0:
                    Console.Write("Secventa data este constanta.");
                    break;
                case 1:
                    Console.Write("Secventa data este monoton crescatoare.");
                    break;
                case 2:
                    Console.Write("Secventa data nu este monotona.");
                    break;
                case -1:
                    Console.Write("Secventa data este monoton descrescatoare.");
                    break;

            }
        }

        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>

        private static void P8()
        {
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());

            int f1 = 0;
            int f2 = 1;
            int f3 = 0;
            
            for(int i = 3;i<=n;i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            Console.Write("Al {0} numar din sirul lui Fibonacci este : {1} . ", n, f3);

        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
        /// </summary>

        private static void P7()
        {
            Console.Write("Introduceti n =");
            int n = int.Parse(Console.ReadLine());

            int max = 0;
            int min = n;
            
           
            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if (b < min)
                    min = b;

                if (b > max)
                    max = b;
                
                                 
            }

            Console.Write("Cel mai mare numar este {0} si cel mai mic este {1} . ", max, min);
        }


        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare
        /// </summary>

        private static void P6()
        {
            Console.Write("Introduceti n =");
            int n = int.Parse(Console.ReadLine());

            int aux = 0;
            int i = 0;
            int p = 0;

            for (i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if (b > aux)
                {
                    aux = b;
                }
                else
                {
                    p = 1;
                    i = n + 1;
                    Console.Write("Numerele din secventa nu sunt in ordine crescatoare ! ");
                }
            }
            if (p == 0)
                Console.Write("Numerele din secventa sunt in ordine crescatoare ! ");
            
        }

        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
        /// </summary>
            private static void P5()
        {
            Console.Write("Introduceti n =");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());

                if (i == b)
                    count++;
            }

            Console.Write("{0} numere sunt egale cu pozitia pe care apar n secventa .",count);
        }

            /// <summary>
            /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
            /// Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
            /// </summary>

            private static void P4()
        {
            Console.Write("Introduceti n =");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti a =");
            int a = int.Parse(Console.ReadLine());

            bool adv = true;

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());


                if (a == b)
                {
                    Console.WriteLine("Numarul se afla pe pozitia {0} .", i);
                    adv = false;
                }
                
            }
            if(adv)
            Console.Write("Numarul se afla pe pozitia -1 .");
        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n.
        /// </summary>

        private static void P3()
        {
            Console.Write("Introduceti n =");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int produs = 1;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
                produs = produs * i;
            }

            Console.Write("Suma este {0} si produsul este {1} .", sum, produs);
        }



        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>

        private static void P2()
        {
            Console.Write("Introduceti n =");
            int n = int.Parse(Console.ReadLine());

            int aux = 0 ;
            int aux2 = 0;
            int aux3  = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a > 0)
                    aux++;
                if (a < 0)
                    aux2++;
                if (a == 0)
                    aux3++;
                    
            }

            Console.Write("In secventa data sunt {0} numere pozitive , {1} numere negative si {2} numere egale cu  0  ", aux, aux2, aux3);
        }


        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
        /// </summary>
        /// 

        private static void P1()
            {
                Console.Write("Introduceti n =");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    int a = int.Parse(Console.ReadLine());

                    if (a % 2 == 0)
                        Console.WriteLine("{0} este par ", a);
                    else
                        Console.WriteLine("{0} nu este par ", a);
                }
            }
        }
    }
    

