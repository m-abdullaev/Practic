using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practic.Repos
{
    interface IReadAllFromDB<T>
    {
        List<T> ReadAll();

    }
}
