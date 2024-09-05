using System;
using System.IO;
using System.Text.Json;
using SyberMangmentTestWeek1;


class Program
{
	static void Main(string[] args)
	{
		string jsonString = File.ReadAllText(@"C:\Users\טודוליסט\Desktop\תכנות\project\SyberMangmentTestWeek1\SyberMangmentTestWeek1\Defenses.Json");
		
		List<Node> defenses = JsonSerializer.Deserialize<List<Node>>(jsonString);
		DefenceStrategiesBST defe = new DefenceStrategiesBST();

		foreach (Node def in defenses)
		{
			DefenceStrategiesBST.Insert(def);
		}
		
	}
}
