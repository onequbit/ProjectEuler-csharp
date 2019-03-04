using System;
using System.Collections.Generic;
using System.Text;
using CodeLibrary;

namespace ProjectEuler
{
    public class Problem18 : IPEProblem
    {
        public Problem18()
        {

        }

        public string Answer => _getOutput();

        public void ShowAnswer(object problemSize)
        {
            "*Problem 18*".ToConsole();
            Answer.ToConsole();
        }

        private string _getOutput()
        {
            var tree = new TreeNode(5);
            tree.Left = new TreeNode(4);
            tree.Right = new TreeNode(6);

            return tree.ToString();

            //return this.ToString();
        }        
    }

    public class TreeNode
    {
        public readonly int Value = 0;
        
        public TreeNode(int value)
        {
            Value = value;
        }

        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode AddLeft(TreeNode node)
        {
            Left = node;
            return this;
        }

        public TreeNode AddRight(TreeNode node)
        {
            Right = node;
            return this;
        }

        public override string ToString()
        {
            return $"{this.Value}:{this.Left.Value}, {this.Right.Value}";            
        }

    }
}
