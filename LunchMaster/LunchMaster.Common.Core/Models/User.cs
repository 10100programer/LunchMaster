using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchMaster.Common.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public byte[] Avatar { get; set; }
        public bool IsAdministrator
        {
            get
            {
                if (Id == 0)
                {
                    return true;    //First User Created Will Always have administrator access
                }
                return IsAdministrator;
            }
            set
            {
                IsAdministrator = value;
            }
        }
    }
}
