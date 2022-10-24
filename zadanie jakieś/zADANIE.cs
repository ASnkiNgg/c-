//zadanie 1
Console.WriteLine("ZAdanie 1");
Console.WriteLine("Podaj a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a);
if(a%2 == 0)
{
    Console.WriteLine("liczba jest parzysta");
}
else
{
    Console.WriteLine("liczba nie jest parzysta");
}


//zadanie 2
Console.WriteLine("Zadanie 2");
Console.WriteLine("Podaj b:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj c:");
int c = Convert.ToInt32(Console.ReadLine());

int d = b + c;
Console.WriteLine("Dodawanie " + b + " + " + c + " = " + d);

int e = b - c;
Console.WriteLine("Dodawanie "+b +" - "+c +" = " + e);

int f = b / c;
Console.WriteLine("Dodawanie " + b + " / " + c + " = " + f);

int g = b * c;
Console.WriteLine("Dodawanie " + b + " * " + c + " = " + g);
// zadanie 3
Console.WriteLine("zadanie 3");
Console.WriteLine("Podaj rok urodzenia ");
int rok_uro = Convert.ToInt32(Console.ReadLine());
if (rok_uro > 2022)
{
    Console.WriteLine("gościu nie urodziłeś się jeszcze");
}
int wiek = 2022 - rok_uro;
Console.WriteLine("Wiek wynosi : "+wiek);

if (wiek >= 18)
{
    Console.WriteLine("użytkownik jest pełnoletni");
}
else
{
    Console.WriteLine("użytkownik nie jest pełno letni");
}
//kys cwelu
