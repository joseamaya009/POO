public class Main {
    public static void main(String[] args) {
        Escuela escuela = new Escuela("Academia Armonía", "Calle 10 #25-36");
        Profesor profesor = new Profesor("Laura", "Piano", 2500.0);
        Estudiante estudiante = new Estudiante("Carlos", "Piano", 2);
        Director director = new Director("Andrés");
        Instrumento instrumento = new Instrumento("Piano Yamaha", "Teclado", 3200.0);

        escuela.agregarProfesor(profesor);
        escuela.agregarEstudiante(estudiante);

        escuela.mostrarInfo();
        profesor.enseñar();
        estudiante.practicar();
        director.supervisar();
        instrumento.mostrar();

        System.out.println("\n Fin del programa.");
    }
}