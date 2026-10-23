namespace iterator
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        readonly List<TreeNode<T>> childrenList;
        readonly Array<TreeNode<T>> children;

        public TreeNode(T value)
        {
            Value = value;
            childrenList = [];
            children = new Array<TreeNode<T>>(childrenList);
        }

        public TreeNode<T> AddChild(T value)
        {
            var child = new TreeNode<T>(value);
            childrenList.Add(child);
            return child;
        }

        public IIterator<TreeNode<T>> GetChildIterator()
        {
            return children.GetIterator();
        }
    }
}
