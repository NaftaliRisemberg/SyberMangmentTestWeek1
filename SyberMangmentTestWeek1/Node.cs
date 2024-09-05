using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyberMangmentTestWeek1
{
	public class Node
	{
		public int MinSeverity {  get; set; }
		public int MaxSeverity { get; set; }
		public Node? Left {  get; set; }
		public Node? Right { get;set; }
		public List<string> Defenses { get; set; }

		public Node(int minSeverity, int maxSeverity, List<string> defenses)
		{
			MinSeverity = minSeverity;
			MaxSeverity = maxSeverity;
			Left = null;
			Right = null;
			Defenses = defenses;
		}
	}
}
