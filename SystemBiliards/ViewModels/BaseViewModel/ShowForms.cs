using System.Windows.Controls;

namespace SystemBiliards.ViewModels.BaseViewModel
{
    public class ShowForms
    {
        public static void Show(Frame frame, Page page)
        {
            frame.Content = null;
            frame.NavigationService.RemoveBackEntry();
            frame.Navigate(page);
        }
    }
}
