import java.util.ArrayList;

public class Escuela {
    private String nombre;
    private String direccion;
    private ArrayList<Profesor> profesores;
    private ArrayList<Estudiante> estudiantes;

    public Escuela(String nombre, String direccion) {
        this.nombre = nombre;
        this.direccion = direccion;
        this.profesores = new ArrayList<>();
        this.estudiantes = new ArrayList<>();
    }

    public void agregarProfesor(Profesor p) {
        profesores.add(p);
    }

    public void agregarEstudiante(Estudiante e) {
        estudiantes.add(e);
    }

    public void mostrarInfo() {
        System.out.println("🎵 Escuela: " + nombre + " | Dirección: " + direccion);
        System.out.println("Profesores: " + profesores.size() + " | Estudiantes: " + estudiantes.size());
    }
}