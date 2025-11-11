namespace EscuelaMusica
{
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Instrumento { get; set; }
        public double Salario { get; set; }

        public Profesor(string nombre, string instrumento, double salario)
        {
            Nombre = nombre;
            Instrumento = instrumento;
            Salario = salario;
        }

        public void Enseñar()
        {
            System.Console.WriteLine($"{Nombre} enseña a tocar {Instrumento}.");
        }
    }
}