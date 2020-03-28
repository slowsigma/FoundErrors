using System;
using System.Collections.Generic;
using System.Text;

namespace Nysa.Logics
{

    public sealed class Resolved<T> : Try<T>
    {
        private Suspect<T> Value { get; }

        private Resolved(Suspect<T> value) { this.Value = value; }

        public override Suspect<T> Run() => this.Value;
    }

}
