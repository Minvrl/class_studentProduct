using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Threading;

namespace class_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Students
            string fullname;
            byte point;

            Console.Write("Ad daxil edin: ");
            bool fullnameIsValid = false; 

            do
            {
                fullname = Console.ReadLine(); 

                if (!string.IsNullOrWhiteSpace(fullname))
                {
                    fullnameIsValid = true;  
                }
                else
                {
                    Console.WriteLine("Ad bosluq olabilmez! Yeniden daxil edin - ");
                }

            } while (!fullnameIsValid);




            Console.Write("Point daxil edin: ");
            bool pointIsValid = false; 

            do
            {
                if (byte.TryParse(Console.ReadLine(), out point))
                {
                    pointIsValid = true;  
                }
                else
                {
                    Console.Write("Duzgun daxil edilmedi! - ");  
                }

            } while (!pointIsValid);

            Student newStudent = new Student(fullname, point);
           
            Console.Write("Dogum tarixi daxil edin (ay-gun-il): ");
            bool date = false;
            do
            {
                if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                {
                    newStudent.BirthDate = birthDate;
                    date = true;
                }
                else
                {
                    Console.Write("Yanlis formatda daxil edildi!Yeniden daxil edin - ");
                }
            } while (!date);

            Console.Write("Qrup nomresi daxil edin: ");
            bool group = false;
            do
            {
                if (int.TryParse(Console.ReadLine(), out int groupNo))
                {
                    newStudent.GroupNo = groupNo;
                    group = true;
                }
                else
                {
                    Console.Write("Yanlis daxil edildi! Yeniden daxil edin - ");
                    
                }
            } while (!group);

            
            newStudent.ShowInfo();

            Student student = new Student("Gunay Abbasova", 67);
            student.BirthDate = new DateTime(1995, 10, 20);
            student.GroupNo = 23;

            student.ShowInfo();
            #endregion

            #region Products
            Console.WriteLine("\n =========================================================================");
            Console.Write("Nece mehsul elave edeceksiniz? ");
            

            if (int.TryParse(Console.ReadLine(), out int numberOfProducts))
            {
                Product[] products = new Product[numberOfProducts];

                for (int i = 0; i < numberOfProducts; i++)
                {
                    string productName;
                    double productPrice;

                    do
                    {
                        Console.Write($"{i + 1}. Mehsulun adini daxil edin: ");
                        productName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(productName))
                        {
                            Console.WriteLine("Mehsul adi bos ola bilmez.Yeniden daxil edin - ");
                        }

                    } while (string.IsNullOrWhiteSpace(productName));

                    do
                    {
                        Console.Write($" > {i + 1}. Mehsulun qiymetini daxil edin: ");
                        if (!double.TryParse(Console.ReadLine(), out productPrice) || productPrice < 0)
                        {
                            Console.WriteLine("Yanlis qiymet daxil edildi. Yeniden daxil edin - ");
                        }

                    } while (productPrice < 0);

                    products[i] = new Product(productName, productPrice);
                }

                Console.WriteLine("\nMehsullar:");
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Ad: {products[i].Name}, Qiymet: {products[i].Price}");
                }

                Product HighestPrice = products[0];
                Product LowestPrice = products[0];

                for (int i = 1; i < products.Length; i++)
                {
                    if (products[i].Price > HighestPrice.Price)
                    {
                        HighestPrice = products[i];  
                    }
                    else if (products[i].Price < LowestPrice.Price)
                    {
                        LowestPrice = products[i];  
                    }
                }

                Console.WriteLine($"\nEn bahali mehsul: {HighestPrice.Name}, Qiymet: {HighestPrice.Price}");

                Console.WriteLine($"En ucuz mehsul : {LowestPrice.Name}, Qiymet: {LowestPrice.Price}");

                double sum = 0;
                int count = 0;
                for (int i = 0; i < products.Length; i++)
                {
                    sum += products[i].Price;
                    count++;
                }
                Console.WriteLine($"Qiymetlerin ededi ortasi - {(sum / count).ToString("#.##")}");

            }
            else
            {
                Console.WriteLine("Yanliz reqem daxil edile biler.");
            }

            #endregion





        }
    }
}
