using System;
using System.Diagnostics;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using GolfSchopfheim.Mvvm.Interactions;
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
            PinInteractionRequest = new InteractionRequest<PinRequestNotification>();
            StartGolfCommand = new DelegateCommand(OnStartGolf);
            ReturnToOsCommand = new DelegateCommand(OnReturnToOs);
        }

        #region Properties
        public ICommand StartGolfCommand { get; }

        public ICommand ReturnToOsCommand { get; }

        public string Status { get; private set; } = "Ready";

        public InteractionRequest<PinRequestNotification> PinInteractionRequest { get; }
        #endregion

        private void OnStartGolf()
        {
            Status = "Golf started";
            Process.Start(@"calc.exe");
        }

        private async void OnReturnToOs()
        {
            Status = "Awaiting PIN input";
            await PinInteractionRequest.RaiseAsync(new PinRequestNotification(
                "Please enter your PIN Code",
                new PinWindowViewModel(new SecureString(), () => Application.Current.MainWindow.Close() )
                ));
        }

    }
}