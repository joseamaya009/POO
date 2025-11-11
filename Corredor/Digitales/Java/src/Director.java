public class Director {
    private String nombre;

    public Director(String nombre) {
        this.nombre = nombre;
    }

    public void supervisar() {
        System.out.println(nombre + " supervisa el funcionamiento de la escuela.");
    }
}