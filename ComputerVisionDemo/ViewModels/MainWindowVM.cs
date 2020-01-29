using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerVisionDemo.Models;

namespace ComputerVisionDemo.ViewModels
{
    public class MainWindowVM : BaseVM
    {
        CVSettings _CVSetting;
        public CVSettings CVSetting
        {
            get { return _CVSetting; }
            set { SetProperty(ref _CVSetting, value); }
        }

        public MainWindowVM() : base()
        {
            CVSetting = new CVSettings() {
                ImagePath = "TODO"
            };
        }
    }
}
