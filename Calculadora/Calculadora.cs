using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calculadoraa
    {
        private List<string> listaHistorico;

        public Calculadoraa()
        {
            listaHistorico = new List<string>();
        }

        public void inserirHistorico(int hist)
        {
            listaHistorico.Insert(0, "Res: " + hist);
        }

        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            inserirHistorico(res);
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            inserirHistorico(res);
            return res;
        }
        
        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            inserirHistorico(res);
            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            inserirHistorico(res);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
