using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyberMangmentTestWeek1
{
	public class DefenceStrategiesBST
	{
		public Node root { get; set; }

		public DefenceStrategiesBST()
		{
			root = null;
		}

		public void Insert(Node value)
		{
			root = InsertRecursive(root, value);
		}
		
		public Node InsertRecursive(Node node, Node value)
		{
			if (node == null)
			{
				node = new Node(value.MinSeverity, value.MaxSeverity, value.Defenses);
				return node;
			}
			if (node.MinSeverity > value.MinSeverity)
			{
				node.Left = InsertRecursive(node.Left, value);
			}
			if (node.MaxSeverity < value.MaxSeverity)
			{
				node.Right = InsertRecursive(node.Right, value);
			}
			return node;
		}

		public void printPreorder(Node root)
		{
			string result = "";
			if (root == null)
				return;

			// Deal with the node
			Console.Write("(" + root.MinSeverity + " " + root.MaxSeverity + "),");

			// Recur on left subtree
			printPreorder(root.Left);

			// Recur on right subtree
			printPreorder(root.Right);
		}

		public int Severity(Threats threats)
		{
			int TargetValue = GetTypeInInt(threats);
			int severity = (threats.Volume * threats.Sophistication) + TargetValue;
			return severity;
		}

		private int GetTypeInInt(Threats threats)
		{
			Dictionary<string, int> result = new Dictionary<string, int>();
			result.Add("Web Server", 10);
			result.Add("Database", 15);
			result.Add("User Credentials", 20);

			if (result.ContainsKey(threats.ThreatType))
			{
				return result[threats.ThreatType];
			}
			return 5;
		}



	}
}
