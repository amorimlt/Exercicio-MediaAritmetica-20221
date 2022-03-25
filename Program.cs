double n1, n2, n3;

Console.Write("Digite o primeiro número: ");
n1 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o segundo número: ");
n2 = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o terceiro número: ");
n3 = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("A media é: ");

Console.WriteLine($"{(n1 + n2 + n3) / 3:N1}");
