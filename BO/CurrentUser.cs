using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// Using this class to find the current user logged-in.
    /// </summary>
    public class CurrentUser
    {
        public static int UserId { get; set; }
        public static string Email { get; set; }         
        public static string Key { get; set; }
    }
}
