// Задание 13.6.1 
using System.Diagnostics;

try
{
    string[] data = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Text1.txt"));    
    List<string> list = new List<string>();
    LinkedList<string> linkList = new LinkedList<string>();

    Stopwatch sw = Stopwatch.StartNew();
    list.AddRange(data);
    sw.Stop();
    Console.WriteLine($"metod List.AddRange: {sw.ElapsedMilliseconds} ms. Rows {list.Count} ");

    list.Clear();
    sw.Restart();
    foreach(string s in data)
        list.Add(s);
    sw.Stop();
    Console.WriteLine($"metod List.Add: {sw.ElapsedMilliseconds} ms. Rows {list.Count} ");

    sw.Restart();
    foreach (string s in data)
        linkList.AddFirst(s);
    sw.Stop();
    Console.WriteLine($"metod LinkedList.AddFirst: {sw.ElapsedMilliseconds} ms. Rows {list.Count} ");

    linkList.Clear();
    sw.Restart();
    foreach (string s in data)
        linkList.AddLast(s);
    sw.Stop();
    Console.WriteLine($"metod LinkedList.AddLast: {sw.ElapsedMilliseconds} ms. Rows {list.Count} ");


    Console.WriteLine("Для завершения работы нажмите любую клавишу.");
    Console.ReadKey();

}
//Path.Combine
catch (ArgumentNullException ex){ Console.WriteLine(ex); }
catch (ArgumentException ex){ Console.WriteLine(ex); }
//File.ReadAllLines
catch (PathTooLongException ex) { Console.WriteLine(ex); }
catch (DirectoryNotFoundException ex) { Console.WriteLine(ex); }
catch (UnauthorizedAccessException ex) { Console.WriteLine(ex); }
catch (FileNotFoundException ex) { Console.WriteLine(ex); }
catch (IOException ex) { Console.WriteLine(ex); }
catch (NotSupportedException ex) { Console.WriteLine(ex); }
catch (System.Security.SecurityException ex) { Console.WriteLine(ex); }
