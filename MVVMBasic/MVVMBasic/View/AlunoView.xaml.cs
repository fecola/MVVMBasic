using MVVMBasic.Model;
using MVVMBasic.ViewModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMBasic.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunoView : ContentPage
    {
        private AlunoViewModel vmAluno { get; set; }

        public AlunoView(List<Aluno> alunos)
        {
            vmAluno = new AlunoViewModel(alunos);
            BindingContext = vmAluno;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<List<Aluno>>(this, "FormularioAluno",
                async (alunos) =>
                {
                    var aluno = new Aluno();
                    await Navigation.PushAsync(new NovosAlunosView(alunos, aluno));
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<Aluno>(this, "FormularioAluno");
        }

    }

}