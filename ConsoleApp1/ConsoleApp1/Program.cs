using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Create a new text file");
            Console.WriteLine("2. Read the content of a text file");
            Console.WriteLine("3. Append content to a text file");
            Console.WriteLine("4. Delete a text file");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the file name: ");
                    string createFileName = Console.ReadLine();
                    Console.Write("Enter the content: ");
                    string createFileContent = Console.ReadLine();
                    CreateFile(createFileName, createFileContent);
                    Console.WriteLine($"File '{createFileName}' created successfully.");
                    break;

                case 2:
                    Console.Write("Enter the file name to read: ");
                    string readFile = Console.ReadLine();
                    ReadFile(readFile);
                    break;

                case 3:
                    Console.Write("Enter the file name to append: ");
                    string appendFileName = Console.ReadLine();
                    Console.Write("Enter the content to append: ");
                    string appendContent = Console.ReadLine();
                    AppendToFile(appendFileName, appendContent);
                    Console.WriteLine($"Content appended to '{appendFileName}' successfully.");
                    break;

                case 4:
                    Console.Write("Enter the file name to delete: ");
                    string deleteFileName = Console.ReadLine();
                    DeleteFile(deleteFileName);
                    Console.WriteLine($"File '{deleteFileName}' deleted successfully.");
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateFile(string fileName, string content)
    {
        File.WriteAllText(fileName, content);
    }

    static void ReadFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string content = File.ReadAllText(fileName);
            Console.WriteLine($"Content of '{fileName}':");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }

    static void AppendToFile(string fileName, string content)
    {
        if (File.Exists(fileName))
        {
            File.AppendAllText(fileName, content);
        }
        else
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }

    static void DeleteFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
        else
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }
}
