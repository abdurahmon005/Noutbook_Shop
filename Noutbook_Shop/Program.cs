using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\t\t\t\t\t\t ____________________________________ ");
        Console.WriteLine("\t\t\t\t\t\t|                                    |");
        Console.WriteLine("\t\t\t\t\t\t|           NOUTBOOK SHOP            |");
        Console.WriteLine("\t\t\t\t\t\t|____________________________________|\n\n");

        Console.WriteLine(" ____________________________________         ____________________________________      ____________________________________");
        Console.WriteLine("|                                    |       |                                    |    |                                    |");
        Console.WriteLine("|     1. Mahsulotlar ro'yhati        |       |   2. Sotib olingan mahsulotlar     |    |        3. Sotib olish              |");
        Console.WriteLine("|____________________________________|       |____________________________________|    |____________________________________|");


        int[] array_id = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        double[] array_narx = { 580, 600, 780, 1150, 500, 400, 2000, 456, 785, 899 };

        string[] array_product = { "Acer Aspire 5", "HP Victus Gaming", "HP Pavilon Gaming", "Asus Rog Strix", "Lenovo Ideapad", "Lenovo Office", "Asus Predator","HP Office","Lenovo Loq", "Lenovo Yoga" };

        string[] array_korzinka = new string[10];

        Console.Write("\n Qanday amal bajarmoqchisiz(1/2/3):  ");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 1:
                Console.WriteLine("Mahsulotlar ro'yhati");
                for (int i = 0; i < array_id.Length; i++)
                {
                    Console.WriteLine($"{array_id[i]} \t {array_product[i]} \t {array_narx[i]}");

                }
                break;

            case 2:
                Console.WriteLine("Sotib Olingan mahsulotlar royhati:");
                bool bor = false;

                 for(int i=0;i<array_korzinka.Length;i++)
                {
                    if (!String.IsNullOrEmpty(array_korzinka[i]))
                    {
                        Console.WriteLine($">>> {array_korzinka[i]}");
                        bor = true;
                    }
                }
                if (!bor)
                {
                    Console.Write("Savat bosh!!!");
                }
                break;

            case 3:
                Console.WriteLine("mahsulotlar ro'yhati");
                for (int i = 0; i < array_id.Length; i++)
                {
                    Console.WriteLine($"{array_id[i]} \t {array_product[i]} \t {array_narx[i]}");

                }
                break ;

            default:  Console.WriteLine("");

        break;


         }
    }
}


 
