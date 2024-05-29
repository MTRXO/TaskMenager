using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Validation
{
    public interface IValidation
    {
        bool IsNullOrEmpty(int? value);

    }
}
