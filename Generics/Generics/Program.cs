using System.Collections.Generic;
using System;
using System.Linq;
namespace Generics
{
    class Program
    {
        //------------------------------------------------------------------------------------------

        /*static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            numbers.Add(50);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(10);
            numbers.Add(20);

            Console.WriteLine(numbers.Count); //сколько штук?

            for (int i = 0; i < numbers.Count; i++)  
            {
                Console.WriteLine(numbers[i]); //перечисление
            }
                
            //еще несколько значений, проверка что массив расширяемый
            numbers.Add(80);
            numbers.Add(90);
            numbers.Add(60);
            numbers.Add(70);

            Console.WriteLine(numbers.Count); //сколько стало штук?

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]); //перечисление 
               
            }

            numbers.Sort();

            Console.WriteLine(numbers.Count); 

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);  //сортировка ASC(дефолт)

            }

            numbers.Reverse();

            Console.WriteLine(numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);  //сортировка DESC

            }
        }*/

        //----------------------------------------------------------------------------------------

        /*static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Igor");
            names.Add("Marina");
            names.Add("Alexander");
            names.Add("Vasilii");
            names.Add("Irina");
            names.Add("Vladislav");
            names.Add("Nikolai");
            names.Add("Elena");

            names.Sort();  //по дефолту ASC сортировка

            foreach (var name in names) 
            {
                Console.WriteLine(name);
            }

            names.Sort((x, y) => x.Length.CompareTo(y.Length));  //по количеству букв(если меняем местами x и y то в обратном)
            foreach (var name in names)                            
            {
                Console.WriteLine(name);
            }
            
               
        }*/
        
        //--------------------------------------------------------------------------------------------------------------------------------
        
        /*static void Main(string[] args)
        {
            Dictionary<int, string> Months = new Dictionary<int, string>();
            {
                Months.Add(1, "January"); //подходит для добавления новых значений, при попытке заменить ошибка
                Months.Add(2, "February");
                Months.Add(3, "March");
                Months.Add(4, "April");
                Months.Add(5, "May");
                Months.Add(6, "June");

                Months[5] = "May"; //если значение уже есть, заменяет его

                Months[7] = "July"; 
                Months[8] = "August";
                Months[9] = "September";
                Months[10] = "October";
                Months[11] = "November";
                Months[12] = "December";

                Console.WriteLine("Press Any Key To view Dictionary");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("My Dictionary");

                foreach (KeyValuePair<int, string> month in Months) 
                {
                    Console.WriteLine("key " + month.Key + " value " + month.Value); //вывод словаря
                }

                Console.WriteLine("Press Any Key To sort by value ASC");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("My Dictionary sorted by value ASC");

                foreach (var item in Months.OrderBy(x => x.Value)) //сортировка по Value ASC   работает если добавить using System.Linq;
                {
                    Console.WriteLine("key " + item);
                }

                Console.WriteLine("Press Any Key To sort by value DESC");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("My Dictionary sorted by value DESC");

                foreach (var item in Months.OrderByDescending(x => x.Value)) //сортировка по Value DESC
                {
                    Console.WriteLine("key " + item);
                }

                Console.WriteLine("Press Any Key To sort by KEY DESC");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("My Dictionary sorted by value KEY");

                foreach (var item in Months.OrderByDescending(x => x.Key)) //сортировка по Key DESC
                {
                    Console.WriteLine("key " + item);
                }

                Console.WriteLine("Press Any Key To now how many pairs have my Dictionary");
                Console.ReadKey();
                Console.WriteLine("-----------------------------------------------------------------");
                
                Console.WriteLine("Total key/value pairs in myDict are : " + Months.Count);
                Console.Write("Enter KEY to delete from Dictionary: ");
                int position = Convert.ToInt32(Console.ReadLine());

                Months.Remove(position); //удаление по ключу

                foreach (KeyValuePair<int, string> month in Months)
                {
                    Console.WriteLine("key " + month.Key + " value " + month.Value); //вывод словаря
                }
                
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("Total key/value pairs in myDict after delleting are : " + Months.Count);

                Console.WriteLine("Enter VALUE to delete from Dictionary: ");
                
                string userMonth = Console.ReadLine();
                var monthToDelete = Months.First(m => m.Value == userMonth);
                Months.Remove(monthToDelete.Key);
                
                foreach (KeyValuePair<int, string> month in Months)
                {
                    Console.WriteLine("key " + month.Key + " value " + month.Value); //вывод словаря
                }

                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("Total key/value pairs in myDict after delleting are : " + Months.Count);





            };
                    
         
        }*/

    }
}
