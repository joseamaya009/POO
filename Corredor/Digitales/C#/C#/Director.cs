namespace EscuelaMusica
{
    public class Director
    {
        public string Nombre { get; set; }

        public Director(string nombre)
        {
            Nombre = nombre;
        }

        public void Supervisar()
        {
            System.Console.WriteLine($"{Nombre} supervisa el funcionamiento de la escuela.");
        }
    }
}