using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetosProgramacion
{
    internal class FizzBuzz_Class
    {
        private FlowLayoutPanel flp;
        public FizzBuzz_Class(FlowLayoutPanel flp)
        {
            this.flp = flp;
        }
        private bool GetFizz(int num)
        {
            if ((num % 3) == 0) 
                return true;
            else
            return false;
        }
        private bool GetBuzz(int num)
        {
            if ((num % 5) == 0)
                return true;
            else
                return false;
        }
        private bool GetFizzBuzz(int num)
        {
            if ((num % 3) == 0 && (num % 5) == 0)
                return true;
            else
                return false;
        }
        public void AddLabel(string txt)
        {
            System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
            lbl.AutoSize = true;
            lbl.Text = txt;
            flp.Controls.Add(lbl);
        }
        public void FizzBuzz()
        {
            for (int i = 1; i < 101; i++)
            {
                 if (GetFizzBuzz(i))
                    AddLabel("[" + i + "] Fizz Buzz!");
                else if (GetFizz(i))
                    AddLabel("[" + i + "] Fizz");
                else if(GetBuzz(i))
                    AddLabel("[" + i + "] Buzz");
                else
                    AddLabel("[" + i + "] ...");
            }
        }
        public void FizzBuzzCustom(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (GetFizzBuzz(i))
                    AddLabel("[" + i + "] Fizz Buzz!");
                else if (GetFizz(i))
                    AddLabel("[" + i + "] Fizz");
                else if (GetBuzz(i))
                    AddLabel("[" + i + "] Buzz");
                else
                    AddLabel("[" + i + "] ...");
            }
        }
    }
}
