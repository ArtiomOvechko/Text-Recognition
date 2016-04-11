using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Text_Recognition
{
    [Serializable]
    public class Symbol
    {
        public char Name { get; set; }
        
        public List<List<short>> Data { get; set; }

        public Symbol()
        {

        }

        /// <summary>
        /// <para>Creates new not learned symbol</para>
        /// </summary>
        /// <param name="name"></param>
        public Symbol(char name)
        {
            Name = name;
            Data = new List<List<short>>();
            for(int i=0; i<256; i++)
            {
                Data.Add(new List<short>());
                for(int j=0; j<256; j++)
                {
                    Data[i].Add(0);
                }
            }
        }

        /// <summary>
        /// <para>Learns symbol example</para>
        /// </summary>
        /// <param name="example"></param>
        public void Train(TestSymbol example)
        {
            for(int i=0; i<256; i++)
            {
                for(int j=0; j<256; j++)
                {
                    if(example.Data[i,j])
                    if(Data[i][j]<=10)
                        this.Data[i][j]++;
                }
            }
        }

        /// <summary>
        /// <para>Forgets all trainings</para>
        /// </summary>
        public void UnTrain()
        {
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    Data[i][j]=0;
                }
            }
        }

        /// <summary>
        /// <para>Returns similarity grade between itself and training symbol</para>
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        public short Test(TestSymbol example)
        {
            short result = 0;
            short max = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    if (Data[i][j] > max)
                        max = Data[i][j];
                }
            }
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    if (example.Data[i, j])
                        if(Data[i][j]>(max/5))
                            result += this.Data[i][j];
                }
            }
            return result;
        }
    }
}
