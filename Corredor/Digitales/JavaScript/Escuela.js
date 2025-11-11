class Escuela {
    constructor(nombre, direccion) {
        this.nombre = nombre;
        this.direccion = direccion;
        this.profesores = [];
        this.estudiantes = [];
    }

    agregarProfesor(profesor) {
        this.profesores.push(profesor);
    }

    agregarEstudiante(estudiante) {
        this.estudiantes.push(estudiante);
    }

    mostrarInfo() {
        console.log(`🎵 Escuela: ${this.nombre} | Dirección: ${this.direccion}`);
        console.log(`Profesores: ${this.profesores.length} | Estudiantes: ${this.estudiantes.length}`);
    }
}

module.exports = Escuela;