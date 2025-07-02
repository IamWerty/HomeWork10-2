using System.Text;

Console.OutputEncoding = Encoding.UTF8;

StringBuilder report = new StringBuilder();
report.AppendLine($"Звіт подій\nДата: {DateTime.Now.ToString("dd.MM.yyyy")}\n-----------------------------");

bool isWhile = true;

while (isWhile)
{
    Console.Write("Подія: ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        isWhile = false;
        break;
    }
    report.AppendLine("- " + input);
}

report.AppendLine("-----------------------------");
report.AppendLine("Кінець звіту");

Console.WriteLine("\nЗгенерований звіт:\n");
Console.WriteLine(report.ToString());