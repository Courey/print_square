using System;

public class Square
{
   private char[,] asterixBlock;
   private const int ROWS = 10;
   private const int COLS = 10;

   public Square()
   {
      asterixBlock = new char[ROWS, COLS] { {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} ,
                                              {' ',' ',' ',' ',' ',' ',' ',' ',' ',' '} };
   }

   public void makeBox()
   { 
       for (int r = 0; r < ROWS; r++) //loop for each row
      {
         for (int c = 0; c < COLS; c++) //loop for each column
         {
            if (r == 1)
            {
               asterixBlock[r, c] = '*';
            }

            if (r == 9)
            {
               asterixBlock[r, c] = '*';
            }

            if (r >=2 && r<=8)
            {
               asterixBlock[r, 0] = '*';
               asterixBlock[r, 9] = '*';
            }
         }
          //end of row, add new line
      }
   }  
    // It uses the 2 dimensional array asterixBlock   
   public void displayBox()
   {
      for (int r = 0; r < ROWS; r++) //loop for each row
      {
         for (int c = 0; c < COLS; c++) //loop for each column
         {
            Console.Write(asterixBlock[r,c]);
         }
         Console.WriteLine(); //end of row, add new line
      }
   } //end of displayBox
}

public class BoxTest
{
   public static void Main(string[] args)
   {
      Square Box1 = new Square();

      Box1.makeBox();
      Box1.displayBox();
      Console.ReadLine();
   }
}

/*
 ****prints following:*****

**********
*        *
*        *
*        *
*        *
*        *
*        *
*        *
**********

*/
