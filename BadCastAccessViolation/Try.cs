using System;
using System.Collections.Generic;
using System.Text;

namespace Nysa.Logics
{

    public abstract class Try<T>
    {
        public static explicit operator Try<T>(Func<T> value) => (Pending<T>)value;

        // This should be an invalid cast but is not. Visual studio says the cast is redundant.
        //public static implicit operator Try<T>(Suspect<T> value) => (Resolved<T>)value;

        // When we take the suggestion and remove "redundant" cast, leads un-catchable access violation
        public static implicit operator Try<T>(Suspect<T> value) => value;

        public abstract Suspect<T> Run();
    }

}
