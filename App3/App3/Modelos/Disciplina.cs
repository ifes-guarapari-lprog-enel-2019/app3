using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Modelos
{
    class Disciplina
    {
        // atributo nome
        public String nome;

        // atributo semestre
        public int semestre;

        // atributo professor
        public int professor;

        // construtor da classe
        public Disciplina(String nome, int semestre, int professor)
        {
            this.nome = nome;
            this.semestre = semestre;
            this.professor = professor;
        }

        // método para verificar se o professor leciona a disciplina 
        public bool Lecionar(Professor professor)
        {
            // retorna se o código do professor é o mesmo da disciplina
            return this.professor == professor.codigo;
        }

    }
}