using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“microblogDataSet1.train”中。您可以根据需要移动或删除它。
            this.trainTableAdapter.Fill(this.microblogDataSet1.train);
            // TODO: 这行代码将数据加载到表“microblogDataSet1.predata”中。您可以根据需要移动或删除它。
            this.predataTableAdapter.Fill(this.microblogDataSet1.predata);

        }
        delegate int del(double i);
        private void button1_Click(object sender, EventArgs e)
        {
            int numtrain = microblogDataSet1.train.Count();
            double avgforward = microblogDataSet1.train.Select(p => p.forward_count).Average();
            double avgcomment = microblogDataSet1.train.Select(p => p.comment_count).Average();
            double avglike = microblogDataSet1.train.Select(p => p.like_count).Average();
            double varforward = 0.0;
            var lforward = from n in microblogDataSet1.train.AsEnumerable() select n.forward_count;
            foreach (int i in lforward)
            {
                int j = i > 20 ? 1 : i;
                varforward += Math.Abs(avgforward * avgforward - j * j);
            }
            varforward = varforward/numtrain;
            double varcomment = 0.0;
            var lcomment = from n in microblogDataSet1.train.AsEnumerable() select n.comment_count;
            foreach (int i in lcomment)
            {
                int j = i > 20 ? 1 : i;
                varcomment += Math.Abs(avgcomment * avgcomment - j * j);
            }
            varcomment /= numtrain;
            double varlike = 0.0;
            var llike = from n in microblogDataSet1.train.AsEnumerable() select n.like_count;
            foreach (int i in llike)
            {
                int j = i > 20 ? 1 : i;
                varlike += Math.Abs(avglike * avglike - j * j);
            }
            varlike /= numtrain;
            Random rd;
            try
            {
                rd = new Random(Convert.ToInt32(textBox1.Text));
            }
            catch(FormatException exp)
            {
                rd = new Random();
            }
            del rlambda = (double l) =>
            {
                int k = (int)Math.Round(l * 4.0);
                int sum = 0;
                for (int i = 0; i < k; i++)
                {
                    sum = rd.NextDouble() > 0.5 ? 1 : 0;
                }
                return sum;
            };
            try
            {
                FileStream file = new FileStream("randomresult.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(file, new System.Text.UTF8Encoding(false));
                sw.AutoFlush = true;
                var prerandom = from n in microblogDataSet1.predata.AsEnumerable() select n;
                foreach(var rowrandom in prerandom)
                {
                    int c = rlambda(varlike);
                    sw.WriteLine(rowrandom.uid + "\t" + rowrandom.mid + "\t" + rlambda(varforward) + "," + rlambda(varcomment) + "," + c );
                    
                }
            }
            catch (IOException exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }



    }
}
