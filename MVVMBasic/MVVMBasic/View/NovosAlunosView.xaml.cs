using MVVMBasic.Model;
using MVVMBasic.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMBasic.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NovosAlunosView : INotifyPropertyChanged
    {
        public ListaAlunoViewModel lNovoAluno { get; set; }

        public NovosAlunosView(List<Aluno> alunos, Aluno aluno)
        {
            InitializeComponent();
            lNovoAluno = new ListaAlunoViewModel(alunos, aluno);
            BindingContext = lNovoAluno;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<List<Aluno>>(this, "CadastrarAluno",
                async (alunos) =>
                {
                    await DisplayAlert("Sucesso", "Aluno cadastrado com sucesso", "Ok");
                    await Navigation.PushAsync(new AlunoView(alunos));
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<List<Aluno>>(this, "CadastrarAluno");
        }
        
    }

}