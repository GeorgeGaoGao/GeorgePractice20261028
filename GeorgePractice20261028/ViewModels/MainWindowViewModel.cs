using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

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
            Action action = new Action(Test);
            Task task = new Task(action);
            task.Start();
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
