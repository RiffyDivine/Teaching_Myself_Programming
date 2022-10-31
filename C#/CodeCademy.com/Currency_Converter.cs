//This isn't working as intended


using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("How much do you wish to convert?");
      string amountToConvert = Console.ReadLine();
      double amountToConvertNumber = Convert.ToDouble(amountToConvert);
      double amountToConvertFloor = Math.Floor(amountToConvertNumber);
      Console.WriteLine($"{amountToConvertFloor} cents is equal to... ");
      int goldCoinVal = 10;
      int silverCoinVal = 5;
      double goldCoins = Math.Floor(amountToConvertFloor / goldCoinVal);
      double goldCoinsRemaining = amountToConvertFloor % goldCoinVal;
      double silverCoins = Math.Floor(goldCoinsRemaining / silverCoinVal);
      double silverCoinsRemaining = silverCoins % silverCoinVal;
      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {silverCoinsRemaining}");
      Console.WriteLine("\nIn US currency it would be...");
      int quarterVal = 25;
      int dimeVal = 10;
      int nickleVal = 5;
      double quarters = Math.Floor(amountToConvertFloor / quarterVal);
      double quatersRemaining = amountToConvertFloor % quarterVal;
      double dimes = Math.Floor(quatersRemaining / dimeVal);
      double dimesRemaining = dimes % dimeVal;
      double nickles = Math.Floor(dimesRemaining / nickleVal);
      double nicklesRemainging = nickles % nickleVal;
      Console.WriteLine($"Quareters: {quarters}");
      Console.WriteLine($"Dimes: {dimes}");
      Console.WriteLine($"Nickles: {nickles}");
      Console.WriteLine($"Pennies: {nicklesRemainging}");
    }
  }
}
