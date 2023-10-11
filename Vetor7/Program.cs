using System.Globalization;

int N = int.Parse(Console.ReadLine());

string[] nomes = new string[N];
double[] notaPrimeiroSemestre = new double[N];
double[] notaSegundoSemestre = new double[N];

for (int i = 0; i < N; i++) {
    string[] vet = Console.ReadLine().Split(' ');
    nomes[i] = vet[0];
    notaPrimeiroSemestre[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
    notaSegundoSemestre[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
}

Console.WriteLine("Alunos aprovados");
for (int i = 0; i < N; i++) {
    double media = (notaPrimeiroSemestre[i] + notaSegundoSemestre[i]) / 2.0;
    if (media >= 6.0) {
        Console.WriteLine(nomes[i]);
    }
}