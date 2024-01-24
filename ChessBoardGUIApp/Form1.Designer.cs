namespace ChessBoardGUIApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlChessBoard = new Panel();
            cmbChessPiece = new ComboBox();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.Location = new Point(91, 132);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(600, 600);
            pnlChessBoard.TabIndex = 0;
            // 
            // cmbChessPiece
            // 
            cmbChessPiece.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChessPiece.FormattingEnabled = true;
            cmbChessPiece.Items.AddRange(new object[] { "Bishop", "Queen", "Knight", "King", "Rook" });
            cmbChessPiece.Location = new Point(509, 74);
            cmbChessPiece.Name = "cmbChessPiece";
            cmbChessPiece.Size = new Size(182, 33);
            cmbChessPiece.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(91, 77);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(343, 25);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Select a chess piece to place on the board";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 744);
            Controls.Add(lblDescription);
            Controls.Add(cmbChessPiece);
            Controls.Add(pnlChessBoard);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChessBoard;
        private ComboBox cmbChessPiece;
        private Label lblDescription;
    }
}