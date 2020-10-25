using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Enums;
using App.Models;
using System.Globalization;

namespace App
{
    public partial class frmMain : Form
    {
        Dictionary<string, Satellite> satellites = new Satellites().GetSatellites();

        public frmMain()
        {
            InitializeComponent();
        }

        private void NewDistance(object sender, EventArgs e)
        {
            double dblX = 0;
            double dblY = 0;
            double dblD1 = 0;
            double dblD2 = 0;
            double dblD3 = 0;

            try
            {
                dblD1 = double.Parse(txtKenobiD.Text, CultureInfo.InvariantCulture);
                dblD2 = double.Parse(txtSkywalkerD.Text, CultureInfo.InvariantCulture);
                dblD3 = double.Parse(txtSatoD.Text, CultureInfo.InvariantCulture);

                GetLocation(dblD1, dblD2, dblD3, out dblX, out dblY);

                lblX.Text = "X: " + dblX.ToString("0.00");
                lblY.Text = "Y: " + dblY.ToString("0.00");
            }
            catch (Exception ex)
            {
                lblX.Text = "X: ";
                lblY.Text = "Y: ";
            }
        }

        private void NewMessage(object sender, EventArgs e)
        {
            string message = string.Empty;

            GetMessage(txtKenobiM.Text.Split(','), txtSkywalkerM.Text.Split(','), txtSatoM.Text.Split(','), out message);

            lblMessage.Text = message;
        }

        private void GetLocation(double d1, double d2, double d3, out double x, out double y)
        {
            double Xp1; double Yp1;
            double Xp2; double Yp2;
            double Xp3; double Yp3;
            double S; double T;

            Xp1 = satellites["Kenobi"].GetLocation().GetX();
            Yp1 = satellites["Kenobi"].GetLocation().GetY();
            Xp2 = satellites["Skywalker"].GetLocation().GetX();
            Yp2 = satellites["Skywalker"].GetLocation().GetY();
            Xp3 = satellites["Sato"].GetLocation().GetX();
            Yp3 = satellites["Sato"].GetLocation().GetY();

            S = (Math.Pow(Xp3, 2) - Math.Pow(Xp2, 2) + Math.Pow(Yp3, 2) - Math.Pow(Yp2, 2) + Math.Pow(d2, 2) - Math.Pow(d3, 2)) / 2;
            T = (Math.Pow(Xp1, 2) - Math.Pow(Xp2, 2) + Math.Pow(Yp1, 2) - Math.Pow(Yp2, 2) + Math.Pow(d2, 2) - Math.Pow(d1, 2)) / 2;
            y = ((T * (Xp2 - Xp3)) - (S * (Xp2 - Xp1))) / (((Yp1 - Yp2) * (Xp2 - Xp3)) - ((Yp3 - Yp2) * (Xp2 - Xp1)));
            x = ((y * (Yp1 - Yp2)) - T) / (Xp2 - Xp1);


        }

        private void GetMessage(string[] m1, string[] m2, string[] m3, out string message)
        {
            message = string.Empty;
            bool complete = false;
            int pos = 0;
            string lastWord = string.Empty;
            string[][] messages = { m1, m2, m3 };

            while (!complete)
            {
                complete = true;
                foreach (string[] msg in messages)
                {
                    if (pos <= msg.Length - 1 && msg[pos] != null && !msg[pos].Equals(string.Empty) && !msg[pos].Equals(lastWord))
                    {
                        lastWord = msg[pos];
                        message += (message.Equals(string.Empty) ? "" : " ") + lastWord;
                    }

                    if (pos <= msg.Length) complete = false;
                }
                pos++;

            }
        }
    }
}
