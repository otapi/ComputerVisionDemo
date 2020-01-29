using ComputerVisionDemo.Helpers;
using ComputerVisionDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerVisionDemo.Models
{
    public class CVSettings : BaseVM
    {
        string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { SetProperty(ref _ImagePath, value); }
        }
    }
}
