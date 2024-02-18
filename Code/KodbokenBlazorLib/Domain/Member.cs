using KodbokenBlazorLib.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KodbokenBlazor
{
    public class Member
    {
        public int MemberID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } = string.Empty;
        public bool IsPasswordVerified { get; set; }

        public bool EmailVerified { get; set; }

        public UserTypes UserTypes { get; set; }
        public Gender UserGender { get; set; }

        public ProgrammingLang codinglanguage { get; set; }

        public Member():this(int.MaxValue,string.Empty,string.Empty, string.Empty,false,false,UserTypes.InvalidMember,
            Gender.Undefined, ProgrammingLang.UnexistingLang)
        {

        }


        public Member(int memberID,string username, string email,string password, bool ispasswordverified,
            bool emailverified,UserTypes userTypes, Gender gender, ProgrammingLang programmingLang)
        {
            MemberID = memberID;
            UserName = username;
            Email = email;
            Password = password;
            IsPasswordVerified = ispasswordverified;
            EmailVerified = emailverified;
            UserTypes = userTypes;
            UserGender = gender;
            codinglanguage = programmingLang;
        }
    }
}
