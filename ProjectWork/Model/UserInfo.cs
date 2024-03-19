using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork.Model
{
    public class UserInfo
    {
        public int Id {  get; set; }
        public String Name { get; set; }
        public String BookName {  get; set; }
        public String Faculty {  get; set; }
        public DateTime Returned { get; set; }
    }
}
