using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTime_
{
    class Rook : ChessPiece
    {
        public Rook(color c, ChessSquare s) : base(piece.eROOK, c, s)
        {
            if (c == color.eWHITE)
            {
                m_image = ChessTime_.Properties.Resources.WhiteRook;
            }
            else
            {
                m_image = ChessTime_.Properties.Resources.BlackRook;
            }
        }
        public override ChessSquare[] getSquares()
        {
            ChessBoard b = ChessBoard.getBoard();
            return null;
        }
    }
}
