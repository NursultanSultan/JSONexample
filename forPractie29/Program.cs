using System;
using System.Collections.Generic;
using System.IO;
using forPractie29.Models;
using Newtonsoft.Json;

namespace forPractie29
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product { ID = 1, Name = "HP", Price = 1500 };
            Product product2 = new Product { ID = 2, Name = "Acer", Price = 1300 };

            OrderItem item1 = new OrderItem() { ID = 1, product = product1, Count = 3, totalPrice = product1.Price * 3 };
            OrderItem item2 = new OrderItem() { ID = 2, product = product2, Count = 2, totalPrice = product2.Price * 2 };

            List<OrderItem> items = new List<OrderItem>();
            items.Add(item1);
            items.Add(item2);

            Order order = new Order { ID = 1, Items = items};

            #region serialized
            var jsonObject = JsonConvert.SerializeObject(order);
            

            //string path = @"C:\Users\Home\Desktop\test\forPractie29\forPractie29\Files\json1.json";

            //using (StreamWriter sw = new StreamWriter(path))
            //{
            //    sw.Write(jsonObject);
            //}

            #endregion

            #region deserialized

            var dejsonObject = JsonConvert.DeserializeObject<Order>(jsonObject);
            //Console.WriteLine(dejsonObject.Items[0].product.Name);

            #endregion




        }

    }
       
}
