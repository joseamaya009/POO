public class Estudiante {
    private String nombre;
    private String instrumento;
    private int nivel;

    public Estudiante(String nombre, String instrumento, int nivel) {
        this.nombre = nombre;
        this.instrumento = instrumento;
        this.nivel = nivel;
    }

    public void practicar() {
        System.out.println(nombre + " practica " + instrumento + " (nivel " + nivel + ").");
    }
}