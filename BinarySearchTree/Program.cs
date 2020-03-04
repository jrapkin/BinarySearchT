using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();
			BinaryTree newSearchTree = new BinaryTree();

			for (int i = 0; i < 500; i++)
			{
				newSearchTree.Add(random.Next());
			}
			newSearchTree.Add(10);
			newSearchTree.Add(20);
			newSearchTree.Add(30);
			newSearchTree.Add(8);
			newSearchTree.Add(5);
			newSearchTree.Add(2);
		}
	}
}
