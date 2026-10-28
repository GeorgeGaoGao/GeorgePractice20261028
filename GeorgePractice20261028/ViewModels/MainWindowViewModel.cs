using Prism.Commands;
using Prism.Mvvm;
using System.Net.Http.Headers;
using System.Threading;

namespace GeorgePractice20261028.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private DelegateCommand _UIStuckCommand;
        public DelegateCommand UIStuckCommand =>
            _UIStuckCommand ?? (_UIStuckCommand = new DelegateCommand(ExecuteUIStuckCommand));

        void ExecuteUIStuckCommand()
        {
            Thread thread = new Thread(Test);
            thread.IsBackground = true;
            thread.Start();
        }

        private static void Test()
        {
            while (true)
            {
                Thread.Sleep(1000);
            }
        }

        public MainWindowViewModel()
        {

        }
    }
}
