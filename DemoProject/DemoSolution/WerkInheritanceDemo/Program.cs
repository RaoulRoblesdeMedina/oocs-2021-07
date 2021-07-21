using System;

namespace WerkInheritanceDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var werknemers = new Werknemer[3];

			werknemers[0] = new VasteWerknemer { Name = "JP", MaandLoon = 66666M };
			werknemers[1] = new Freelancer { Name = "Bas Dinges", Uurloon = 94M, WerkurenPerWeek = 32 };
			werknemers[2] = new VasteWerknemer { Name = "John", MaandLoon = 13000M };

			foreach (var werknemer in werknemers)
			{
				// wat voor type werknemer is het
				// hoe wordt het salaris samengesteld (formule)

				// van generiek naar specifiek:
				//if(werknemer is Freelancer)
				//{
				//	var freelancer = (Freelancer)werknemer;
				//	freelancer.
				//}

				werknemer.PrintInfo();

				//Console.WriteLine($"{werknemer.Name} is een {werknemer.Type} verdient {werknemer.CalculateSalary()} euro per maand");
			}
		}
	}
}
