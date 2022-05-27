// Напишите функцию, которая принимает слово 
// и возвращает true, если в этом слове есть 
//две одинаковые, стоящие рядом буквы.
//"ссора" -> true
//"клюющий" -> true
//"кодер" -> false
//"цыпленок"-> false


Console.WriteLine("Введите слово = ");
string userString = Console.ReadLine();
Console.WriteLine(userString);
int Length = userString.Length;
for (int i = 0; i < Length; i++)
{
    bool isTwoSideYes = true;
    bool isTwoSideNo = false;
    if (userString[i] == userString[i+1])
    {
        Console.WriteLine(isTwoSideYes);
        break;  
        
    }
    else 
    {
        Console.WriteLine(isTwoSideNo);

    }
}


