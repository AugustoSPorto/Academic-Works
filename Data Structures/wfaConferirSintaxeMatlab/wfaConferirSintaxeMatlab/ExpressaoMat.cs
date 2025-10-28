using caPilhaDinamica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaConferirSintaxeMatlab
{
    internal class ExpressaoMat : PilhaDinamica
    {
        public ExpressaoMat() : base() { }
        public ExpressaoMat(char n) : base(n) { }

        public bool verficaExpressao()
        {
            int numPar = 0;
            int numCol = 0;
            int numCha = 0;

            NoPilha no = topo;

            for (char c = no.Info; no!=null;)
            {
                c = no.Info;
                if (c != '{' && c != '}' && c != '[' && c != ']' && c != '(' && c != ')')
                {
                    no = no.Prox;
                    continue;
                }
                else if (c == '}' && numPar == 0 && numCol == 0 && numCha == 0)
                {
                    numCha++;
                    no = no.Prox;
                    continue;
                }
                else if (c == '{' && numPar == 0 && numCol == 0 && numCha == 1)
                {
                    numCha--;
                    no = no.Prox;
                    continue;
                }
                else if (c == ']' && numPar == 0 && numCol == 0)
                {
                    numCol++;
                    no = no.Prox;
                    continue;
                }
                else if (c == '[' && numPar == 0 && numCol == 1)
                {
                    numCol--;
                    no = no.Prox;
                    continue;
                }
                else if (c == ')')
                {
                    numPar++;
                    no = no.Prox;
                    continue;
                }
                else if (c == '(' && numPar == 1)
                {
                    numPar--;
                    no = no.Prox;
                    continue;
                }
                else if (c == '}' && (numPar != 0 || numCol != 0 || numCha != 0))
                {
                    return false;
                }
                else if (c == '{' && (numPar != 0 || numCol != 0 || numCha != 1))
                {
                    return false;
                }
                else if (c == ']' && (numPar != 0 || numCol != 0))
                {
                    return false;
                }
                else if (c == '[' && (numPar != 0 || numCol != 1))
                {
                    return false;
                }
                else if (c == ')' && numPar != 0)
                {
                    return false;
                }
                else if (c == '(' && numPar != 1)
                {
                    return false;
                }
                
                              
            }
            if (numPar != 0 || numCol != 0 || numCha != 0)
                return false;
            else
                return true;

        }
    }
}
