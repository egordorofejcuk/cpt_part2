using OCP;
using System;

namespace OCP
{
    public class Programm
    {
        static void Main(string[] args)
        {
            double price = 10000;
            double percent = 50;
            double diduction = 3000;
            Discount percentageDiscount = new PercentageDiscount(percent);
            Discount fixedAmountDiscount = new FixedAmountDiscount(diduction);
            double newPrice1 = percentageDiscount.CalculateDiscount(price);
            double newPrice2 = fixedAmountDiscount.CalculateDiscount(price);
            Console.WriteLine($"Цена после скидки через проценты: {newPrice1} \nЦена после скидки черех фиксированное число: {newPrice2}");

        }
    }
}