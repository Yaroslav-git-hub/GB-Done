int i = 0;
string[] chars = { "12", "1567", "-2", "cpmputer science" };

int ArrayCount(int cc, string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            cc++;
        }
    }
    return cc;
}

int count = ArrayCount(i, chars);

string[] elements = new string[count + 2];

string[] CreatArray(string[] el, string[] str)
{
    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i].Length <= 3)
        {
            el[i] += chars[i];
        }
    }
    return el;
}

string[] el = CreatArray(elements, chars);


void PrintArray(string[] ele)
{
    Console.Write("[ ");
    for (int i = 0; i < ele.Length; i++)
    {
        Console.Write($"{ele[i]} ");
    }
    Console.Write("]");
}

PrintArray(el);

