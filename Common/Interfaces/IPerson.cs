using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Interfaces;

public interface IPerson
{
    int Ssn { get; }
    string FirstName { get; }
    string LastName { get; }
}
