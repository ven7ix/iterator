namespace iterator
{
    internal class Tree<T>(T root_value) : IIterable<T>
    {
        public TreeNode<T> Root { get; private set; } = new(root_value);

        public IIterator<T> GetIterator()
        {
            return new TreeIterator(this);
        }

        class TreeIterator(Tree<T> owner) : IIterator<T>
        {
            readonly Tree<T> owner = owner;
            readonly Stack<TreeNode<T>> path = [];
            bool started = false;

            public T GetCurrent()
            {
                return path.Peek().Value;
            }

            public bool IsDone()
            {
                return !(path.Count > 0);
            }
            public void Reset()
            {
                path.Clear();
            }

            public void Next()
            {
                if (!started)
                {
                    started = true;
                    path.Push(owner.Root);
                    return;
                }

                if (IsDone())
                {
                    return;
                }

                TreeNode<T> node = path.Pop();

                var children = new List<TreeNode<T>>();
                var it = node.GetChildIterator();
                for (it.Reset(), it.Next(); !it.IsDone(); it.Next())
                {
                    children.Add(it.GetCurrent());
                }

                for (int i = 0; i < children.Count; i++)
                {
                    path.Push(children[i]);
                }
            }

            public void RemoveAt(int index)
            {
            }
        }
    }
}
