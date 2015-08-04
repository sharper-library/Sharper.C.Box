namespace Sharper.C.Data.Unsafe
{
    public sealed class MBox<A>
    {
        internal MBox(A a)
        {
            Unbox = a;
        }

        public A Unbox { get; set; }
    }

    public static class MBox
    {
        public static MBox<A> Mk<A>(A a)
            => new MBox<A>(a);
    }
}
