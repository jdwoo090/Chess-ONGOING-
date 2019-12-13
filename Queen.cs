using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTime_
{
    class Queen : ChessPiece
    {
        public Queen(color c, ChessSquare s) : base(piece.eQUEEN, c, s)
        {
            if (c == color.eWHITE)
            {
                m_image = ChessTime_.Properties.Resources.WhiteQueen;
            }
            else
            {
                m_image = ChessTime_.Properties.Resources.BlackQueen;
            }
        }
        public override ChessSquare[] getSquares()
        {
            ChessBoard b = ChessBoard.getBoard();
            return null;
        }
    }
}
