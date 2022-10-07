using Poseidon.Application.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Application.Dtos
{
    public class SettingsDto : BaseDto
    {
        public string Logo { get; set; }
        public string SocialMediaLinks { get; set; }
    }
}
