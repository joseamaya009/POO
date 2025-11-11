public class Profesor {
    private String nombre;
    private String instrumento;
    private double salario;

    public Profesor(String nombre, String instrumento, double salario) {
        this.nombre = nombre;
        this.instrumento = instrumento;
        this.salario = salario;
    }

    public void enseñar() {
        System.out.println(nombre + " enseña a tocar " + instrumento + ".");
    }
}