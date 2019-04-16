using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Modelos
{
    class Nota
    {
        
        // atributo aluno
        public String aluno;

        // atributo disciplina
        public String disciplina;

        // atributo valor
        public int valor;

        // construtor da classe
        public Nota(String aluno, String disciplina, int valor)
        {
            this.aluno = aluno;
            this.disciplina = disciplina;
            this.valor = valor;
        }

        // método para verificar se o aluno foi aprovado na disciplina
        public bool Aprovar()
        {
            return this.valor >= 6;
        }

    }
}
