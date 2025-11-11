public class Instrumento {
    private String nombre;
    private String tipo;
    private double costo;

    public Instrumento(String nombre, String tipo, double costo) {
        this.nombre = nombre;
        this.tipo = tipo;
        this.costo = costo;
    }

    public void mostrar() {
        System.out.println("Instrumento: " + nombre + " | Tipo: " + tipo + " | Costo: $" + costo);
    }
}