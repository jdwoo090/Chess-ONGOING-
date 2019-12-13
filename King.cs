using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTime_
{
    class King : ChessPiece
    {
        public King(color c, ChessSquare s) : base(piece.eKING, c, s)
        {
            if (c == color.eWHITE)
            {
                m_image = ChessTime_.Properties.Resources.WhiteKing;
            }
            else
            {
                m_image = ChessTime_.Properties.Resources.BlackKing;
            }
        }

        public override ChessSquare[] getSquares()
        {
            ChessBoard b = ChessBoard.getBoard();
            ChessSquare[] move = new ChessSquare[8];
            if (m_square.getColumn() > 1)
                move[0] = b.getSquare(m_square.getRow(), m_square.getColumn() - 1);
            else
                move[0] = null;
            if (m_square.getColumn() < 8)
                move[1] = b.getSquare(m_square.getRow(), m_square.getColumn() + 1);
            else
                move[1] = null;
            move[2] = b.getSquare(m_square.getRow() - 1, m_square.getColumn() - 1);
            move[3] = b.getSquare(m_square.getRow() - 1, m_square.getColumn() + 1);
            move[4] = b.getSquare(m_square.getRow() + 1, m_square.getColumn() - 1);
            move[5] = b.getSquare(m_square.getRow() + 1, m_square.getColumn() + 1);
            move[6] = b.getSquare(m_square.getRow() + 1, m_square.getColumn());
            move[7] = b.getSquare(m_square.getRow() - 1, m_square.getColumn());

            return null;
        }
    }
}
