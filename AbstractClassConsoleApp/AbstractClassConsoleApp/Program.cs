using System;
using AbstractClassConsoleApp.Model;

namespace AbstractClassConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //by default this is a HomepageViewModel because of our constructor
            Console.WriteLine(WindowSingleton.Instance.CurrentViewModel.GetType());
            //we can change the current view model to any class that extends the BaseViewModel abstract class
            WindowSingleton.Instance.CurrentViewModel = new SupportPageViewModel();
            Console.WriteLine(WindowSingleton.Instance.CurrentViewModel.GetType());
        }
    }
}