Console.WriteLine("--- Raio e Trovão ---\n");
Console.WriteLine("Digite quanto tempo demorou para o raio cair...");
double segundos =Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"trovão a {segundos} segundos ==> raio caiu a {DistanciaDoRaioKm(segundos):N5} quilômetros");

double DistanciaDoRaioKm(double segundos)
{
    const double VelocidadeDoSomKmS = 340.29 / 1000;
    return segundos * VelocidadeDoSomKmS;
}
