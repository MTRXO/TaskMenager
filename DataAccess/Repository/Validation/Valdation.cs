using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Validation
{
    public class Valdation: IValidation
    {
     
        public bool IsNullOrEmpty(int? value)
        {
            if (value == null)
            {
                return true;
            }
            return false;
        }
    } 
}
