using GolfSchopfheim.ViewModels;
using Prism.Interactivity.InteractionRequest;

namespace GolfSchopfheim.Mvvm.Interactions
{
    public class PinRequestNotification : INotification
    {
        public PinRequestNotification(string title, PinWindowViewModel content)
        {
            Title = title;
            Content = content;
        }

        public string Title { get; set; }

        public PinWindowViewModel Content { get; set; }

        object INotification.Content
        {
            get { return Content; }
            set { Content = (PinWindowViewModel)value; }
        }
    }
}