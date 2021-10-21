using System;
// ajoute a la valeur max ton resultat
namespace boucle_iteration_csharp
{
    class Program
    {

        public static void exo1()
         {
            Console.WriteLine("Calcul de la somme de 1 + ...+ N \nDonnez votre nombre N :");
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            int add = 0;
            Console.WriteLine("La somme de 1 + ...+{0} =", n);

            while (n > 0)
            {
                n--;
                add += count;
                count++;
            }
            Console.WriteLine(add);
        }
        public static void exo2()
        {
            Console.WriteLine("Cadrage dans un intervalle");
            int number;
            int count = 0;

            while (1 == 1)
            {
                Console.WriteLine("Donnez votre nombre entre 10 et 20 :");
                number = int.Parse(Console.ReadLine());
                count++;
                if (number >= 10 && number <= 20)
                    break;
                else if (number < 10)
                    Console.WriteLine("Votre nombre doit être plus grand");
                else
                    Console.WriteLine("Votre nombre doit être plus petit");
            }
            Console.WriteLine("Votre nombre {0} respecte l'intervalle après {1} coups.", number, count);


        }
        public static void exo3()
        {
            int val = new Random().Next(0,10);

            int count = 1;
            while (count < 10)
            {
                int number = int.Parse(Console.ReadLine());
                if  ( number < val)
                {
                    Console.WriteLine("{0} est trop petit", number);
                }
                else if (number > val)
                {
                    Console.WriteLine("{0} est trop grand", number);
                }
                
                else
                {
                    Console.WriteLine("{0} est correct ", number);
                    break;
                }
                count++;
            }

           

        }
        public static void exo4()
        {

            Console.WriteLine("PGCD Méthode d'Euclide\n");
            int first_number = int.Parse(Console.ReadLine());
            int second_number = int.Parse(Console.ReadLine());
            int r = 1;
            int t;
            int pgcd_E;
            Console.WriteLine("Le PGCD de {0} et {1} est :", first_number, second_number);

            if (first_number < second_number)
            {
                t = first_number;
                first_number = second_number;
                second_number = t;
            }
            while (r != 0)
            {
                r = first_number % second_number;
                first_number = second_number;
                second_number = r;
            }
            pgcd_E = first_number;
            Console.WriteLine(pgcd_E);

        }
        [09:08]



    }
    public static void exo5()
        {

        }
        public static void exo6()
        {

        }
        static void Main(string[] args)
        {
            exo1();
            //exo2();
            //exo3();
            //exo4();
            //exo5();
            //exo6();
         }
    }
}
