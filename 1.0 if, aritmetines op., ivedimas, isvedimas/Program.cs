using System.IO.Pipelines;

var uzd1 = "1. Parašykite programą, kuri išvestų į ekraną, ar skaičius a yra didesnis už b";
var uzd2 = "2. Parašykite programą, kuri išvestų į ekraną, ar skaičius a yra didesnis, lyguis ar maženis už b.";
var uzd3 = "3. Parašykite programą, kuri išvestų į ekraną, didžiausią skaičių iš a, b ir c.";
var uzd4 = "4. Parašykite programą, kuri išvestų į ekraną, ar skaičius n yra lyginis.";
var uzd5 = "5. Parašykite programą, kuri išvestų į ekraną, ar iš trijų atkarpų a, b, c galima sudaryti trikampį";
var uzd6 = "6. Parašykite programą, kuri išvestų į ekraną, ar įvesti metai yra keliamieji.";
var uzd7 = "7. Parašykite programą, kuri išvestų į ekraną kiek minučių praėjo nuo vidurnakčio. Vartotojas įveda valandas ir minutes.";


Console.WriteLine(uzd1);
var a1 = 1;
var b1 = 2;
Console.WriteLine($"a={a1}, b={b1}, {a1 > b1}");
Console.WriteLine("");

Console.WriteLine(uzd2);
var a2 = 1;
var b2 = 2;

var result2 = "";
if (a2 > b2) { result2 = "didesnis"; }
else if (a2 == b2) { result2 = "lygūs"; }
else { result2 = "mažesnis"; }

Console.WriteLine($"a={a2}, b={b2}, {result2}");
Console.WriteLine("");

Console.WriteLine(uzd3);
var a3 = 15;
var b3 = 22;
var c3 = 8;

int result3;

if (a3 > b3 && a3 > c3) { result3 = a3; }
else if (b3 > c3) { result3 = b3; }
else result3 = c3
;

Console.WriteLine($"a={a3}, b={b3}, c={c3}, {result3}");
Console.WriteLine("");

Console.WriteLine(uzd4);
var n = 5;
var result4 = "";

if (n % 2 == 0) { result4 = "lyginis"; }
else result4 = "nelyginis";

Console.WriteLine($"n={n}, {result4}");
Console.WriteLine("");

Console.WriteLine(uzd5);

var a5 = 3;
var b5 = 4;
var c5 = 5;

bool result5;

if (a5 == b5 || a5 == c5 || b5 == c5) { result5 = true; }
else if (a5 > b5 && a5 > c5) { result5 = a5 < (b5 + c5); }
else if (b5 > a5 && b5 > c5) { result5 = b5 < (a5 + c5); }
else result5 = c5 < (a5 + b5);
Console.WriteLine($"a={a5}, b={b5}, c={c5}, {result5}");
Console.WriteLine("");

Console.WriteLine(uzd6);
var metai = 2024;
bool result6;
if (metai % 4 == 0) { result6 = true; }
else result6 = false;
Console.WriteLine($"metai={metai}, {result6}");
Console.WriteLine("");

Console.WriteLine(uzd7);

string valandos;
string minutes;
Console.WriteLine("Įveskite valandą.");
valandos = Console.ReadLine();


Console.WriteLine("Įveskite minutes.");
minutes = Console.ReadLine();

int result7 = Int32.Parse(valandos) * 60 + Int32.Parse(minutes);

Console.WriteLine($"valandos={valandos}, minutes={minutes}. Viso minučių {result7}");

Console.WriteLine("");
