using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
                Picker1.SelectedIndex == Picker2.SelectedIndex)
            {
                // habilitar mensagem de sucesso de nota registrada
                Label1.IsVisible = true;
                // criar variável de nota
                int nota = int.Parse(Entry2.Text);
                // verificar se o aluno foi aprovado
                if (nota >= 6)
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
