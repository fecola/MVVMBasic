using MVVMBasic.Model;
using MVVMBasic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMBasic.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovosAlunosView : ContentPage
    {
        public NovosAlunosView()
        {
            InitializeComponent();
        }

        private void btnSalvar_Clicked(object sender, EventArgs e)
        {

            var aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = txtRM.Text,
                Nome = txtNome.Text,
                Email = txtEmail.Text
            };

            ListaAlunoViewModel lAluno = new ListaAlunoViewModel();
            lAluno.Alunos.Add(aluno);

        }
    }
}