using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace Observe.Models
{
    internal interface IObserver
    {
        void Update(ISubject subject);
    }
}
