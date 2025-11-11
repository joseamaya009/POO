package main

import "fmt"

type Instrumento struct {
	nombre string
	tipo   string
	costo  float64
}

func NuevoInstrumento(nombre, tipo string, costo float64) Instrumento {
	return Instrumento{nombre, tipo, costo}
}

func (i Instrumento) Mostrar() {
	fmt.Printf("Instrumento: %s | Tipo: %s | Costo: $%.2f\n", i.nombre, i.tipo, i.costo)
}