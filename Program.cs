Console.WriteLine("Поехали!");
Console.WriteLine("Введите массив строк. Для завершения ввода введите пустую строку.");
string s;
List<string> lst=new List<string>(); //  определение результирующего массива
do
{
    Console.Write(">");
    s = Console.ReadLine();
    // сразу добавляем в массив строки, удовлетворяющие условиям задачи
    if (s != "" & s.Length <= 3) lst.Add(s);
} while (s != "");
