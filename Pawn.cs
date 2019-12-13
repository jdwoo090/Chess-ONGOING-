using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTime_
{
    class Pawn : ChessPiece
    {
        public Pawn(color c, ChessSquare s) : base(piece.ePAWN, c, s)
        {
            if (c == color.eWHITE)
            {
                m_image = ChessTime_.Properties.Resources.WhitePawn;
            }
            else
            {
                m_image = ChessTime_.Properties.Resources.BlackPawn;
            }
        }
        public override ChessSquare[] getSquares()
        {
            ChessBoard b = ChessBoard.getBoard();
            return null;
        }
    }
}
