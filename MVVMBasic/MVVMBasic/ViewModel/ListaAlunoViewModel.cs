﻿using MVVMBasic.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMBasic.ViewModel
{
    public class ListaAlunoViewModel : ContentPage
    {

        public Aluno Aluno { get; set; }
        public ICommand CadastrarAluno { get; set; }

        public ListaAlunoViewModel(List<Aluno> alunos, Aluno aluno)
        {
            Aluno = aluno;

            CadastrarAluno = new Command(() =>
            {
                alunos.Add(Aluno);
                MessagingCenter.Send(alunos, "CadastrarAluno");
            });
        }

        public string Nome
        {
            get
            {
                return Aluno.Nome;
            }
            set
            {
                Aluno.Nome = value;
                OnPropertyChanged();
                ((Command)CadastrarAluno).ChangeCanExecute();
            }
        }

        public string RM
        {
            get
            {
                return Aluno.RM;
            }
            set
            {
                Aluno.RM = value;
                OnPropertyChanged();
                ((Command)CadastrarAluno).ChangeCanExecute();
            }
        }

        public string Email
        {
            get
            {
                return Aluno.Email;
            }
            set
            {
                Aluno.Email = value;
                OnPropertyChanged();
                ((Command)CadastrarAluno).ChangeCanExecute();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}