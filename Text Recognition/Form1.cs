using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Text_Recognition
{
    public partial class Form1 : Form
    {
        public Alphabet alphabet;
        TestSymbol example;
        System.Drawing.Graphics graphics;
        public XmlSerializer serializer;
        bool Pressed;
        int X;
        int Y;

        public Form1()
        {
            serializer = new XmlSerializer(typeof(Alphabet));
            example = new TestSymbol();
            InitializeComponent();
            AddEventHandlers();
            AddBehavior();
        }

        /// <summary>
        /// <para>Sets additional functionality to different controls</para>
        /// </summary>
        private void AddBehavior()
        {
            try
            {
                using (FileStream fs = new System.IO.FileStream("Alphabet.xml", FileMode.OpenOrCreate))
                {
                    alphabet = (Alphabet)serializer.Deserialize(fs);
                }
            }
            catch (Exception) { }

            graphics = surface.CreateGraphics();
            timer.Interval = 1;
            Pressed = false;
            timer.Start();
            foreach(Symbol s in alphabet.Symbols)
            {
                symbolSelector.Items.Add(s.Name);
            }
            symbolSelector.Text = "A";
        }

        /// <summary>
        /// <para>Adds event handlers methods to different controls</para>
        /// </summary>
        private void AddEventHandlers()
        {
            surface.MouseDown += surface_MouseDown;
            surface.MouseUp += surface_MouseUp;
            surface.MouseMove += surface_MouseMove;
            clearButton.Click += clearButton_Click;
            trainButton.Click += trainButton_Click;
            testButton.Click += testButton_Click;
            Untrain.Click += Untrain_Click;
            untrainAllButton.Click += untrainAllButton_Click;
        }

        void untrainAllButton_Click(object sender, EventArgs e)
        {
            alphabet.UnTrain();
            graphics.Clear(Color.White);
            example.Clear();
            symbolDisplayLabel.Text = "?";
            probabilityDataGrid.Rows.Clear();
            File.WriteAllText("Alphabet.xml", String.Empty);
            using (FileStream fs = new FileStream("Alphabet.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, alphabet);
            }
        }

        void Untrain_Click(object sender, EventArgs e)
        {
            alphabet.UnTrain(symbolSelector.Text.First());
            graphics.Clear(Color.White);
            example.Clear();
            symbolDisplayLabel.Text = "?";
            probabilityDataGrid.Rows.Clear();
            File.WriteAllText("Alphabet.xml", String.Empty);
            using (FileStream fs = new FileStream("Alphabet.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, alphabet);
            }
        }

        void testButton_Click(object sender, EventArgs e)
        {
            var resultTuple = alphabet.Recognize(example);
            symbolDisplayLabel.Text = resultTuple.Item1.ToString();
            probabilityDataGrid.Rows.Clear();
            probabilityDataGrid.DataSource = resultTuple.Item2;
            probabilityDataGrid.Columns[0].Width = (int)(probabilityDataGrid.Width * 0.5);
            File.WriteAllText("Alphabet.xml", String.Empty);
            using (FileStream fs = new FileStream("Alphabet.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, alphabet);
            }
        }

        void trainButton_Click(object sender, EventArgs e)
        {
            alphabet.TrainSymbol(symbolSelector.Text.First(), example);
            graphics.Clear(Color.White);
            example.Clear();
            symbolDisplayLabel.Text = "?";
            probabilityDataGrid.Rows.Clear();
            File.WriteAllText("Alphabet.xml", String.Empty);
            using (FileStream fs = new FileStream("Alphabet.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, alphabet);
            }
        }

        void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            example.Clear();
            symbolDisplayLabel.Text = "?";
            probabilityDataGrid.Rows.Clear();
        }

        void surface_MouseDown(object sender, MouseEventArgs e)
        {
            Pressed = true;
            X = e.X;
            Y = e.Y;
        }

        void surface_MouseUp(object sender, MouseEventArgs e)
        {
            Pressed = false;
        }

        void surface_MouseMove(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Pressed)
            {
                System.Drawing.Rectangle rectangle = new Rectangle(X, Y, 8, 8);
               // graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
                SolidBrush brush = new SolidBrush(Color.Black);
                graphics.FillEllipse(brush, rectangle);
                surface.Update();
                for(int i=1; i<6; i++)
                {
                    for(int j=1; j<6; j++)
                    {
                        try
                        {
                            example.Draw(X + i, Y + j);
                        }
                        catch (Exception) { }
                    }
                }
            }
        }
    }
}
