using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Recognition
{
    [Serializable]
    public class TestSymbol
    {
        public bool[,] Data { get; set; }

        /// <summary>
        /// <para>Creates empty logic surface being ready to become an example</para>
        /// </summary>
        public TestSymbol()
        {
            Data = new bool[256, 256];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    Data[i, j] = false;
                }
            }
        }

        /// <summary>
        /// <para>Marks specified logic pixel as colored</para>
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void Draw(int i, int j)
        {
            Data[i, j] = true;
        }

        /// <summary>
        /// <para>Clears test symbol</para>
        /// </summary>
        public void Clear()
        {
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    Data[i, j] = false;
                }
            }
        }
    }
}
