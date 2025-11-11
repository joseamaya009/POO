package main

import "fmt"

type Escuela struct {
	nombre      string
	direccion   string
	profesores  []Profesor
	estudiantes []Estudiante
}

func NuevaEscuela(nombre, direccion string) Escuela {
	return Escuela{
		nombre:      nombre,
		direccion:   direccion,
		profesores:  []Profesor{},
		estudiantes: []Estudiante{},
	}
}

func (e *Escuela) AgregarProfesor(p Profesor) {
	e.profesores = append(e.profesores, p)
}

func (e *Escuela) AgregarEstudiante(est Estudiante) {
	e.estudiantes = append(e.estudiantes, est)
}

func (e Escuela) MostrarInfo() {
	fmt.Printf("🎵 Escuela: %s | Dirección: %s\n", e.nombre, e.direccion)
	fmt.Printf("Profesores: %d | Estudiantes: %d\n", len(e.profesores), len(e.estudiantes))
}