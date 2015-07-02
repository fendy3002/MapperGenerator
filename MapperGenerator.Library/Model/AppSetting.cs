using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperGenerator.Library.Model
{
    public class AppSetting
    {
        string profilePath = ".\\profiles";
        public string ProfilePath
        {
            get { return profilePath; }
            set { profilePath = value; }
        }
    }
}
