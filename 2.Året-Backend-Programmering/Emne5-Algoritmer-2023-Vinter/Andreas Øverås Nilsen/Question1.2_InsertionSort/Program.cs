using System.IO;

string[] words = new string[1000];
int wordCount = 0;

// Relative Path So anyone with the folder and solution can access the text file!
string filePath = @"..\..\..\1000words.txt";

// Paths the sorted text file to 3 layers outside current folder in the folder "Sorted_1000Words" accessible from the project!
string outputFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "Sorted_1000Words");
Directory.CreateDirectory(outputFolder); // Create directory if it doesn't exist
string sortedFilePath = Path.Combine(outputFolder, "Sorted.txt");


// Read words from file into the array - StreamReader
try
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        string line;
        while ((line = sr.ReadLine()) != null && wordCount < words.Length)
        {
            words[wordCount++] = line;
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(ex.Message);
    return;
}

// Sort the array using Insertion Sort
InsertionSort(words, wordCount);


// Insertion Sort for String array
static void InsertionSort(string[] arr, int length)
{
    for (int i = 1; i < length; ++i)
    {
        string key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j].CompareTo(key) > 0)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}

// Write the sorted words to a new file - StreamWriter
try
{
    using (StreamWriter sw = new StreamWriter(sortedFilePath))
    {
        for (int i = 0; i < wordCount; i++)
        {
            sw.WriteLine(words[i]);
        }
        Console.WriteLine("Words sorted and written to sorted.txt under folder Sorted_1000Words");
    }
}
catch (IOException ex)
{
    Console.WriteLine("The file could not be written:");
    Console.WriteLine(ex.Message);
}
    
