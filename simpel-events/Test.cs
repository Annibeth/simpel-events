using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_event
{
    class Test // det samme som program.cs
    {
        static void Main()
        {
            Observerable observable = new Observerable();
            Observer observer = new Observer();
            observable.SomethingHappened += observer.HandleEvent;

            observable.DoSomething();

        }
    }
}
