using System.IO.Pipelines;

string input = "    Vilnius ";
string text = "Šitas filmas yra kvailas ir nuobodus.";
string vardasPavarde = "Jonas Antanaitis";
string email = "Studentas@ManoMokykla.LT";

Console.WriteLine("1.");
input = input.Trim();
Console.WriteLine(input);
Console.WriteLine(input.StartsWith("Vil"));
Console.WriteLine(input.EndsWith("nius"));

Console.WriteLine("2.");
text = text.Replace("kvailas", "***");
text = text.Replace("nuobodus", "***");
Console.WriteLine(text);

Console.WriteLine("3.");
string inicialai = $"{vardasPavarde.Substring(0, 1)}. {vardasPavarde.Substring(vardasPavarde.IndexOf(" ") + 1, 1)}.";
Console.WriteLine(inicialai);

Console.WriteLine("4.");
var result = email.EndsWith(".mokykla.lt", StringComparison.OrdinalIgnoreCase) || email.EndsWith("@mokykla.lt", StringComparison.OrdinalIgnoreCase);
Console.WriteLine(result);
