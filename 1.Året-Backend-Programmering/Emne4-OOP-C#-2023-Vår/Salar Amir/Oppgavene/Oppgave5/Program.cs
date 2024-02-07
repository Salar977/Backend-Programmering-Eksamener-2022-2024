using Oppgave5;

BasicCalculator basicCalculator = new BasicCalculator();
RoundingCalculator roundingCalculator = new RoundingCalculator();

Console.WriteLine("BasicCalculator:");
Console.WriteLine($"Add: 13,2 + 7,8 = {basicCalculator.Add(13.2, 7.8)}");
Console.WriteLine($"Subtract: 9,5 - 6,3 = {basicCalculator.Subtract(9.5, 6-3)}");
Console.WriteLine($"Multiply: 24 * 3,5 = {basicCalculator.Multiply(24, 3.5)}");
Console.WriteLine($"Divide: 15 / 4 = {basicCalculator.Divide(15, 4)}");
			
Console.WriteLine("\nRoundingCalculator:");
Console.WriteLine($"Add: 17,8 + 11,7 = {roundingCalculator.Add(17.8, 11.7)}");
Console.WriteLine($"Subtract: 33,9 - 23,2 = {roundingCalculator.Subtract(33.9, 23.2)}");
Console.WriteLine($"Multiply: 13,8 * 3,8 = {roundingCalculator.Multiply(13.8, 3.8)}");
Console.WriteLine($"Divide: 33,9 / 7,3 = {roundingCalculator.Divide(33.9, 7.3)}");