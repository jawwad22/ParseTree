using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParseTree
{
    class Node
    {
        public string Value;
        public Node Left;
        public Node Right;
        public Node(string value)
        {
            this.Value = value;
        }
        public Node(string value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
