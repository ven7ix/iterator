namespace iterator
{
    public class Program
    {
        public static void Main()
        {
            //var array = new Array<int>([6, 7, 5, 2, 4, 0]);
            //IIterator<int> array_it = array.GetIterator();
            //int i = 0;
            //for (array_it.Reset(), array_it.Next(); !array_it.IsDone(); array_it.Next(), i++)
            //{
            //    Console.WriteLine(array_it.GetCurrent());
            //    if (i == 3)
            //    {
            //        array_it.RemoveAt(3);
            //    }
            //}
            //Console.WriteLine();

            //for (array_it.Reset(), array_it.Next(); !array_it.IsDone(); array_it.Next())
            //{
            //    Console.WriteLine(array_it.GetCurrent());
            //}
            //Console.WriteLine();


            var tree = new Tree<int>(6);

            TreeNode<int> child_0 = tree.Root.AddChild(2);

            TreeNode<int> child_0_0 = child_0.AddChild(6);
            TreeNode<int> child_0_1 = child_0.AddChild(7);

            TreeNode<int> child_0_1_0 = child_0_1.AddChild(19);

            TreeNode<int> child_1 = tree.Root.AddChild(4);

            TreeNode<int> child_1_0 = child_1.AddChild(0);
            TreeNode<int> child_1_1 = child_1.AddChild(3);

            IIterator<int> tree_it = tree.GetIterator();
            for (tree_it.Reset(), tree_it.Next(); !tree_it.IsDone(); tree_it.Next())
            {
                Console.WriteLine(tree_it.GetCurrent());
            }
        }
    }
}
