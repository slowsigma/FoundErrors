using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nysa.Logics
{

    public static class SuspectExtensions
    {
        public static Suspect<T> Confirmed<T>(this T @this) => new Confirmed<T>(@this);
        public static Suspect<T> Failed<T>(this Exception @this) => new Failed<T>(@this);
    }

}
