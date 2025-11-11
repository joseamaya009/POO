namespace EscuelaMusica
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Instrumento { get; set; }
        public int Nivel { get; set; }

        public Estudiante(string nombre, string instrumento, int nivel)
        {
            Nombre = nombre;
            Instrumento = instrumento;
            Nivel = nivel;
        }

        public void Practicar()
        {
            System.Console.WriteLine($"{Nombre} practica {Instrumento} (nivel {Nivel}).");
        }
    }
}