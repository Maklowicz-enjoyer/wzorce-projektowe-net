namespace CompositeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = PrepareTree();
        }
        public Composite PrepareTree()
        {
            var root = new Composite("root");

            var c1a = new Composite("Level 1 A");
            var c1b = new Composite("Level 1 B");

            var c2a = new Composite("Level 2 A");
            var c2b = new Composite("Level 2 B");

            var c3a = new Composite("Level 3 A");
            var c3b = new Composite("Level 3 B");
            var c3a2 = new Composite("Level 3 A2");
            var c3b2 = new Composite("Level 3 B2");

            var l1 = new Leaf("Leaf 1");
            var l2 = new Leaf("Leaf 2");

            var l3 = new Leaf("Leaf 3");
            var l4 = new Leaf("Leaf 4");

            root.Add(c1a);
            root.Add(c2b);

            c1a.Add(c2a);
            c1b.Add(c2b);

            c2a.Add(c3a);
            c2b.Add(c3b);
            c2a.Add(c3a2);
            c2b.Add(c3b2);

            c1a.Add(l1);
            c2a.Add(l2);
            c3b.Add(l3);
            c3a2.Add(l4);

            return root;
        }
    }
}
