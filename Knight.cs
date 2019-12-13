using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTime_
{
    class Knight : ChessPiece
    {
        public Knight(color c, ChessSquare s) : base(piece.eKNIGHT, c, s)
        {
            if (c == color.eWHITE)
            {
                m_image = ChessTime_.Properties.Resources.WhiteKnight;
            }
            else
            {
                m_image = ChessTime_.Properties.Resources.BlackKnight;
            }
        }
        public override ChessSquare[] getSquares()
        {
            ChessBoard b = ChessBoard.getBoard();

            //public ChessSquare s;

            return null;
        }
    }
}
