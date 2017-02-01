using System.Windows;
using System.Windows.Interactivity;
using GolfSchopfheim.Mvvm.Interactions;
using GolfSchopfheim.ViewModels;
using GolfSchopfheim.Views;
using Prism.Interactivity.InteractionRequest;

namespace GolfSchopfheim.Mvvm.WindowActions
{
    public class PinWindowAction : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            var args = (InteractionRequestedEventArgs)parameter;
            var notification = (PinRequestNotification)args.Context;
            var viewModel = notification.Content;
            var window = new PinWindow() { DataContext = viewModel };
            window.ShowDialog();
        }
    }
}