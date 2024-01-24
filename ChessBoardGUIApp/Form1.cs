using ChessBoardModel;

namespace ChessBoardGUIApp
{
    public partial class Form1 : Form
    {
        static public Board myBoard = new Board(8);
        public Button[,] btnGrid = new Button[myBoard.Size, myBoard.Size];

        public Form1()
        {
            InitializeComponent();
            populateGrid();
        }

        public void populateGrid()
        {
            // This function will fill the pnlChessBoard control with buttons
            int buttonSize = pnlChessBoard.Width / myBoard.Size; // Calculate the width of each button on the Grid
            pnlChessBoard.Height = pnlChessBoard.Width; // Set the grid to be square

            // Nested loop
            // Create buttons and place then in the Panel
            for (int r = 0; r < myBoard.Size; r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c] = new Button();

                    // Make each button square
                    btnGrid[r, c].Width = buttonSize;
                    btnGrid[r, c].Height = buttonSize;

                    btnGrid[r, c].Click += Grid_Button_Click; // Add the same click event to each button
                    pnlChessBoard.Controls.Add(btnGrid[r, c]); // Place the button on the Panel
                    btnGrid[r, c].Location = new Point(buttonSize * r, buttonSize * c); // Position it in x, y

                    // For testing purposes
                    // Remove Later
                    btnGrid[r, c].Text = r.ToString() + "|" + c.ToString();

                    // The Tag attribute will hold the row and column number in a string
                    btnGrid[r, c].Tag = r.ToString() + "|" + c.ToString();
                }
            }
        }

        private void Grid_Button_Click(object sender, EventArgs e)
        {
            // Get the row and column number of the button just clicked
            string[] strArr = (sender as Button).Tag.ToString().Split('|');
            int r = int.Parse(strArr[0]);
            int c = int.Parse(strArr[1]);

            // Run a helper function to lblDescription all legal moves for this piece
            Cell currentCell = myBoard.theGrid[r, c];
            myBoard.MarkNextLegalMoves(currentCell, "Knight");
            updateButtonLabels();

            // Reset the background color of all the buttons to the default (original) color
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    btnGrid[i, j].BackColor = default(Color);
                }
            }

            // Set the background color of the clicked button to something different
            (sender as Button).BackColor = Color.Cornsilk;
        }

        public void updateButtonLabels()
        {
            for (int r = 0; r < myBoard.Size;  r++)
            {
                for (int c = 0; c < myBoard.Size; c++)
                {
                    btnGrid[r, c].Text = "";
                    if (myBoard.theGrid[r, c].CurrentlyOccupied) btnGrid[r, c].Text = "Knight";
                    if (myBoard.theGrid[r, c].LegalNextMove) btnGrid[r, c].Text = "Legal";
                }
            }
        }

    }
}