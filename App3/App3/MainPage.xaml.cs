using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3.Modelos;

namespace App3
{
    public partial class MainPage : ContentPage
    {

        // vetor de professores
        Professor[] professores = new Professor[4]
        {
            new Professor("Maria", 1),
            new Professor("José", 2),
            new Professor("João", 3),
            new Professor("Ana", 4)
        };

        // vetor de disciplinas
        Disciplina[] disciplinas = new Disciplina[4]
        {
            new Disciplina("Cálculo 1", 1, 1),
            new Disciplina("Introdução a Engenharia", 2, 2),
            new Disciplina("Cálculo 2", 3, 3),
            new Disciplina("Projetos de Engenharia", 4, 4)
        };

        public MainPage()
        {
            InitializeComponent();
            // para todos os professores do vetor
            foreach (Professor professor in professores)
            {
                // adicionar um elemento na caixa de seleção
                Picker1.Items.Add(professor.codigo + " - " + professor.nome);
            }
            // para todos as disciplinas do vetor
            foreach (Disciplina disciplina in disciplinas)
            {
                // adicionar um elemento na caixa de seleção
                Picker2.Items.Add(disciplina.semestre + " - " + disciplina.nome);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            // desabilitar mensagens
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            Label3.IsVisible = false;
            Label4.IsVisible = false;
            // verificar se os campos foram preenchidos
            if (Entry1.Text != null &&
                Entry1.Text.Length > 0 &&
                Entry2.Text != null &&
                Entry2.Text.Length > 0 &&
                Picker1.SelectedIndex >= 0 &&
                Picker2.SelectedIndex >= 0 &&
                // verificar se o professor leciona a disciplina selecionada
                disciplinas[Picker2.SelectedIndex]
                 .Lecionar(professores[Picker1.SelectedIndex]))
            {
                // habilitar mensagem de sucesso de nota registrada
                Label1.IsVisible = true;
                // criar objeto aluno
                Aluno aluno = new Aluno
                {
                    // preencher a matrícula do aluno
                    matricula = Entry1.Text
                };
                // criar o objeto nota
                Nota nota = new Nota(aluno.matricula,
                    disciplinas[Picker2.SelectedIndex].nome,
                    int.Parse(Entry2.Text));
                // verificar se a nota aprova o aluno
                if (nota.Aprovar())
                {
                    // habilitar mensagem de aprovado
                    Label2.IsVisible = true;
                }
                else
                {
                    // habilitar mensagem de reprovado
                    Label3.IsVisible = true;
                }
            } else
            {
                // habilitar mensagem de erro
                Label4.IsVisible = true;
            }
        }

    }
}
