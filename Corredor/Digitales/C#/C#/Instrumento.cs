namespace EscuelaMusica
{
    public class Instrumento
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public double Costo { get; set; }

        public Instrumento(string nombre, string tipo, double costo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Costo = costo;
        }

        public void Mostrar()
        {
            System.Console.WriteLine($"Instrumento: {Nombre} | Tipo: {Tipo} | Costo: ${Costo}");
        }
    }
}