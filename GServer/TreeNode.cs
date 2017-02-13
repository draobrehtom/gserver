using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GServer
{
    public class TreeNode<T> : IEnumerable<TreeNode<T>>
    {

        public T Data { get; set; }
        public TreeNode<T> Parent { get; set; }
        public ICollection<TreeNode<T>> Children { get; set; }

        public TreeNode(T data)
        {
            this.Data = data;
            this.Children = new LinkedList<TreeNode<T>>();
        }

        public TreeNode<T> AddChild(T child)
        {
            TreeNode<T> childNode = new TreeNode<T>(child) { Parent = this };
            this.Children.Add(childNode);
            return childNode;
        }

        public IEnumerator<TreeNode<T>> GetEnumerator()
        {
            return Children.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Children.GetEnumerator();
        }
    }
}
