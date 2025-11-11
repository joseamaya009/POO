package main

import "fmt"

type Profesor struct {
	nombre      string
	instrumento string
	salario     float64
}

func NuevoProfesor(nombre, instrumento string, salario float64) Profesor {
	return Profesor{nombre, instrumento, salario}
}

func (p Profesor) Enseñar() {
	fmt.Printf("%s enseña a tocar %s.\n", p.nombre, p.instrumento)
}