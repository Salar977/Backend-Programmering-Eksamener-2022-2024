
// Oppgave A
// Lag en konsollapplikasjon der du definerer variabler med forskjellige datatyper, inkludert int, float, double, char, bool og string.
// Gi hver variabel en passende verdi.
int intNum = 33;
float floatNum = 13.4f;
double doubleNum = 55.3253253535;
char charVar = 'S';
bool isTrue = true;
string helloWorld = "Hello, World!";

// Oppgave B
// Skriv ut verdiene av variablene du har definert i oppgave A, sammen med deres tilhørende datatyper.
Console.WriteLine("Oppgave 1A og 1B");
			
Console.WriteLine($"int: {intNum} ({intNum.GetType()})");
Console.WriteLine($"float: {floatNum} ({floatNum.GetType()})");
Console.WriteLine($"double: {doubleNum} ({doubleNum.GetType()})");
Console.WriteLine($"char: {charVar} ({charVar.GetType()})");
Console.WriteLine($"bool: {isTrue} ({isTrue.GetType()})");
Console.WriteLine($"string: {helloWorld} ({helloWorld.GetType()})");


// Oppgave C
// Summer tallene i variablene som har datatypene int, float og double. Lagre svaret i en ny variabel av datatypen int.
// Husk å konvertere variabler som ikke er av datatypen int til int før du summerer.
Console.WriteLine("\nOppgave 1C");

int sum = intNum + (int) floatNum + (int) doubleNum;
Console.WriteLine($"Summen av tallene {intNum} + {floatNum} + {doubleNum} = {sum}");


// Oppgave D
// Lag en int-array med 5 ulike heltalls verdier. Lag deretter en løkke som beregner og skriver ut summen av tallene i arrayet
Console.WriteLine("\nOppgave 1D");

int[] intArray = {8, 13, 25, 2, 1};
int sumArray = 0;
			
foreach(int i in intArray)
{
	sumArray += i;
}

Console.WriteLine($"Summen av tallene {String.Join(" ", intArray)} = {sumArray}");

// Oppgave E
// Lag en static metode (static int FindMax(int[] arr) som tar inn enn int array og returerer det største heltallet i
// arrayet uten å bruke innebygde funksjoner som arr.Max()
// eller arr.ToList().Max(). Bruk arrayet fra oppgave D og skriv ut resultatet
Console.WriteLine("\nOppgave 1E");

Console.WriteLine(FindMax(intArray));
			
static int FindMax(int[] arr)
{
	if (arr == null || arr.Length == 0)
		return 0;
				
	int max = arr[0];
	int index = 1;
	while (index < arr.Length)
	{
		if(max < arr[index])
		{
			max = arr[index];
		}
		index++;
	}
	return max;
}