const Escuela = require('./Escuela');
const Profesor = require('./Profesor');
const Estudiante = require('./Estudiante');
const Director = require('./Director');
const Instrumento = require('./Instrumento');

const escuela = new Escuela("Academia Armonía", "Calle 10 #25-36");
const profesor = new Profesor("Laura", "Piano", 2500.0);
const estudiante = new Estudiante("Carlos", "Piano", 2);
const director = new Director("Andrés");
const instrumento = new Instrumento("Piano Yamaha", "Teclado", 3200.0);

escuela.agregarProfesor(profesor);
escuela.agregarEstudiante(estudiante);

escuela.mostrarInfo();
profesor.enseñar();
estudiante.practicar();
director.supervisar();
instrumento.mostrar();

console.log("\n🎶 Fin del programa.");
