// See https://aka.ms/new-console-template for more information

int size = 4;



char[,] squareBoard = new char[size, size];

for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        // Place 'S' in each position
        squareBoard[row, col] = 'E'; // Empty
    }
}

//Obstruction block:
int blockRow = size - 2;
int blockCol = size - 3;
squareBoard[blockRow, blockCol] = 'O';

//Robot:
int blockRowRobot = 3;
int blockColRobot = 0;
squareBoard[blockRowRobot, blockColRobot] = 'R';

//Winning block:
int blockRowWin = 0;
int blockColWin = 3;
squareBoard[blockRowWin, blockColWin] = 'W';

Console.WriteLine("Square representation:");
for (int row = 0; row < size; row++)
{
    for (int col = 0; col < size; col++)
    {
        Console.Write(squareBoard[row, col] + " ");
    }
    Console.WriteLine();
}




