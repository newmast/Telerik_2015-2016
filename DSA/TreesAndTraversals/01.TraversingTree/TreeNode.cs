namespace TraversingTree
{
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        public TreeNode(T value)
        {
            this.Value = value;
            this.Children = new List<TreeNode<T>>();
            this.HasParent = false;
        }

        public T Value { get; set; }

        public IList<TreeNode<T>> Children { get; set; }

        public bool HasParent { get; set; }
    }
}