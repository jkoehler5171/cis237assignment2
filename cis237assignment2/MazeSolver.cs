using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        int xStart;
        int yStart;
        bool mazeSolved = false;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        {}


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            mazeTraversal(xStart, yStart);

            mazeSolved = false;
            //Do work needed to use mazeTraversal recursive call and solve the maze.
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal(int xCord, int yCord)
        {

            if (mazeSolved != true)
            {
                try
                {
                    maze[xCord, yCord] = 'X';
                    PrintMaze();

                    if (maze[xCord - 1, yCord] == '.')
                    {

                        mazeTraversal(xCord - 1, yCord);

                    }
                    if (maze[xCord + 1, yCord] == '.')
                    {

                        mazeTraversal(xCord + 1, yCord);

                    }
                    if (maze[xCord, yCord - 1] == '.')
                    {

                        mazeTraversal(xCord, yCord - 1);
                    }
                    if (maze[xCord, yCord + 1] == '.')
                    {

                        mazeTraversal(xCord, yCord + 1);
                    }
                    else
                    {
                        maze[xCord, yCord] = '0';
                    }

                }
                catch
                {

                    Console.WriteLine("Maze... Solved?");
                    mazeSolved = true;


                }
            }    
            

            
            //Implement maze traversal recursive call
        }

        private void PrintMaze()
        {

            Console.WriteLine();

            for (int rows = 0; rows < maze.GetLength(0); rows++)
            {
                Console.WriteLine();

                for (int columns = 0; columns < maze.GetLength(1); columns++)
                {
                    Console.Write(maze[rows, columns]);
                }
            }

            Console.WriteLine();

        }
    }
}
