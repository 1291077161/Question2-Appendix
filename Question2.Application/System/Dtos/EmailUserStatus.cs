using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emmm.Application.System.Dtos
{
    public class EmailUserStatus
    {
        private string normal;
        private string emailLost;
        private string userLost;
        private string platformIdLost;
        private string tokenLost;
        //
        // public EmailUserStatus()
        // {
        // }

        public string Normal { get => normal; set => normal = value; }
        public string EmailLost { get => emailLost; set => emailLost = value; }
        public string UserLost { get => userLost; set => userLost = value; }
        public string PlatformIdLost { get => platformIdLost; set => platformIdLost = value; }
        public string TokenLost { get => tokenLost; set => tokenLost = value; }
    }
}