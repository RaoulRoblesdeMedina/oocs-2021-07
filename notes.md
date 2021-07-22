# Notes

## .NET en IDE

.NET development

Integrated Development Environment


Visual Studio
- IDE voor .NET development
- 32 bit
- $$$


Visual Studio Code
- Texteditor
- Gratis en open source
- 64 bit
- C# extension

Rider

## Geschiedenis

.NET 1.0 - 2001
.NET 2
.NET 3    - WPF WF WCF LINQ
.NET 3.5
.NET 4
.NET 4.7

.NET Core 1
          2
          3


volgende versie na .NET Core 3 == .NET 5

"backwards compatibility"

"deprecate"

## Binair rekenen

integer data types in C#

1    0    0    0  0  0  0  0  = -128
0    1    0    0  1  0  1  0
p/n  64  32   16  8  4  2  1


2^8 = 256 / 2 = -128 - 127
2^16 = 65536 / 2 = -32700 - 32700
2^32 = 4.294.000.000 / 2 = 2.147.000.000
2^64 = veel

// integer  (gehele getallen)
byte	8 bit    01001010 => 74
short	16 bit
int	32 bit
long	64 bit

// floating point (kommagetallen)  precisie
float		32 bit
double		64 bit
decimal		128 bit  (RAM-geheugen maar ook op harde schijf)

milleniumbug

// banken o.a.

980305
980305
980305
980305
000102

7GB - 2TB

### Bitwise operators
& // bitwise AND

00110101
01010100
=========
00010100

enumeratie flags


&& // conditional logical AND // 99,99% gevallen

if(4 > 8 && 12 < 18)


## Lijsten

List<>
array
LinkedList

list records
gerelateerde records


## Prioriteiten bij code schrijven

Waar JP op let bij het schrijven van code:

1. Leesbaarheid
2. Onderhoudbaarheid (best practices)
3. Testbaarheid  (unittesten)
4. Veiligheid (hackbaarheid)
5. Dat het werkt (functioneel en niet-functioneel)
6. Performance


veiligheid (voor webapplicaties):

- SQL injection
- XSS
- XSRF
- social engineering
- Open Web Application Security Project - best practices

OWASP Top 10

## Types in C#

primitive types

int   0
short 0
byte  0
char  ''
bool  false

reference types

string    null
ALLE classes  null

## Piramideprogrammeren

```cs
for()
{
	if()
	{
		for()
		{
			while()
			{
				if()
				{
				}
			}
		}
	}
}
```

Verplaats geneste for/while/if's naar losse methoden voor betere leesbaarheid.

## Java vs C#

```java
String x = "hoi";
x = x + "q";

if (x == "hoiq") // In java: false
{

}

if ("hoi".equals(x)) {

}
if ("hoi".compareTo(x) == 0) {

}
```

## Object Orientation

Wat is een class eigenlijk?

- Collectie van code
  - Methoden
  - Velden
  - Properties
- Container
- Blauwdruk
- Lopende bank

Voorbeelden van class (zie tekeningetjes)

### Noun-phrase identification

Als eindgebruiker wil ik graag flessen kunnen inleveren bij een statiegeldautomaat.

Actor eindgebruiker

- Fles
  - Inlever()
  inleveren  (methode)
- Statiegeldautomaat
  - Inlever()

### Opbouw class

```cs
// hoe een class over het algemeen wordt opgebouwd:

class NaamVanDieClass
{
	// eigenschappen: velden/properties

	// constructor(s)

	// static methoden

	// methoden
}
```

### Pilars of OO

4 pilaren van object-orientatie

1. Encapsulatie: afbakening
2. Abstractie: vriendin.MaakOntbijt();
3. Polymorphisme - interfaces/overerving - kanarie kan zowel een dier zijn als een kanarie - unittesten
4. Overerving/inheritance - pratende dieren en rekeningen met korting


Bird vogel - Animal

static

Cow / IAnimal / Object

### Interfaces

- applicatie die je bouwt om twee systemen met elkaar te laten communiceren. => interfaces
- blauwdruk van een class? nee.

API => Application Programming Interface

menselijke wereld:
- stopcontact
  => 230V  1.6A

technisch:
- kille, kouding scheiding tussen implementaties
- beschrijft wat iets is/heeft/kan
- 1 grote abstracte class - ALLES abstract is

interface:
- properties { get; set; }
- methoden


interface vs abstract class??
=> zodra je code wil sharen tussen implementaties: abstract class
=> kille koude scheiding zodat implementaties niks met elkaar te maken hebben: interface

OOP interface om je API mee te realiseren
- Extensies/Plugins


Java... 10? 9? "default implementations" op interfaces

C# 8 nu ook default implementations

### static

static is niet gebonden aan een instantie

het is overkoepelend

static dingen roep je altijd aan op de class, niet op de instance

## Aantallen

3 categorieen aan classes:

1. Al je eigen classes
   => zo betrouwbaar als dat je jezelf, je collega's en je organisatie vertrouwt
   => hoe belangrijk wordt kwaliteit geacht binnen je organisatie
   => jij kent de cultuur van je organisatie beter dan anderen buiten je organisatie
   => 30% praat ik tegen mijn classes, 70% tegen de rest    (weer hele ruwe schatting)


2. Alles wat mee wordt geleverd met het framework  (eigenlijk ook third-party)
   => behoorlijk betrouwbaar
   => goed geoptimaliseerd
   => 30.000  (hele ruwe schatting)

3. Third-party (wat anderen maken)
   => betrouwbaarheid?
   => hoe actief wordt het onderhouden?
   => hoeveel mensen gebruiken het?
   => wie zit erachter?
   => betaal je ervoor? garanties in je SLA? is het open-source?
   => ... berekening, charting library, servicebus, json serializer
   => gemiddeld paar honderd (ruim genomen)



