using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTime_
{
    class Bishop : ChessPiece
    {
        public Bishop(color c, ChessSquare s) : base(piece.eBISHOP, c, s)
        {
            if (c == color.eWHITE)
            {
                m_image = ChessTime_.Properties.Resources.WhiteBishop;
            }
            else
            {
                m_image = ChessTime_.Properties.Resources.BlackBishop;
            }
        }
        public override ChessSquare[] getSquares()
        {
            ChessBoard b = ChessBoard.getBoard();
            return null;
        }
    }
}
