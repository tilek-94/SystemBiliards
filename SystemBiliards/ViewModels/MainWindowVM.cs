using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using SystemBiliards.BusinesLayer;
using SystemBiliards.EntityLayer.Repository;
using SystemBiliards.Infrastructure.Commands;
using SystemBiliards.Models;
using SystemBiliards.Test;
using SystemBiliards.Test.Bisnes;
using SystemBiliards.ViewModels.BaseViewModel;

namespace SystemBiliards.ViewModels
{
    public class MainWindowVM: BaseView
    {
        public ICommand CommandShowStartWindow { get; }
        public ICommand SaveServiceCommand2 { get; }
        private readonly AccountManager _accountManager = new(new EfAccountRepository());
        private readonly TableManager _tableManager = new(new EfTableRepository());
        MainWindow _mainWindow;
        public MainWindowVM(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            CommandShowStartWindow = new RelayCommand(ShowStartWindowCommandExecuted, CanSaveServiceCommandExecute);
            SaveServiceCommand2 = new RelayCommand(SaveServiceCommandExecuted2, CanSaveServiceCommandExecute);
            GetAllProduct();
            Test();
        }
        private Accounts _ClientName;
        public Accounts ClientName
        {
            get { return _ClientName; }
            set { Set(ref _ClientName, value); }

        }
        private List<Accounts> _ClientNameList;
        public List< Accounts> ClientNameList
        {
            get { return _ClientNameList; }
            set { Set(ref _ClientNameList, value); }
        }
        private Tables _Table;
        public Tables Table
        {
            get { return _Table; }
            set { Set(ref _Table, value); }

        }
        private List<Tables> _TableList;
        public List<Tables> TableList
        {
            get { return _TableList; }
            set { Set(ref _TableList, value); }
        }

        private List<CountTimeTable> timerCount;
        public List<CountTimeTable> TimerCount
        {
            get { return timerCount; }
            set { Set(ref timerCount, value); }
        }

        private bool CanSaveServiceCommandExecute(object arg) =>  true;

       private void ShowStartWindowCommandExecuted(object obj)
        {
            int p = (int)obj;
            /* Window1 window1 = new Window1();
             window1.Show();*/
            a = 1;
        }
    
        private async void GetAllProduct()
        {
            await Task.Run(async () =>
            {
                TableList = await _tableManager.GetListAllAsync();


            });
        }
        public void Test()
        {
            Timer t = new Timer(1000);
            t.AutoReset = true;
            t.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            t.Start();
        }
        int a = 0;
        int b = 0;
        private  void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            if (a > 0)
            {
                TimeSpan time = TimeSpan.FromSeconds(a);
                a++;
                /*TimerCount = new List<CountTimeTable>
                {
                    new CountTimeTable{Count=time.ToString(@"hh\:mm\:ss")}
                };*/


                TableList = TableList.Select(x =>
                {
                    x.CountTime = x.Id == 2 ? new CountTimeTable
                    {
                        Count = time.ToString(@"hh\:mm\:ss")
                    } : x.CountTime;

                    return x;
                }).ToList();

            }
           
        }
        private  void SaveServiceCommandExecuted2(object obj)
        {

               /* Window1 window1 = new Window1();
                 window1.ShowDialog();*/
            
            
        }
    }
}
   
