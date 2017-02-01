using System;
using System.Security;

namespace GolfSchopfheim.ViewModels
{
    public class PinWindowViewModel
    {
        private readonly SecureString correctPin;
        private readonly Action onCorrect;

        public PinWindowViewModel(SecureString correctPin, Action onCorrect)
        {
            this.correctPin = correctPin;
            this.onCorrect = onCorrect;
        }
    }
}