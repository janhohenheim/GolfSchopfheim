using System.Windows.Input;

namespace GolfSchopfheim.Mvvm.Common
{
    public interface IExecutableUnit
    {
        string Text { get; }

        ICommand ExecuteCommand { get; }
    }
}