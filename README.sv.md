<div align="right">
  <a href="README.sv.md">🇸🇪 Svenska</a> | <a href="README.md">🇬🇧 English</a>
</div>

# ChessBoard

## Beskrivning

**ChessBoard** är en konsolapplikation skriven i **C# (.NET 10)**. Programmet låter användaren välja storleken på ett schackbräde och skriver sedan ut ett **N × N-bräde** med mörka och ljusa rutor direkt i terminalen.

## Krav

För att köra projektet behöver du:

- **.NET 10 SDK** eller senare
- En terminal, exempelvis PowerShell, Terminal eller Bash
- En kodeditor, exempelvis Visual Studio Code

## Klona, bygg och kör

Klona projektet:

```bash
git clone https://github.com/ebbhagen1/ChessBoard-Victor-Mark-Emma.git
```

Gå till projektmappen:

```bash
cd ChessBoard-Victor-Mark-Emma/ChessBoard
```

Bygg projektet:

```bash
dotnet build
```

Kör programmet:

```bash
dotnet run
```

## Användning

När programmet startar får användaren frågan:

```text
Hur stort schackbräde vill du ha (3–50)?
```

Om användaren exempelvis skriver `8` skapas ett **8 × 8-schackbräde**:

```text
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
```

Om användaren skriver `0` avslutas programmet. Vid felaktig input visas ett felmeddelande och användaren får försöka igen.

## NuGet-paket

Projektet använder **Spectre.Console** för färger och formatering i terminalen. Vi valde paketet eftersom det gör det enkelt att skapa ett tydligt och visuellt schackbräde utan att behöva använda ANSI-koder direkt.

## Kodstruktur

- **Program.cs** – hanterar programmets flöde, användarens input och validering med `int.TryParse`.
- **RenderBoard.cs** – ansvarar för att skapa och skriva ut schackbrädet.
- **`RenderBoard(int size)`** – tar emot brädets storlek och startar utritningen.
- **`IsDarkSquare(int row, int col)`** – avgör om en ruta ska vara mörk eller ljus.

## Git-arbete

Projektet har utvecklats gemensamt i ett **GitHub-repository** med mindre och beskrivande commits, exempelvis `Add RenderBoard`, `Add NuGet-package` och `Add IsDarkSquare`.

Under arbetet uppstod en **merge conflict** när ändringar gjordes i samma fil. Vi löste konflikten gemensamt genom att granska ändringarna, välja rätt kod och sedan göra en ny commit.

## Tekniska val

Vi använder `int.TryParse` för att kontrollera att användaren skriver in ett giltigt heltal. Programmet kontrollerar även att storleken är mellan **3 och 50**.

Schackmönstret skapas med nästlade `for`-loopar och modulo-operatorn `% 2`, vilket gör att programmet kan växla mellan mörka och ljusa rutor oavsett brädets storlek.

Koden är uppdelad mellan `Program` och `RenderBoard` för att separera användarinteraktionen från logiken som skapar schackbrädet. Det gör koden tydligare och lättare att underhålla.

📦 NuGet-paket
