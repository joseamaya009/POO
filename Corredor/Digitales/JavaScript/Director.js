class Director {
    constructor(nombre) {
        this.nombre = nombre;
    }

    supervisar() {
        console.log(`${this.nombre} supervisa el funcionamiento de la escuela.`);
    }
}

module.exports = Director;