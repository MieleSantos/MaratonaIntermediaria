using SocialLoginMaratona.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLoginMaratona.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

        public string UserId { get; private set; }
        public string Token { get; private set; }

        public MainViewModel()
        {
            UserId = Settings.UserId;
            Token = Settings.AuthToken;
        }
    }
}
