namespace _2_3_Tree
{
    class TTNode<LLave, E>
    {
        //valores izquieda y derecha
        private E ValorIzquierda;
        private E ValorDerecha;
        //llave izquierda y derecha
        private LLave LLaveIzquierda;
        private LLave LlaveDerecha;

        //punteros izquierda, centro y derecha
        private TTNode<LLave, E> Izquierda;
        private TTNode<LLave, E> Centro;
        private TTNode<LLave, E> Derecha;

        //contructores 
        public TTNode()
        {
            Centro = Izquierda = Derecha = null;
        }

        public TTNode(LLave LI, E VI, LLave LD, E VD, TTNode<LLave, E> P1, TTNode<LLave, E> P2, TTNode<LLave, E> P3)
        {
            LLaveIzquierda = LI; LlaveDerecha = LD;

            ValorIzquierda = VI; ValorDerecha = VD;

            Izquierda = P1;
            Centro = P2;
            Derecha = P3; 
        }

        //metodos 
        public bool EsHoja()
        {
            return Izquierda == null;
        }

        public TTNode<LLave, E> HijoIzquierda()
        {
            return Izquierda;
        }
        public TTNode<LLave, E> HijoDerecha()
        {
            return Derecha;
        }
        public TTNode<LLave, E> HijoCentro()
        {
            return Centro;
        }

        public LLave lLLave()
        {
            return LLaveIzquierda;
        }
        public E lval()
        {
            return ValorIzquierda;
        }
        public LLave rLLave()
        {
            return LlaveDerecha;
        }
        public E rval()
        {
            return ValorDerecha;
        }
        public void ConfigurarIzquierda(LLave l, E e)
        {
            LLaveIzquierda = l;
            ValorIzquierda = e;
        }
        public void ConfigurarDerecha(LLave l, E e)
        {
            LlaveDerecha = l;
            ValorDerecha = e; 
        }
        public void ConfigurarHijoIzquierda(TTNode<LLave, E> it)
        {
            Izquierda = it; 
        }
        public void ConfigurarHijoDerecha(TTNode<LLave, E> it)
        {
            Derecha = it;
        }
        public void ConfigurarHijoCentro(TTNode<LLave, E> it)
        {
            Centro = it;
        }
    }
}
