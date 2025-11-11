class Profesor {
    constructor(nombre, instrumento, salario) {
        this.nombre = nombre;
        this.instrumento = instrumento;
        this.salario = salario;
    }

    enseñar() {
        console.log(`${this.nombre} enseña a tocar ${this.instrumento}.`);
    }
}

module.exports = Profesor;