using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.ViewModels
{
    public class HomeViewModel
    {
        public Models.TaskModels TaskModel { get; set; }

        public HomeViewModel()
        {
            TaskModel = new Models.TaskModels
            {
                Name = "Benson",
                Surname = "Rukantabula",
                Email = "brukantabula@gmail.com"
            };
                }

    }
}
