package main

import "fmt"

func main() {
	escuela := NuevaEscuela("Academia Armonía", "Calle 10 #25-36")
	profesor := NuevoProfesor("Laura", "Piano", 2500.0)
	estudiante := NuevoEstudiante("Carlos", "Piano", 2)
	director := NuevoDirector("Andrés")
	instrumento := NuevoInstrumento("Piano Yamaha", "Teclado", 3200.0)

	escuela.AgregarProfesor(profesor)
	escuela.AgregarEstudiante(estudiante)

	escuela.MostrarInfo()
	profesor.Enseñar()
	estudiante.Practicar()
	director.Supervisar()
	instrumento.Mostrar()

	fmt.Println("\n🎶 Fin del programa.")
}