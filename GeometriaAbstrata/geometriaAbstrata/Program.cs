using geometriaAbstrata;

class Program
{
    static List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();
    static void Main(string[] args)
    {
        formasGeometricas.Add(new Quadrado(2, 3));
        formasGeometricas.Add(new Circulo(0, 2));
        formasGeometricas.Add(new Retangulo(2, 3,5));
        formasGeometricas.Add(new Triangulo(3, 3, 2,2));

        foreach (var formas in formasGeometricas)
        {
            formas.CalcularArea();
        }
    }
}