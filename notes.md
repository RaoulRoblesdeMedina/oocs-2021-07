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