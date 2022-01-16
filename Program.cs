using System;

/*
Money Maker: a program in which a user enters an amount and gets the minimum number of coins that equal that value.
A bronze coin is worth 1 cent
A silver coin is worth 5 cents
A gold coin is worth 10 cents 

--

For example, 16 cents could be:
16 bronze coins,
3 silver coins and 1 bronze coin, or
1 gold coin, 1 silver coin, 1 bronze coin
*/


namespace Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!\nValue of three coins are:\nGold - 10\nSilver - 5\nBronze 3");
            Console.WriteLine("  ");

            // Capture the amoint from user
            Console.WriteLine("Enter the amount to convert: ");
            string amountString = Console.ReadLine();
            double amountDouble = Math.Floor(Convert.ToDouble(amountString));


            Console.WriteLine($"{amountString} cents is equal to...");

            // defining values of coins
            int goldCoinValue = 10;
            int silverCoinValue = 5;

            // find the maximum number of gold coins that “fit” into the amount and remainder
            double goldCoins = Math.Floor(amountDouble / goldCoinValue);
            double remainingFromGold = amountDouble % goldCoinValue;

            // find the maximum number of silver coins that “fit” into the amount and remainder
            double silverCoins = Math.Floor(remainingFromGold / silverCoinValue);
            double remainingFromSilver = amountDouble % silverCoinValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainingFromSilver}");
        }
    }
}
