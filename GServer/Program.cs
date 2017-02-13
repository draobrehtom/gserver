using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GServer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Root
            TreeNode<string> root = new TreeNode<string>("root");
            {
                // 1
                TreeNode<string> node1 = root.AddChild("node1");
                {
                    // 11
                    TreeNode<string> node11 = node1.AddChild("node11");
                    {
                        TreeNode<string> node111 = node11.AddChild("node111");
                        TreeNode<string> node112 = node11.AddChild("node112");
                    }

                    // 12
                    TreeNode<string> node12 = node1.AddChild("node12");
                    {
                        TreeNode<string> node121 = node12.AddChild("node121");
                        TreeNode<string> node122 = node12.AddChild("node122");
                    }
                }
                // 2
                TreeNode<string> node2 = root.AddChild("node2");
                {
                    // 21
                    TreeNode<string> node21 = node2.AddChild("node21");

                    // 22
                    TreeNode<string> node22 = node1.AddChild("node22");
                    {
                        TreeNode<string> node221 = node22.AddChild("node221");
                        TreeNode<string> node222 = node22.AddChild("node222");
                    }
                }
            }

            Console.WriteLine(root.ElementAt(0));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
