using System;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].Number);
            }
        }

        static IInventory[] list =
        {
            new Building(),
            new Building(),
            new Building(),
            new Device(),
            new Device(),
            new Device(),
            new Device(),
            new Computer(),
            new Computer(),
            new Computer(),
            new Computer(),
            new Book(),
            new Book(),
            new Book(),
        };
    }

    interface IInventory
    {
        public string Number { get; }
    }

    static class InventoryHelper
    {
        private static uint Id { get; set; } = 0;

        public static string GetNumber(uint type, uint serialNumber, uint date)
        {
            if (type > 99 || serialNumber > 9999 || date > 99)
                throw new Exception("Неверные данные для инвентарного номера");

            return type.ToString("00") + "-" + serialNumber.ToString("0000") + "-" +
                date.ToString("00") + "-" + Id++.ToString("0000");
        }
    }

    class Building : IInventory
    {
        public string Number { get; }
        public string Address { get; set; }
        private uint type = 1;
        private static uint count = 1;
        Random random = new Random();

        public Building()
        {
            Number = InventoryHelper.GetNumber(type, count++, (uint)random.Next(0, 100));
        }
    }

    class Device : IInventory
    {
        public string Number { get; }
        private uint type = 3;
        private static uint count = 1;
        Random random = new Random();

        public Device()
        {
            Number = InventoryHelper.GetNumber(type, count++, (uint)random.Next(0, 100));
        }
    }

    class Computer : Device
    {
        public class CPU
        {

        }

        public CPU Cpu { get; set; }
        public uint HardDiskSpace { get; set; }
        public uint RAMSize { get; set; }

        public Computer()
        {

        }
    }

    class Book : IInventory
    {
        public string Number { get; }
        private uint type = 13;
        private static uint count = 1;
        Random random = new Random();
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime YearOfPublishing { get; set; }

        public Book()
        {
            Number = InventoryHelper.GetNumber(type, count++, (uint)random.Next(0, 100));
        }
    }
}
