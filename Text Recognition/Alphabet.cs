using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Text_Recognition
{
    [Serializable]
    public class Alphabet
    {
        public List<Symbol> Symbols { get; set; }

        /// <summary>
        /// <para>Creates alphabet</para>
        /// </summary>
        public Alphabet()
        {
        }

        public Alphabet(string param)
        {
            Symbols = new List<Symbol>();
            Symbols.Add(new Symbol('A'));
            Symbols.Add(new Symbol('B'));
            Symbols.Add(new Symbol('C'));
            Symbols.Add(new Symbol('D'));
            Symbols.Add(new Symbol('E'));
            Symbols.Add(new Symbol('F'));
            Symbols.Add(new Symbol('G'));
            Symbols.Add(new Symbol('H'));
            Symbols.Add(new Symbol('I'));
            Symbols.Add(new Symbol('J'));
            Symbols.Add(new Symbol('K'));
            Symbols.Add(new Symbol('L'));
            Symbols.Add(new Symbol('M'));
            Symbols.Add(new Symbol('N'));
            Symbols.Add(new Symbol('O'));
            Symbols.Add(new Symbol('P'));
            Symbols.Add(new Symbol('Q'));
            Symbols.Add(new Symbol('R'));
            Symbols.Add(new Symbol('S'));
            Symbols.Add(new Symbol('T'));
            Symbols.Add(new Symbol('U'));
            Symbols.Add(new Symbol('V'));
            Symbols.Add(new Symbol('W'));
            Symbols.Add(new Symbol('X'));
            Symbols.Add(new Symbol('Y'));
            Symbols.Add(new Symbol('Z'));
        }

        /// <summary>
        /// <para>Trains specified symbol from alphabet</para>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="example"></param>
        public void TrainSymbol(char name, TestSymbol example)
        {
            Symbol symbol = Symbols.Where(x => x.Name == name).FirstOrDefault();
            symbol.Train(example);
            example.Clear();
        }

        /// <summary>
        /// <para>Tests specified symbol from the alphabet</para>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="example"></param>
        public void TestSymbol(char name, TestSymbol example)
        {
            Symbol symbol = Symbols.Where(x => x.Name == name).FirstOrDefault();
            symbol.Test(example);
        }

        /// <summary>
        /// <para>Untrains specified symbol from the alphabet</para>
        /// </summary>
        /// <param name="name"></param>
        public void UnTrain(char name)
        {
            Symbol symbol = Symbols.Where(x => x.Name == name).FirstOrDefault();
            symbol.UnTrain();
        }

        /// <summary>
        /// <para>Untrains all the symbols from tha alphabet</para>
        /// </summary>
        public void UnTrain()
        {
            foreach(Symbol s in Symbols)
            {
                s.UnTrain();
            }
        }

        /// <summary>
        /// <para>Determines which symbol was drawen and its grade</para>
        /// </summary>
        /// <param name="example"></param>
        /// <returns></returns>
        public Tuple<char, BindingList<Tuple<char, float>>> Recognize(TestSymbol example)
        {
            char resultSymbol = '-';
            short resultGrade = 0;
            short tempGrade = 0;
            var resultListSum = 0;
            var finalList = new BindingList<Tuple<char, float>>();
            BindingList<Tuple<char, short>> resultList = new BindingList<Tuple<char, short>>(); 

            foreach (Symbol s in Symbols)
            {
                tempGrade = s.Test(example);
                resultList.Add(new Tuple<char, short>(s.Name, tempGrade));

                if (tempGrade > resultGrade)
                {
                    resultGrade = tempGrade;
                    resultSymbol = s.Name;
                }
            }
            foreach (Tuple<char, short> t in resultList)
            {
                resultListSum += t.Item2;
            }
            foreach (Tuple<char, short> t in resultList)
            {
                float probability = 100;
                try
                {
                    probability = (float)((float)t.Item2 / (float)resultListSum);
                }
                catch (Exception) { }
                finalList.Add(new Tuple<char, float>(t.Item1, probability));
            }
            return new Tuple<char, BindingList<Tuple<char, float>>>(resultSymbol, finalList);
        }
    }
}
