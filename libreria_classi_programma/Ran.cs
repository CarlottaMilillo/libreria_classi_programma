using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace clsUtility
{
    public class Ran
    {
        private Random rnd = new Random();
        /// <summary>
        /// ritorna una lista di numeri tra un min e un max 
        /// </summary>
        /// <param name="v1"> numero di valori ritornati in lista </param>
        /// <param name="v2"> valore minimo inserito</param>
        /// <param name="v3"> valore massimo inserito</param>
        /// <returns> lista di interi</returns>
        public List<int> GetLista(int v1, int v2, int v3)
        {
            Console.WriteLine("Genero una lista di {0} numeri tra {1} e {2}", v1, v2, v3);
            List<int> result = new List<int>();
            int r = GenerateRandom(v2,v3);
            for (int i = 0; i < v1; i++) // 
            {
                // fino a che r è nella list result continuo a generare
                while (InList(r, result)) 
                {
                    r = GenerateRandom(v2, v3); //se r c'è già aggiungo un'altro valore 
                }
                // aggiungo alla lista
                result.Add(r);
                Console.WriteLine("Generato numero => {0}", r);
                r = GenerateRandom(v2, v3); 
            }
            return result;
        }
        /// <summary>
        /// c'è già questo int nella result? si = true, no = false, 
        /// </summary>
        /// <param name="r"> numero generato</param>
        /// <param name="result"> lista con tutti i valori </param>
        /// <returns> true se c'è già, false se non c'è e continua  </returns>
        private bool InList(int r, List<int> result) 
        {
            bool bRes = false;
            foreach(int i in result)
            {
                if(r == i)
                {
                    bRes = true;
                }
                else
                {
                    bRes = false;
                    continue;
                }
            }
            return bRes;
        }


        /// <summary>
        /// Genero un numero intero tra il numero di partenza e il numero finale
        /// </summary>
        /// <param name="n1">numero di partenza</param>
        /// <param name="n2">numero finale</param>
        /// <returns>intero random</returns>
        private int GenerateRandom(int n1, int n2)
        {
            int iresult = 0;
            //
            iresult = rnd.Next(n1, n2);
            //
            return iresult;
        }


    }
}
