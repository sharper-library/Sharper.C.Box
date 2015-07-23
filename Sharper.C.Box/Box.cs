namespace Sharper.C
{
    public sealed class Box<A>
    {
        internal Box(A a)
        {
            Unbox = a;
        }

        public A Unbox { get; }

        public bool Equals(Box<A> ba)
            => ReferenceEquals(this, ba) || Unbox.Equals(ba.Unbox);

        public override bool Equals(object o)
            => !ReferenceEquals(null, o)
                && o is Box<A>
                && Equals((Box<A>) o);

        public override int GetHashCode()
        {
            return Unbox.GetHashCode();
        }

        public override string ToString() => $"{nameof(Box<A>)}({Unbox})";
    }

    public static class Box
    {
        public static Box<A> Mk<A>(A a)
            where A : struct
            => new Box<A>(a);
    }
}
