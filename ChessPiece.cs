using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ChessTime_
{
    enum piece
    {
        eKING, eQUEEN, eKNIGHT, eROOK, ePAWN, eBISHOP
    }

    enum color
    {
        eBLACK, eWHITE
    }

    abstract class ChessPiece
    {
        public Image m_image;

        public ChessSquare m_square;
        public ChessPiece(piece unit, color color, ChessSquare s) { 
            m_square = s;
            s.SetChessPiece(this);
        }

        public abstract ChessSquare[] getSquares();
    }
}
