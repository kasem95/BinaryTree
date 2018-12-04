using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree x = new BinaryTree(50);
            x.Add(60);
            x.Add(40);
            x.Add(30);
            x.Add(70);
            x.Add(20);
            x.PrintTree();
            Console.WriteLine(x.Find(50).Value);
        }
    }

    class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Parent { get; set; }

        public TreeNode(int value)
        {
            Value = value;
        }
    }
    class BinaryTree
    {
        TreeNode head;
        
        public BinaryTree(int value)
        {
            head = new TreeNode(value);
        }
        public BinaryTree() : this(50) {}

        public bool IsEmpty()
        {
            if(head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Add(int value)
        {
            
            if(IsEmpty())
            {
                TreeNode newTreeNode = new TreeNode(value);
                head = newTreeNode;
            }
            else
            {
                RecAdd(head, value);
            }
        }

        private void RecAdd(TreeNode temp,int value)
        {
            
            if (temp==null)
            {
                
                return;
            }
            else if(value > temp.Value&& temp.Right!=null)
            {
                RecAdd(temp.Right, value);
            }
            else if(value < temp.Value && temp.Left != null)
            {
                RecAdd(temp.Left, value);
            }
            else if(value > temp.Value && temp.Right == null)
            {
                TreeNode newTreeNode = new TreeNode(value);
                temp.Right = newTreeNode;
                newTreeNode.Parent = temp;
                return;
            }
            else if(value < temp.Value && temp.Left == null)
            {
                TreeNode newTreeNode = new TreeNode(value);
                temp.Left = newTreeNode;
                newTreeNode.Parent = temp;
                return;
            }
        }

        public void PrintTree()
        {
            
            Console.WriteLine("Tree : ");
            if(head == null)
            {
                Console.WriteLine("Null");
            }
            else
            {
                Console.WriteLine(head.Value + " , ");
                for(TreeNode i = head.Right;i!=null;i=i.Right)
                {
                    Console.WriteLine(i.Value + " , ");
                    for(TreeNode j = i, z =i;j!=null&&z!=null;j=j.Right,z=z.Left)
                    {
                        if(j!=i&&z!=i)
                        {
                            Console.WriteLine(z.Value + " , " + j.Value + " , ");
                        }
                    }
                }
                for (TreeNode i = head.Left; i != null; i = i.Left)
                {
                    Console.WriteLine(i.Value + " , ");
                    for (TreeNode j = i, z = i; j != null && z != null; j = j.Right, z = z.Left)
                    {
                        if (j != i && z != i)
                        {
                            Console.WriteLine(z.Value + " , " + j.Value + " , ");
                        }
                    }
                }
                //Print(head);
            }

        }
        private void Print(TreeNode node)
        {
            if(node == head)
            {
                Console.Write("head = "+head.Value +" , ");
                Print(head.Right);
                Print(head.Left);
            }
            else
            {
                Console.Write(node.Value + " , ");
                Print(head.Right);
                Print(head.Left);
            }
        }

        public TreeNode Find(int valueToFind)
        {
            if(head==null)
            {
                return null;
            }
            else if(head.Value == valueToFind)
            {
                return head;
            }
            else
            {
                for(TreeNode i=head;i!=null;)
                {
                    if(valueToFind > i.Value)
                    {
                        i = i.Right;
                    }
                    else if(valueToFind < i.Value)
                    {
                        i = i.Left;
                    }
                    else if(valueToFind == i.Value)
                    {
                        return i;
                    }
                }
                return null;
            }
        }
    }
}
