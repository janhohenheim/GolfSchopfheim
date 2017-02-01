using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using PropertyChanged;

namespace GolfSchopfheim.ViewModels
{
    [ImplementPropertyChanged]
    public class MainWindowViewModel : BindableBase
    {
        private static readonly Random random = new Random();

        public MainWindowViewModel()
        {
            StartGolfCommand = new DelegateCommand(OnStartGolf);
            ReturnToOsCommand = new DelegateCommand(OnReturnToOs);
        }

        #region Properties
        public ICommand StartGolfCommand { get; }

        public ICommand ReturnToOsCommand { get; }

        public string Status { get; private set; } = "Ready";

        public InteractionRequest<INotification>
        #endregion

        private void OnStartGolf()
        {
            Status = "Golf started";
            Process.Start(@"calc.exe");
        }

        private async void OnReturnToOs()
        {
            Status = "Bye bye :)";
            await Task.Delay(1000);
            Application.Current.MainWindow.Close();
        }
        
    }
}