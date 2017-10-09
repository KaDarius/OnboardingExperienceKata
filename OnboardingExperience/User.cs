using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingExperience
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAccountOwner { get; set; }

        /// <summary>
        /// Should be a secure, 4 digit pin
        /// </summary>
        public string PinNumber { get; set; }
    }
}
