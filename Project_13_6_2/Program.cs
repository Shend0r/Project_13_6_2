// See https://aka.ms/new-console-template for more information

using Project_13_6_2;

SortedList<string, int> words_list = new SortedList<string, int>();
Data data = new Data();

var cleared_words = data.ClearWords("data.txt").GroupBy(x => x.ToLower());

foreach (var item in cleared_words)
{
    words_list.Add(item.Key, item.Count());
}

var sorted_list = words_list.OrderBy(x => x.Value).ToList();

var not_splited = default(string);

foreach (var word in sorted_list)
{
    not_splited += $"Слово : {word.Key}, Количество повторений : {word.Value};";
}

var splited_list = not_splited.Split(';');

Console.WriteLine(splited_list[splited_list.Length - 2]);
Console.WriteLine(splited_list[splited_list.Length - 3]);
Console.WriteLine(splited_list[splited_list.Length - 4]);
Console.WriteLine(splited_list[splited_list.Length - 5]);
Console.WriteLine(splited_list[splited_list.Length - 6]);
Console.WriteLine(splited_list[splited_list.Length - 7]);
Console.WriteLine(splited_list[splited_list.Length - 8]);
Console.WriteLine(splited_list[splited_list.Length - 9]);
Console.WriteLine(splited_list[splited_list.Length - 10]);
Console.WriteLine(splited_list[splited_list.Length - 11]);

Console.ReadKey();
