using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVETrader.Web2.Models
{
    public class ApplicationUser : IdentityUser
    {
		public string CharacterID { get; set; }
		public string CharacterName { get; set; }
	}
}
