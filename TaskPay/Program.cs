using System;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace TaskPay
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = "";
            Pay.flag = true;

            Pay bill = new Pay(5, 3, 2, 1);
            serial(Pay.flag, bill,ref json);

            Pay bill2 = new Pay();
            deSerial(ref json, bill2);

            WriteLine(bill2.dayCount);


        }

        public static void writeToFile(string x)
        {
            using (FileStream fstream = new FileStream($"class.json", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(x);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
            }
        }
        public static void serial(bool flag, Pay pay, ref string json)
        {
            if (flag)
            {
                json = JsonSerializer.Serialize(pay);
                writeToFile(json);
                WriteLine("Объект сериализован и записан в фаил");
            }
            else
            {
                WriteLine("Объект не нужно сериализовать");
            }
        }

        public static void deSerial(ref string json, Pay pay)
        {
           pay = JsonSerializer.Deserialize<Pay>(json);
            WriteLine("Объект десиарилизован и создан объект bill2");
        }
    }
}
