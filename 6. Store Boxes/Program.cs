using System;
using System.Linq;
using System.Collections.Generic;
namespace _6._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Box> boxList = new List<Box>();
            List<Item> itemList = new List<Item>();
            while (command[0] != "end")
            {
                Box newBox = new Box();
                Item newItem = new Item();
                newBox.SerialNumber = command[0];
                newItem.Name = command[1];
                newBox.ItemQuantity = double.Parse(command[2]);
                newItem.Price = double.Parse(command[3]);

                newBox.PricePerBox = newItem.Price * newBox.ItemQuantity;
                newBox.item = newItem;
                boxList.Add(newBox);
                itemList.Add(newItem);

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            List<Box> orderedList = boxList.OrderByDescending(x => x.PricePerBox).ToList();

            foreach (Box box in orderedList)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.item.Name} - ${box.item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }

        }
    }
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }


    }
    public class Box
    {
        public string SerialNumber { get; set; }
        public Item item { get; set; }
        public double ItemQuantity { get; set; }
        public double PricePerBox { get; set; }


    }
   
}
