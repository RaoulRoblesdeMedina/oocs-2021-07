using System;

namespace DemoProject.OO
{
	class ProgramOO
	{
		static void MainOO(string[] args)
		{
			var jp = new Human(); // instantie
			jp.aantalOgen = 2;
			jp.haarkleur = "Blond";
			jp.Speak();

			var raoul = new Human();
			raoul.haarkleur = "Zwart";
			raoul.Speak();

			var robin = new Human();


			// calc 1

			var calc = new Calculator();
			var addResult = calc.Add(4, 8);
			var multiplyResult = calc.Multiply(addResult, 3);
			var divideResult = calc.Divide(multiplyResult, 2);
			var subtractResult = calc.Subtract(divideResult, 20);
			Console.WriteLine("zonder state = " + subtractResult);


			var calcMetState = new CalculatorMetState();
			calcMetState.Add(4);
			calcMetState.Add(8);
			calcMetState.Multiply(3);
			calcMetState.Divide(2);
			calcMetState.Subtract(20);
			Console.WriteLine("met state = " + calcMetState.result);


		}
	}
}
