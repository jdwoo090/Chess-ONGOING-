using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessTime_
{
    public partial class chessForm : Form
    {
        ChessBoard b = new ChessBoard();
        public chessForm()
        {
            InitializeComponent();
        }

        private void drawBoard()
        {
            pictureBox58.Image = b.getSquare(4, 4).GetChessPiece().m_image;
        }

        private void chessForm_Load(object sender, EventArgs e)
        {
            King k = new King(color.eBLACK, b.getSquare(4, 4));
            drawBoard();
        }
    }
}
