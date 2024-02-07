
string unsortedFile = "C:\\ga\\Algoritmiske metoder\\Eksamen emne 5\\InsertionSort\\Files\\1000words.txt";
string sortedFile = "C:\\ga\\Algoritmiske metoder\\Eksamen emne 5\\InsertionSort\\Files\\sorted.txt";
//Unfortunately I could not get the path.combine to work correctly, so you need to get your own filepath.

//string path = AppDomain.CurrentDomain.BaseDirectory;

//string unsortedPath = Path.Combine(path, unsortedFile);
//string sortedPath = Path.Combine(path, sortedFile);

string[] unsortedArray = ReadArrayFromFile(unsortedFile);

InsertionSort(unsortedArray);

WriteArrayToFile(sortedFile, unsortedArray);

static string[] ReadArrayFromFile(string filePath)
{
    
    return File.ReadAllLines(filePath);
}

static void InsertionSort(string[] array)
{
    for (int i = 1; i < array.Length; i++)
    {
        string key = array[i];
        int j = i - 1;

        
        while (j >= 0 && string.Compare(array[j], key) > 0)
        {
            array[j + 1] = array[j];
            j = j - 1;
        }
        array[j + 1] = key;
    }
}

static void WriteArrayToFile(string filePath, string[] array)
{
    
    File.WriteAllLines(filePath, array);
}