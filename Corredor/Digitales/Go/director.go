package main

import "fmt"

type Director struct {
	nombre string
}

func NuevoDirector(nombre string) Director {
	return Director{nombre}
}

func (d Director) Supervisar() {
	fmt.Printf("%s supervisa el funcionamiento de la escuela.\n", d.nombre)
}