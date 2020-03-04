using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
	class BinaryTree
	{
		//variables
		Node root;
		Node newNode;
		
		//ctor
		public BinaryTree()
		{
			root = null;
		}

		public void Add (int userInput)
		{
			Node newNode = new Node();
			newNode.value = userInput;
			if (root == null)
			{
				root = newNode;
			}
			else
			{
				Node node = new Node();
				node = root;
				node = SearchTree(node, userInput);
				if (userInput > node.value)
				{
					node.rightNode = newNode;
				}
				else
				{
					node.leftNode = newNode;
				}
			}
		}
		public Node SearchTree (Node parentNode, int userInput)
		{
			if (userInput > parentNode.value)
			{
				if (parentNode.rightNode != null)
				{
					parentNode = SearchTree(parentNode.rightNode, userInput);
				}
			}
			else
			{
				if (parentNode.leftNode != null)
				{
					SearchTree(parentNode.leftNode, userInput);
				}
			}
			return parentNode;
		}
	}
}
