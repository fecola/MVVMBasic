using MVVMBasic.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMBasic.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunoView : ContentPage
    {
        AlunoViewModel vmAluno;

        public AlunoView()
        {
            //var lAlunos = AlunoViewModel.GetAluno();
            
            var aluno = AlunoViewModel.GetAluno();
            vmAluno = new AlunoViewModel(aluno);
            BindingContext = vmAluno;
            InitializeComponent();
        }

    }

}