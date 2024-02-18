using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KodbokenBlazorLib.Domain
{
    public class Member
    {
        public int MemberId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } = string.Empty!;
        public bool IsPasswordVerified { get; set; }

        public string EmailVerified { get; set; } = string.Empty!;

        public Gender gender { get; set; }

        public ProgrammingLang programmingLang { get; set; }



    }
}
