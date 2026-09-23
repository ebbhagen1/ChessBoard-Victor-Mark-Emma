  <div align="right">
  <a href="README.sv.md">🇸🇪 Svenska</a> | <a href="README.md">🇬🇧 English</a>
</div>

# ChessBoard

## Description

**ChessBoard** is a console application written in **C# (.NET 10)**. The program allows the user to choose the size of a chessboard and then prints an **N × N board** with alternating dark and light squares directly in the terminal.

## Requirements

To run the project, you need:

- **.NET 10 SDK** or later
- A terminal, such as PowerShell, Terminal, or Bash
- A code editor, such as Visual Studio Code

## Clone, Build, and Run

Clone the project:

```bash id="wxy31c"
git clone https://github.com/ebbhagen1/ChessBoard-Victor-Mark-Emma.git
```

Navigate to the project directory:

```bash id="t25xcy"
cd ChessBoard-Victor-Mark-Emma/ChessBoard
```

Build the project:

```bash id="j6ck3b"
dotnet build
```

Run the program:

```bash id="1uh3f2"
dotnet run
```

## Usage

When the program starts, the user is asked:

```text id="tkcpz8"
How large would you like the chessboard to be (3–50)?
```

For example, if the user enters `8`, an **8 × 8 chessboard** is created:

```text id="llfd2a"
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎
◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎ ◼︎ ◻︎
```

If the user enters `0`, the program exits. If invalid input is entered, an error message is displayed and the user can try again.

## NuGet Package

The project uses **Spectre.Console** for colors and formatting in the terminal. We chose this package because it makes it easy to create a clear and visually appealing chessboard without having to use ANSI codes directly.

## Code Structure

- **Program.cs** – handles the program flow, user input, and validation using `int.TryParse`.
- **RenderBoard.cs** – is responsible for creating and displaying the chessboard.
- **`RenderBoard(int size)`** – receives the board size and starts rendering the board.
- **`IsDarkSquare(int row, int col)`** – determines whether a square should be dark or light.

## Git Workflow

The project was developed collaboratively in a **GitHub repository** using small, descriptive commits, such as `Add RenderBoard`, `Add NuGet-package`, and `Add IsDarkSquare`.

During development, a **merge conflict** occurred when changes were made to the same file. We resolved the conflict together by reviewing the changes, choosing the correct code, and then creating a new commit.

## Technical Choices

We use `int.TryParse` to check that the user enters a valid integer. The program also checks that the board size is between **3 and 50**.

The chessboard pattern is created using nested `for` loops and the modulo operator `% 2`, allowing the program to alternate between dark and light squares regardless of the board size.

The code is divided between `Program` and `RenderBoard` to separate user interaction from the logic responsible for creating the chessboard. This makes the code clearer and easier to maintain.
