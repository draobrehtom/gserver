using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GServer
{
    class Tree
    {
        public bool isInitialized = false;
        private string firstChoice;
        private string secondChoice;
        private Server server;
        private Tree parrent;
        public string question;
        public int choice;
        TreeNode<string> root;





    public Tree (Server server, string firstChoice, string secondChoice)
        {
            this.isInitialized = true;
            this.firstChoice = firstChoice;
            this.secondChoice = secondChoice;
            this.server = server;
            this.choice = 0;
        }

        public TreeNode<string> makeChoice(string choice, TreeNode<string> node)
        {
            choice = Regex.Replace(choice, @"\r\n?|\n", "");
            if (choice == firstChoice)
            {
                return node.ElementAt(0);
            }
            else if (choice == secondChoice)
            {
                return node.ElementAt(1);
            } 
            else
            {
                return node;
            }
        }

        public void nextQuestion(string choice)
        {
            if (choice == firstChoice)
            {

            }
        }

    }
}
