using System;
using System.Windows.Input;
using GolfSchopfheim.Mvvm.Common;
using Prism.Commands;
using PropertyChanged;

namespace GolfSchopfheim.ViewModels
{
    [ImplementPropertyChanged]
    public class PinInputUnitViewModel : IExecutableUnit
    {
        public PinInputUnitViewModel(string text, Action onExecute)
        {
            Text = text;
            ExecuteCommand = new DelegateCommand(onExecute);
        }

        #region properties
        public string Text { get; }

        public ICommand ExecuteCommand { get; }
        #endregion
    }
}