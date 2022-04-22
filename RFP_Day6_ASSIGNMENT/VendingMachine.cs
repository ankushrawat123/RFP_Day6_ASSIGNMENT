using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFP_Day6_ASSIGNMENT
{// m is size of Notes array
 // (number of different Notes)

    public class VendingMachine
    {
        public int minNotes(int[] Notes, int m, int V)
        {
            // table[i] will be storing
            // the minimum number of notes
            // required for i value. So
            // table[V] will have result
            int[] table = new int[V + 1];

            // Base case (If given
            // value V is 0)
            table[0] = 0;

            // Initialize all table
            // values as Infiniteb
            for (int i = 1; i <= V; i++)
                table[i] = int.MaxValue;

            // Compute minimum notes
            // required for all
            // values from 1 to V
            for (int i = 1; i <= V; i++)
            {
                // Go through all notes
                // smaller than i
                for (int j = 0; j < m; j++)
                    if (Notes[j] <= i)
                    {
                        int sub_res = table[i - Notes[j]];
                        if (sub_res != int.MaxValue &&
                            sub_res + 1 < table[i])
                            table[i] = sub_res + 1;
                    }
            }

            return table[V];

        }

       
    }

}
        















