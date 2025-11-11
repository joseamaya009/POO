package main

import "fmt"

type Estudiante struct {
	nombre      string
	instrumento string
	nivel       int
}

func NuevoEstudiante(nombre, instrumento string, nivel int) Estudiante {
	return Estudiante{nombre, instrumento, nivel}
}

func (e Estudiante) Practicar() {
	fmt.Printf("%s practica %s (nivel %d).\n", e.nombre, e.instrumento, e.nivel)
}