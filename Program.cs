using System;

namespace obrabotka_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            string[] str_arr;
          
            Console.Write("введите текст ");
            line = Console.ReadLine();
            str_arr = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);



            Console.WriteLine("Без пустых строк ");
            foreach (string i in str_arr)
                Console.WriteLine(i);
            
           
           
            for (int i = 0; i <= str_arr.Length - 2; i++)
                for (int j = i + 1; j <= str_arr.Length - 1; j++)
                    if (String.Compare(str_arr[i], str_arr[j]) > 0)
                    {
                        string tmp;
                        tmp = str_arr[i];
                        str_arr[i] = str_arr[j];
                        str_arr[j] = tmp;

                    }

            Console.WriteLine("После сортировки ");
            for (int i = 0; i <= str_arr.Length - 1; i++)
                Console.WriteLine(str_arr[i]);
            Console.ReadKey(false);

            string sub_str;
            Console.WriteLine("Введите подстроку для поиска ");
            sub_str = Console.ReadLine();
            int ind;
            foreach (string i in str_arr)
            {
                ind = i.IndexOf(sub_str);
                if (ind != -1)
                    Console.WriteLine(i);

            }

         
            Console.WriteLine("Введите подстроку для удаления ");
            sub_str = Console.ReadLine();
            foreach (string i in str_arr)
            {
                string j = i;
                ind = j.IndexOf(sub_str);
                if (ind != -1)
                    j = j.Remove(0, j.Length);
                Console.WriteLine(j);
            }
            Console.ReadKey(false);
        }
    }
}
