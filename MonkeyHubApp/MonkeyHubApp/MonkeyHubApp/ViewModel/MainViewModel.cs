using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MonkeyHubApp.ViewModel
{
     public class MainViewModel : BaseViewModel
    {

        private string _searchTerm;

        public string SearchTerm
        {
            get { return _searchTerm; }
            set {
                if (SetProperty(ref _searchTerm, value))
                    SearchCommand.ChangeCanExecute();

            }
        }

        
        public ObservableCollection<string> Resultados { get; }






        public Command SearchCommand { get; }

        public MainViewModel()
        {
            SearchCommand = new Command(ExecuteSearchCommand, CanExecuteSearchCommand);
            Resultados = new ObservableCollection<string>(new[] { "abc", "cde" });
        }
        /*CanExecute libera ou nao a execucao do botao de acordo com acondicao*/
        private bool CanExecuteSearchCommand()
        {
            return string.IsNullOrWhiteSpace(SearchTerm)== false;
        }

        async void ExecuteSearchCommand()
        {
            // Debug.WriteLine($"Clicou no botao! {DateTime.Now}");
           // await Task.Delay(2000);
            //await App.Current.MainPage.DisplayAlert("MonkeyHubApp", $"Voce pesquisou por'{SearchTerm}'.", "OK");

            bool resposta = await App.Current.MainPage.DisplayAlert("MonkeyHubApp", $"Voce pesquisou por'{SearchTerm}'?","Sim","Não");
            if (resposta)
            {
                await App.Current.MainPage.DisplayAlert("MonkeyHubApp", "Obrigado", "OK");
                Resultados.Clear();
                for(int i = 1; i <= 30; i++)
                {
                    Resultados.Add($"Sim{i}");
                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("MonkeyHubApp", "De nada", "OK");
                Resultados.Clear();
            }
        }


        /*
             private string _descricao;
             public string Descricao
             { 
                 get {return _descricao;}
                 set { SetProperty(ref _descricao, value);}       
             }

             private string _nome;
             public string Nome
             {
                 get { return _nome; }
                 set {SetProperty(ref _nome, value); }
             }

             private int _idade;
             public int Idade
             {
                 get { return _idade; }
                 set { SetProperty(ref _idade, value); }
             }*/


        /*  public MainViewModel()
          {
             /* Descricao = "Ola mundo! Eu estou aqui!";

              Task.Delay(3000).ContinueWith(t =>
              {
                  Descricao = "Meu texto mudou";

              });
    }*/


    }
}
