using Android.OS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Forms.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private Models.TaskModels _taskModel;
        private string _message;
        public Models.TaskModels TaskModel {
            get { return _taskModel; }
            set
            {

                _taskModel = value;
                OnPropertyChanged();
            }
        }
        
        public string Message 
        {

            get { return _message; }
    set
            {
                _message = value;
                OnPropertyChanged();
}
        }
        public Command SaveCommand {
            get
            {
                return new Command(() =>
                {
                    Message = "Your task : " + _taskModel.Name + " ,"
                    + _taskModel.Surname + " ," + _taskModel.Email + " was successufully saved!";
                });
            }
            }

        

        public HomeViewModel()
        {
            _taskModel = new Models.TaskModels
            {
                Name = "Benson",
                Surname = "Rukantabula",
                Email = "brukantabula@gmail.com"
            };
                }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
