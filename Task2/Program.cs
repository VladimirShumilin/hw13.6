// Задание 13.6.2
using System.Diagnostics;

char[] splitChars = new char[] { ' ', '\r', '\n' };
Dictionary<string, int> unicWords = new Dictionary<string, int>();

try
{
    string data = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Text1.txt"));
    var noPunctuationText = new string(data.Where(c => !char.IsPunctuation(c)).ToArray()) ;

    string[] words = data.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < words.Length; i++)
    {
        string key = words[i].ToLower();
        if (unicWords.ContainsKey(key))
            unicWords[key] += 1;
        else
            unicWords.Add(key, 1);
    }

    var top10Words = unicWords.OrderByDescending(x => x.Value).Take(10);

    foreach (var word in top10Words)
        Console.WriteLine($"Слово:{word.Key} повторений: {word.Value}");


    Console.WriteLine("Для завершения работы нажмите любую клавишу.");
    Console.ReadKey();

}
//Path.Combine
catch (ArgumentNullException ex) { Console.WriteLine(ex); }
catch (ArgumentException ex) { Console.WriteLine(ex); }
//File.ReadAllLines
catch (PathTooLongException ex) { Console.WriteLine(ex); }
catch (DirectoryNotFoundException ex) { Console.WriteLine(ex); }
catch (UnauthorizedAccessException ex) { Console.WriteLine(ex); }
catch (FileNotFoundException ex) { Console.WriteLine(ex); }
catch (IOException ex) { Console.WriteLine(ex); }
catch (NotSupportedException ex) { Console.WriteLine(ex); }
catch (System.Security.SecurityException ex) { Console.WriteLine(ex); }