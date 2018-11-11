using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string elementAsString = "A 2 ^ 2 A * B * - B 2 ^ + A B - / 2 ^";
            string[] elements = elementAsString.Split(' ');

            Stack<Node> stack = new Stack<Node>();

            foreach (string element in elements)
            {
                if (IsOperator(element))
                {
                    Node rightOperand = stack.Pop();
                    Node leftOperand = stack.Pop();
                    stack.Push(new Node(element, leftOperand, rightOperand));
                }
                else {
                    Node n = new Node(element);
                    stack.Push(n);
                }
            }
        }
       

        private static bool IsOperator(string element)
        {
            switch (element)
            {
                case "*":
                case "/":
                case "^":
                case "+":
                case "-":
                    return true;

                default:
                    return false;
            }
        }
    }
}
