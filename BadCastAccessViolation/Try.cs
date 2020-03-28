using System;
using System.Collections.Generic;
using System.Text;

namespace Nysa.Logics
{

    public abstract class Try<T>
    {
        public static explicit operator Try<T>(Func<T> value) => (Pending<T>)value;

        // VS calls this cast redundant, but there is no defined operator (explicit or implicit).
        //public static implicit operator Try<T>(Suspect<T> value) => (Resolved<T>)value;
        // So, if we indulge Visual Studio and take the suggestion to remove the "redundant" cast,
        // this statement leads un-catchable access violation
        public static implicit operator Try<T>(Suspect<T> value) => value;

        public abstract Suspect<T> Run();
    }

}
