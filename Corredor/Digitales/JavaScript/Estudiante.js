class Estudiante {
    constructor(nombre, instrumento, nivel) {
        this.nombre = nombre;
        this.instrumento = instrumento;
        this.nivel = nivel;
    }

    practicar() {
        console.log(`${this.nombre} practica ${this.instrumento} (nivel ${this.nivel}).`);
    }
}

module.exports = Estudiante;