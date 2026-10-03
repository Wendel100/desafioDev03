decimal multa = 0;

DateTime dataVencimento = DateTime.Parse("20/08/2025");
DateTime dataAtual = DateTime.Now;

int diasAtrasados = (dataAtual - dataVencimento).Days;

decimal jurosPorDia = 2.5m;

multa = diasAtrasados * jurosPorDia;
Console.WriteLine($"Multa: R$ {multa:F2}");