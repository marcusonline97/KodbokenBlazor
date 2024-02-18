using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodbokenBlazorLib.Contributors
{
    public class Contributor
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string ProgramLang { get; set; } = string.Empty;

        public bool HasProfilePic { get; set; } = default!;

    }
}
