using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    public class ProductTest
    {
        static void Main(string[] args)
        {

            ProductMock P = new ProductMock();

            do
            {
                try
                {
                    Console.Write("Enter Product ID :");
                    P.ProductID = Convert.ToInt32(Console.ReadLine());
                    if (P.ProductID < 0)
                        throw new DataEntryException("Product ID must be greater than Zero");

                    Console.Write("Enter Product Name :");
                    P.ProductName = Console.ReadLine();
                    if (P.ProductName == string.Empty)
                        throw new DataEntryException("Product Name cannot be left blank");

                    Console.Write("Enter Price :");
                    P.ProductPrice = Convert.ToDouble(Console.ReadLine());
                    if (P.ProductPrice < 0)
                        throw new DataEntryException("Price of product must be greater than Zero");


                    Console.WriteLine("Product Details :");
                    Console.WriteLine("Product ID :" + P.ProductID);
                    Console.WriteLine("Product Name :" + P.ProductName);
                    Console.WriteLine("Product Price :" + P.ProductPrice);
                }
                catch (DataEntryException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (SystemException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();

            } while (true);

           
        }

    }

}

