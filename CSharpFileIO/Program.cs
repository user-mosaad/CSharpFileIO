string filePath = "file.txt"; 

// Create and write to the text file.
using (StreamWriter writer = File.CreateText(filePath))
{
    writer.WriteLine("Hello, this is the first line of this text file.");
    writer.WriteLine("And this is the second line.");
}

// Read the text file.
using (StreamReader reader = new StreamReader(filePath))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// Append to the text file.
using (StreamWriter writer = File.AppendText(filePath))
{
    writer.WriteLine("This line is appended to the end of the text file.");
}

// Read the text file.
Console.WriteLine();
using (StreamReader reader = new StreamReader(filePath))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// Delete the text file.
// 1. File has been deleted successfully.
Console.WriteLine();
if (File.Exists(filePath))
{
    File.Delete(filePath);
    Console.WriteLine($"File {filePath} has been deleted.");
}
else
{
    Console.WriteLine($"File {filePath} does not exist.");
}

// 2. File does not exist.
Console.WriteLine();
if (File.Exists(filePath))
{
    File.Delete(filePath);
    Console.WriteLine($"File {filePath} has been deleted.");
}
else
{
    Console.WriteLine($"File {filePath} does not exist.");
}
