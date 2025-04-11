decimal capital, juros, montante;
double taxa;
int tempo;

Console.Clear();
Console.WriteLine("Juros simples (j)\n");

Console.Write("Capital [c] (R$).......: ");
capital = Convert.ToDecimal(Console.ReadLine());
Console.Write("Taxa de juros [i] (%)..: ");
taxa = Convert.ToDouble(Console.ReadLine());
Console.Write("Tempo [t] (meses)......: ");
tempo = Convert.ToInt32(Console.ReadLine());

juros = capital * Convert.ToDecimal(taxa / 100) * tempo;
montante = capital + juros;

Console.WriteLine($"\nJuros (R$).....: {juros:N2}");
Console.WriteLine($"Montante (R$)..: {montante:N2}");