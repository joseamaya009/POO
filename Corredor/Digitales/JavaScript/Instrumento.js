class Instrumento {
    constructor(nombre, tipo, costo) {
        this.nombre = nombre;
        this.tipo = tipo;
        this.costo = costo;
    }

    mostrar() {
        console.log(`Instrumento: ${this.nombre} | Tipo: ${this.tipo} | Costo: $${this.costo}`);
    }
}

module.exports = Instrumento;