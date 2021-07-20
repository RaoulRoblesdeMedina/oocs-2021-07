# Aanpakken oefeningen

Gegeven een string, tel hoe vaak de letter "x" erin voorkomt.

TelX("yy,,xx.ekid.xxx") // 5
TelX("xx..x.x..x.x") // 6

static void TelX(string text)
{
	...
}

==================================

Bepaal of een string in het midden van een andere string ligt.

IsInMidden("aaabaaa", "b"); // true
IsInMidden("aaabaa", "b"); // false
IsInMidden("aabaa", "b"); // true
IsInMidden("aba", "b"); // true
IsInMidden("abbba", "bbb"); // true
IsInMidden("aabbbaa", "bbb"); // true
IsInMidden("aaaaaaaaaaaaaaaaaaaabbbaa", "bbb"); // false


IsInMidden("aabbaa", "bb"); // true

static void IsInMidden(string fullString, string middle)
{
	...
}

1. Aantal karakters tellen van de fullString = 6
2. Aantal karakters tellen van de middle = 2
3. # fullString / 2 = 3
4. # middle / 2 = 1

5. #3 - #5 = 3 - 1 = 2
6. fullString hapje eruit nemen => .Substring(#5, # middle)
7. hapje == middle


## Star out

1. Creeer een stringvariabele voor het resultaat zonder sterretjes
2. Loop door karakters van string, hou een index bij
3. Kijk of karakter op index + 1 een * is
   => false
      a. voeg het huidige karakter toe aan resultaatvariabele
      b. hoog de index op met 1
   => true
      a. bepaal de index van het eerste niet-ster karakter
      b. stel de index in op die index + 1
   hou rekening met lengte van string



RAM

"wed"

## Sleep in

Maak een console-applicatie met een methode SleepIn:

static  void Main(string[] args)
{
	SleepIn(true, true);
	SleepIn(false, true);
	SleepIn(false, false);
	SleepIn(true, false);	
}


static void SleepIn(bool isWeekday, bool isVacation)
{
	...
}

========================

Gegeven een getal n, print true als de waarde maximaal 10 meer of minder is dan 100 of 200.

BijnaHonderdOfTweehonderd(93); // true
BijnaHonderdOfTweehonderd(104); // true
BijnaHonderdOfTweehonderd(84); // false
BijnaHonderdOfTweehonderd(205); // true
BijnaHonderdOfTweehonderd(-103); // false

================

Gegeven een array van getallen, print hoe vaak het getal 9 voorkomt

var getallen1 = new int[] { 4, 8, 9, 2, 9, 1 };
var getallen2 = new int[] { 99, 9, 2, 9, 1 };

Tel9(getallen1); // 2
Tel9(getallen2); // 2





voor VS Code:

1. File > Open Folder (kies je projectfolder);
2. Open terminal
3. dotnet new console
4. dotnet run
5. Installeer extensie "C#" van Microsoft