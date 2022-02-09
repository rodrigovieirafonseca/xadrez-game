using System;

namespace tabuleiro
{
    class TabuleiroExption : Exception
    {
        public TabuleiroExption (string msg) : base(msg)
        {
        }
    }
}
