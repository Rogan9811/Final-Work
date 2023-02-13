//    Задача: Написать программу, которая из имеющегося массива строк формирует масси из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.

string[] fillArraySmth(string[] array, string[] words)
{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length <= 3) 
        {
            array[count] = words[i];
            count ++;
        }
    }
    return array;
}

Console.Clear();

Console.Write("Добро пожаловать на Итогову задачу. Введите число слов, которые вы хотите ввести: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Замечательно! А теперь введите ваши слова.");
string[] arr = new string[num];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} слово:");
    arr[i] = Console.ReadLine();
}

string[] Array = new string[num];
fillArraySmth(Array, arr);

Console.Write('{' + " " + string.Join(' ', Array) + '}');