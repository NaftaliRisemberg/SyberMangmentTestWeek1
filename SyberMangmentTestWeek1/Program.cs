using System;
using System.IO;
using System.Text.Json;
using SyberMangmentTestWeek1;


class Program
{
	static void Main(string[] args)
	{
		string jsonString1 = File.ReadAllText(@"C:\Users\טודוליסט\Desktop\תכנות\project\SyberMangmentTestWeek1\SyberMangmentTestWeek1\Defenses.Json");
		
		List<Node> defenses = JsonSerializer.Deserialize<List<Node>>(jsonString1);
		DefenceStrategiesBST defenceTree = new DefenceStrategiesBST();

		foreach (Node def in defenses)
		{
			defenceTree.Insert(def);
		}

		defenceTree.printPreorder(defenceTree.root);

		string jsonString2 = File.ReadAllText(@"C:\Users\טודוליסט\Desktop\תכנות\project\SyberMangmentTestWeek1\SyberMangmentTestWeek1\Threats.Json");
		List<Threats> thearts = JsonSerializer.Deserialize<List<Threats>>(jsonString2);

		string h= defenceTree.GetTheMatchDefenses(defenceTree.Severity(thearts[0]), defenceTree.root);
		Console.WriteLine(h);
	}
}


