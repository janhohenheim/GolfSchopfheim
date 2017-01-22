using System;
using System.Linq;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;

namespace GolfSchopfheim.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private static readonly Random random = new Random();

        public MainWindowViewModel()
        {
            DisplayMessageCommand = new DelegateCommand(OnDisplayMessage);
        }

        #region Properties
        public ICommand DisplayMessageCommand { get; }

        public string Message { get; private set; }
        #endregion

        private void OnDisplayMessage()
        {
            Message = RandomString(random.Next(1, 100));
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}