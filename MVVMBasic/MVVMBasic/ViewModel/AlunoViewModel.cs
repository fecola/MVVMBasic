using MVVMBasic.Model;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMBasic.ViewModel
{

    public class AlunoViewModel
    {
        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        #endregion

        public Aluno Aluno { get; set; }
        public ICommand FormularioAluno { get; set; }
        public List<Aluno> Alunos { get; set; }

        //public static Aluno GetAluno()
        //{
            
        //    var aluno = new Aluno()
        //    {
        //        Id = Guid.NewGuid(),
        //        RM = "542621",
        //        Nome = "Anderson Silva",
        //        Email = "anderson@ufc.com"
        //    };
        //    return aluno;
        //}

        public AlunoViewModel(List<Aluno> alunos)
        {
            Alunos = alunos;

            FormularioAluno = new Command(() =>
            {
                MessagingCenter.Send(alunos, "FormularioAluno");
            });
        }

    }

}