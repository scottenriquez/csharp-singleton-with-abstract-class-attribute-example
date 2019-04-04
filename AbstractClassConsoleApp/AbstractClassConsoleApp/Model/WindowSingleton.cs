namespace AbstractClassConsoleApp.Model
{
    public sealed class WindowSingleton
    {
        private static WindowSingleton _instance = null;
        private static readonly object Padlock = new object();

        public BaseViewModel CurrentViewModel { get; set; }

        private WindowSingleton()
        {
            //default to the homepage
            CurrentViewModel = new HomePageViewModel();
        }

        public static WindowSingleton Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ?? (_instance = new WindowSingleton());
                }
            }
        }
    }
}