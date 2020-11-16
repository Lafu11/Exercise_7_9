using System;
// calculates the average of a set of marks, until the user types “end”.
public class Average{
	public static void Main(){
		double n1 = 0, n2, count = 0, average;
		string CheckEnd;
		Console.Write("Insert a mark: ");
		CheckEnd = Console.ReadLine();
		while(CheckEnd != "end"){
			n2 = Convert.ToDouble(CheckEnd);
			count++;
			n1 += n2;
			Console.Write("Insert a mark: ");
			CheckEnd = Console.ReadLine();
		}
		if(count != 0){
			average = n1 / count;
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
