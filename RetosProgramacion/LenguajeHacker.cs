using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace RetosProgramacion
{
    public class LenguajeHacker
    {
        private string Palabra = "";
        private FlowLayoutPanel sc = null;
        private Dictionary<char, string> dic = new Dictionary<char, string>()
        {
            {'a',"4"},{'b',"I3" },{'c',"[" },{ 'd',"|)"},{'e',"3" },{ 'f',"|="},{'g',"&" },{'h',"#" },
            {'i',"[]"},{'j',",_|" },{'k',">|" },{ 'l',"1"},{'m',"^^"},{'n',"|V"},{'o',"0" },{'p',"|*" },
            {'q',"9"},{'r',"|2" },{'s',"5" },{'t',"7" },{ 'u',"(_)"},{'v',"|/" },{ 'w',"2u"},{'x',"><" },
            {'y',"j" },{'z',"2"},{' '," "},
            {'1',"1" },{'2',"2" },{'3',"3" },{'4',"4" },{'5',"5" },{'6',"6" },{'7',"7" },{'8',"8" },{'9',"9" },{'0',"0" },
        };
        public LenguajeHacker(string palabra, FlowLayoutPanel sc) 
        {
            this.sc = sc;   
            Palabra = palabra;
        }
        
        public string Hackeado()
        {
            Hack();
            return "";
        }
        private void Hack()
        {
            try
            {
                string NuevaPalabra = "";
                foreach (char ch in Palabra.ToLower().ToCharArray())
                {
                    var h = dic[ch].ToString();
                    NuevaPalabra += h.ToString();
                }
                AddWord(NuevaPalabra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Al parecer tiene un caracter no reconocido.\nSolo se perimiten letras y numeros","Error");
            }
        }
        private void AddWord(string word)
        {

            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.Dock = DockStyle.Fill;
            int i = sc.Controls.Count - 1;

            Label lbli = new Label();   
            lbli.Text = i.ToString();
            lbli.AutoSize = true;
            tlp.Controls.Add(lbli);

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Text = word;
            lbl.BackColor = System.Drawing.Color.LightGreen;
            tlp.Controls.Add(lbl);
            
            tlp.AutoSize = true;
            sc.Controls.Add(tlp);   
        }
        private void AddFlp()
        {

        }
    }
}
