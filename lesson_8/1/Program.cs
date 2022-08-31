Console.Clear();

string ForNumbers(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
        result += $"{i} ";
    return result;
}

string ForNumbers2(int a, int b)
{
    string result = string.Empty;
    for (int i = b; i >= a; i--)
        result += $"{i} ";
    return result;
}
// с помощью рекурсии
string ForNumbersRec(int a, int b)
{
    string result = string.Empty;
    if (a < b) return $"{a} " + ForNumbersRec(a + 1, b);
    else
        return $"{b}";
}

// с помощью рекурсии
string ForNumbersRec2(int a, int b)
{
    string result = string.Empty;
    if (a >= b) return $"{a} " + ForNumbersRec2(a - 1, b);
    else
        return string.Empty;
}

int SumRec(int n)
{
    if (n == 0)
        return 0;
    else
        return n + SumRec(n - 1);
}

int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}


int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    //if (n == 0) return 1;
    //else return PowerRec(a, n - 1) * a;
}

Console.WriteLine(ForNumbers(1, 10));
Console.WriteLine(ForNumbers2(1, 10));
Console.WriteLine(ForNumbersRec(1, 10));
Console.WriteLine(ForNumbersRec2(10, 1));
Console.WriteLine(SumRec(10));
Console.WriteLine(Factorial(10));
Console.WriteLine(PowerRec(10, 3));

int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{++n} {new String(word)}");
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}

FindWords("аисв", new char[1]);

string path = "C:\\Users\\Admin\\Desktop\\GB";
DirectoryInfo dd = new DirectoryInfo(path);
Console.WriteLine(dd.FullName);
Console.WriteLine(dd.CreationTime);
FileInfo[] fi = dd.GetFiles();
for (int i = 0; i < fi.Length; i++)
    Console.WriteLine(fi[i].Name);


/* void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalogs = new DirectoryInfo(path);
    foreach (var currentCatalog in catalogs.GetDirectories())
    {
        Console.WriteLine($"{indent}{currentCatalog.Name}");
        CatalogInfo(currentCatalog.FullName, indent + " ");
    }
    foreach (var item in catalogs.GetFiles())
    {
        Console.WriteLine($"{indent}{item.Name}");
    }
}
CatalogInfo(path); */


//Игра в пирамидки
//Решение некоторых задач
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}

Towers();

//Обход разных структур
//Решение некоторых задач
string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// 0 1 2 3 4 5 6 7 8 9 10 11
void InOrderTraversal(int pos = 1)
{
 if (pos < tree.Length)
 {
 int left = 2 * pos;
 int right = 2 * pos + 1;
 if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
 Console.WriteLine(tree[pos]);
 if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
 }
}

InOrderTraversal();



