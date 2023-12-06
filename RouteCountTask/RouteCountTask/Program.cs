// See https://aka.ms/new-console-template for more information

//BoardSize
int size = 4;
char[,] squareBoard = new char[size, size];

int blockRow = size - 2;
int blockCol = size - 3;
PlaceObstruction(squareBoard, blockRow, blockCol);

DisplayBoard(squareBoard, size);

static void InitializeBoard(char[,] board, int size)
{
    

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            // Place 'E' in each position
            board[row, col] = 'E'; // Empty
        }
    }

}

static void PlaceObstruction(char[,] board, int blockRow, int blockCol)
{
    board[blockRow, blockCol] = 'O';
}


//ASSETS:

//Obstruction block:


//Robot:
int blockRowRobot = 3;
int blockColRobot = 0;
squareBoard[blockRowRobot, blockColRobot] = 'R';

//Winning block:
int blockRowWin = 0;
int blockColWin = size-1;
squareBoard[blockRowWin, blockColWin] = 'W';


//Draw square with assets:

static void DisplayBoard(char[,] board, int size)
{
    Console.WriteLine("Square representation:");
    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            Console.Write(board[row, col] + " ");
        }
        Console.WriteLine();
    }
}






