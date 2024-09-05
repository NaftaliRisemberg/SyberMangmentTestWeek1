using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyberMangmentTestWeek1
{
	public class DefenceStrategiesBST
	{
		public int MinSeverity {  get; set; }
		public int MaxSeverity { get; set; }
		public DefenceStrategiesBST? Left {  get; set; }
		public DefenceStrategiesBST? Right { get;set; }
		public List<string> Defenses { get; set; }

		public DefenceStrategiesBST(int minSeverity, int maxSeverity, List<string> defenses)
		{
			MinSeverity = minSeverity;
			MaxSeverity = maxSeverity;
			Left = null;
			Right = null;
			Defenses = defenses;
		}
	}
}
