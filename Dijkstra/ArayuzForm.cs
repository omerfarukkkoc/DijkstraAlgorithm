
// Cumhuriyet Üniversitesi 
// Bilgisayar Mühendisliği Bölümü
// Algoritma Analizi Dersi Final Ödevi
// 30.Nisan.2016

// Ömer Faruk KOÇ
// Kutlu GÜNGÖR
// Cuma GÜR

using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Dijkstra
{
    public partial class ArayuzForm : MetroForm
    {
        private List<Vertex> Vertices = new List<Vertex>();
        private List<Edge> Edges = new List<Edge>();
        
        private int numV = 0;

        public ArayuzForm()
        {
            InitializeComponent();
        }
        
        private void ReloadVertexList()
        {
            comboBoxDen.Items.Add(Vertices[Vertices.Count - 1].ident);
            comboBoxe.Items.Add(Vertices[Vertices.Count - 1].ident);
        }
        
        private void DrawVertex(int vertex)
        {
            Graphics g = panMap.CreateGraphics();
            
            Vertex p = Vertices[vertex];
            g.FillEllipse(new SolidBrush(Color.Blue), p.p.X - 10, p.p.Y - 10, 20, 20);
            g.DrawString(p.ident.ToString(), new Font("Verdana", 11), new SolidBrush(Color.Black), p.p.X - 20, p.p.Y - 15);
            
            g.Dispose();
        }
        
        private void DrawEdge(int edge)
        {
            Graphics g = panMap.CreateGraphics();
            
            Edge p = Edges[edge];
            Vertex from = Vertices[p.from];
            Vertex to = Vertices[p.to];
            Point pFrom;
            Point pTo;
            
            pFrom = new Point(from.p.X + (from.p.X < to.p.X ? 1 : -1)* 15, from.p.Y);
            pTo = new Point(to.p.X + (from.p.X < to.p.X ? -1 : 1)*15, to.p.Y);
  

            Pen pen = new Pen(Color.Black, 1);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.ArrowAnchor;
            

            g.DrawString("w=" + p.weight.ToString(), new Font("Verdana", 11), new SolidBrush(Color.Black), new Point((pFrom.X + pTo.X) / 2, (pFrom.Y + pTo.Y) / 2 + (pFrom.Y < pTo.Y? (-20) : 10)));
            g.DrawLine(pen, pFrom, pTo);

            g.Dispose();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            Graphics g = panMap.CreateGraphics();
            g.Clear(DefaultBackColor);

            Vertices.RemoveAll(delegate (Vertex v)
            {
                return true;
            });

            Edges.RemoveAll(delegate (Edge edge) {
                return true;
            });

            comboBoxDen.Items.Clear();
            comboBoxDen.Text = "";
            comboBoxe.Text = "";
            comboBoxDen.ResetText();
            comboBoxe.Items.Clear();
            comboBoxe.ResetText();
            txtAgirlik.ResetText();
            numV = 0;
        }

        private void GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panMap_MouseClick(object sender, MouseEventArgs e)
        {
            Vertices.Add(new Vertex(new Point(e.X, e.Y), numV));
            numV++;
            
            DrawVertex(Vertices.Count-1);
            
            ReloadVertexList();
        }
        
        private void btnAddEdge_Click(object sender, EventArgs e)
        {
            if (txtAgirlik.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Ağırlık Değeri Girmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int from = Int32.Parse(comboBoxDen.SelectedItem.ToString());
                    int to = Int32.Parse(comboBoxe.SelectedItem.ToString());
                    Double weight = Double.Parse(txtAgirlik.Text);
                    
                    Edges.Add(new Edge(from, to, weight));
                    
                    DrawEdge(Edges.Count - 1);
                }
                catch (FormatException)
                {
                }
                catch (NullReferenceException)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Düğüm Seçmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(Vertices.Count != 0)
            {
                double[,] G = new double[Vertices.Count, Vertices.Count];

                foreach (Edge edge in Edges)
                {
                    G[edge.from, edge.to] = edge.weight;
                }

                try
                {
                    Dijkstra dijk = new Dijkstra(G, 0);
                    double[] dist = dijk.dist;
                    int[] path = dijk.path;

                    for (int i = 0; i < dist.Length; i++)
                    {
                        Graphics g = panMap.CreateGraphics();

                        Vertex p = Vertices[i];
                        StringFormat distFormat = new StringFormat();
                        distFormat.Alignment = StringAlignment.Center;
                        g.DrawString("Uzaklık= " + dist[i].ToString(), new Font("Verdana", 11), new SolidBrush(Color.Red), p.p.X, p.p.Y - 7, distFormat);

                    }
                }
                catch (ArgumentException)
                {
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Düğümleri Oluşturup Ağırlıklarını Girmeden Neyi Çalıştırmaya Çalışıyosunuz :)", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            Graphics g = panMap.CreateGraphics();
            g.Clear(DefaultBackColor);
            
            Vertices.RemoveAll(delegate(Vertex v)
            {
                return true;
            });
            
            Edges.RemoveAll(delegate(Edge edge) {
                return true;
            });

            comboBoxDen.Items.Clear();
            comboBoxDen.Text = "";
            comboBoxe.Text = "";
            comboBoxDen.ResetText();
            comboBoxe.Items.Clear();
            comboBoxe.ResetText();
            txtAgirlik.ResetText();
            
            numV = 0;

        }

       

        private void txtAgirlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBoxDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxe.Items.RemoveAt(comboBoxDen.SelectedIndex);
        }
    }
}
