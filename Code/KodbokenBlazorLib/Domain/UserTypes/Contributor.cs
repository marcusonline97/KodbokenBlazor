using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KodbokenBlazorLib.Enum;

namespace KodbokenBlazorLib.Contributors
{
    public class Contributor
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ProgrammingLang? ProgrammingLang { get; set; }
        public bool HasProfilePic { get; set; } = default!;

    }
}
