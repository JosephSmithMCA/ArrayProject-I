using System;

namespace ArrayProject1 {
    internal class Program {
        static void Main(string[] args) {
           // RandomDiceRoller();
           // TotalSales();
           // LotteryNumberGenerator();
           // RainfallStatistics();
           // MakingCopies();
            ChipsAndSalsa();
        }//end main
        #region Array Project
        static void RandomDiceRoller() {

                int diceSides = TryInputInt("How many dice sides are there : ");
                int diceRoll = TryInputInt("How many dice would you like to roll :");
                int[] dice = new int[diceRoll];
                Random rand = new Random();

            
                for (int count = 0; count < diceRoll; count += 1) {

                    dice[count] = rand.Next(1, diceSides + 1);
                }//end for

                for (int index = 0; index < dice.GetLength(0); index += 1) {

                    Console.Write($"{dice[index]} ");
            }//end for
        }//end function
         static void TotalSales() {
            double sum = 0.0;
            string day   = "";
            int money = TryInputInt("How many days did you earn money : ");


            string [] days   = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int[] moneys = new int[7];

            for (int count = 0; count < money; count += 1) {
                day = days[count];
                moneys[count] = TryInputInt($"How much money did you make on {day} : ");
                
                sum = sum + moneys[count];
            }//end for

            for (int index = 0; index < days.GetLength(0); index += 1) {

                day = days[index];
                money = moneys[index];
                Console.WriteLine($"{day}  {money:c}");
                Console.WriteLine("------------------------------");
                
            }//end for
                Console.WriteLine($"Your total for the week {sum:c}");
         }//end function
         static void LotteryNumberGenerator() {

            int lotterySlots = 7;
            int[] lotteries = new int[7];
            Random rand = new Random();

            for (int count = 0; count < lotterySlots; count += 1) {

                lotteries[count] = rand.Next(0, 10);
            }//end for
            Console.Write("Your lottery numbers are : ");
            for (int index = 0; index < lotteries.GetLength(0); index += 1) {

                Console.Write($" {lotteries[index]} ");
            }//end for
         }//end function
        static void RainfallStatistics() {
            double totalRainfall = 0.0;
            double averageRainfall = 0.0;
            double currentRainfall = 0.0;
            int highestIndexSeen = 0;
            double highestRainFall = 0.0;
            int lowestIndexSeen = 0;
            double lowestRainfall = 20000000000000;
            string month = "";
            int rainfall = TryInputInt("How many months did it rain : ");


            string[] months = { "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[] rainfalls = new int[12];

            for (int count = 0; count < rainfall; count += 1) {
                month = months[count];
                rainfalls[count] = TryInputInt($"How much rain did you get in {month} : ");
                totalRainfall = totalRainfall + rainfalls[count];
            }//end for

            for (int index = 0; index < months.GetLength(0); index += 1) {

                month = months[index];
                rainfall = rainfalls[index];
                Console.WriteLine($"{month}  {rainfall}");
                Console.WriteLine("------------------------------");
            }//end for

            for (int index = 0; index < rainfalls.GetLength(0); index += 1) {
                currentRainfall = rainfalls[index];

                if (currentRainfall > highestRainFall) {
                    highestRainFall = currentRainfall;
                    highestIndexSeen = index;
                }//end if
            }//end for
            
            for (int index = 0; index < rainfalls.GetLength(0); index += 1) {
                currentRainfall = rainfalls[index];

                if (currentRainfall < lowestRainfall) {
                   lowestRainfall =  currentRainfall ;
                    lowestIndexSeen = index;
                }//end if
            }//end for
            averageRainfall = totalRainfall / 12;
            Console.WriteLine($"Your total rainfall for the year is {totalRainfall}");
            Console.WriteLine($"Your average rainfall for the year is {averageRainfall}");

            
            Console.WriteLine($"The months with the highest rainfall for the year is {months[highestIndexSeen]}");
            Console.WriteLine($"The months with the lowest rainfall for the year is {months[lowestIndexSeen]}");
            
        }//end function
        static void MakingCopies() {
            int number = 0;
            int[] array1 = new int[25];
            int[] array2 = new int[25];
            Random rand = new Random();

            

            for (int count = 0; count < 25; count += 1) {

                array1[count] = array2[count] = rand.Next(1, 101);
            }//end for

            for (int index = 0; index < 25; index += 1) {
                
                Console.Write($"{array1[index]} ");
                Console.WriteLine($"{array2[index]}");

            }//end for
                
        }//end function
        static void ChipsAndSalsa() {
            int totalJarSales = 0;
            int currentSales = 0;
            int highestIndex = 0;
            int highestSelling = 0;
            int lowestIndex = 0;
            int lowestSelling = 2000000000;
            string salsa = "";
            int jar = TryInputInt("How many of your salsa types did you sale? ");

            string[] salsaTypes = { "MILD", "MEDIUM", "SWEET", "ZESTY", "HOT"};
            int[] jars = new int[5];

            for (int count = 0; count < 5; count+= 1) {

                salsa = salsaTypes[count];
                jars[count] = TryInputInt($"How many jars of {salsa} salsa jars did you sale this month? ");
                totalJarSales = totalJarSales + jars[count];
            }//end for

            for (int index = 0; index < salsaTypes.GetLength(0); index += 1) {

                salsa = salsaTypes[index];
                jar = jars[index];
                Console.WriteLine($"{salsa}  {jar}");
                Console.WriteLine("------------------------------");
            }//end for

            for (int index = 0; index < jars.GetLength(0); index += 1) {
                currentSales = jars[index];

                if (currentSales > highestSelling) {
                    highestSelling = currentSales;
                    highestIndex = index;
                }//end if
            }//end for

            for (int index = 0; index < jars.GetLength(0); index += 1) {
                currentSales = jars[index];

                if (currentSales < lowestSelling) {
                    lowestSelling = currentSales;
                    lowestIndex = index;
                }//end if
            }//end for

            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Your total sales for Salsa is : {totalJarSales} salsa jars");
            Console.WriteLine($"The highest selling salsa is : {salsaTypes[highestIndex]}");
            Console.WriteLine($"The lowest selling salsa is : {salsaTypes[lowestIndex]}");
        }//end function
        #endregion
        #region HELPER FUNCTIONS
        static void Print(string message) {
            Console.Write(message);
        }//end function
        static void PrintColor(string message, ConsoleColor color = ConsoleColor.White) {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }//end function
        static string Input(string message) {
            Console.Write(message);
            return Console.ReadLine();
        }//end function
        static decimal InputDecimal(string message) {
            string value = Input(message);
            return decimal.Parse(value);
        }//end function
        static decimal TryInputDecimal(string message) {
            decimal parsedValue = 0;
            bool parsedSuccessfully = false;

            do {
                parsedSuccessfully = decimal.TryParse(Input(message), out parsedValue);
            } while (parsedSuccessfully == false);
            return parsedValue;
        }//end function
        static double InputDouble(string message) {
            string value = Input(message);
            return double.Parse(value);
        }//end function
        static double TryInputDouble(string message) {
            double parsedValue = 0;
            bool parsedSuccessfully = false;

            do {
                parsedSuccessfully = double.TryParse(Input(message), out parsedValue);
            } while (parsedSuccessfully == false);
            return parsedValue;
        }//end function
        static int InputInt(string message) {
            string value = Input(message);
            return int.Parse(value);
        }//end function
        static int TryInputInt(string message) {
            int parsedValue = 0;
            bool parsedSuccessfully = false;

            do {
                parsedSuccessfully = int.TryParse(Input(message), out parsedValue);
            } while (parsedSuccessfully == false);
            return parsedValue;
        }//end function
        #endregion
    }//end class
}//end namespace