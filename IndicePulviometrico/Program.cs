int cont = 1, dia = 0, diaMax = 0;
double indiceMax = 0, indiceTotal = 0;

Console.Write("Digite o número de dias do mês: ");
int diaMes = int.Parse(Console.ReadLine());

do
{
    dia++;

    Console.Write("Digite o índice pulviométrico do {0}º dia: ", dia);
    double indice = double.Parse(Console.ReadLine());


    indiceTotal += indice;

    if (indice > indiceMax)
    {
        indiceMax = indice;
        diaMax = dia;
    }
    cont++;
} while (cont <= diaMes);

double media = indiceTotal / diaMes;

Console.WriteLine("\nA média do índice pulviométrico no mês foi: {0}", media);
Console.WriteLine("O maior índice pulviométrico registrado foi {0}, no {1}º dia do mês.", indiceMax, diaMax);

Console.ReadKey();