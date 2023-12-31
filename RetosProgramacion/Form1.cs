﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetosProgramacion
{
     public enum frmHabilitados
    {
        Deshabilitado,
        FizzBuzz,
        LenguajeHacker
    }
    public partial class Form1 : Form
    {
        frmHabilitados frms = frmHabilitados.Deshabilitado;
        FizzBuzz fizzbuzz;
        LENGUAJE_HACKER lenguajeH;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.BackColor == Color.White)
                {
                    if (fizzbuzz == null && frms == frmHabilitados.Deshabilitado)
                    {
                        frms = frmHabilitados.FizzBuzz;
                        
                        fizzbuzz = new FizzBuzz();
                        fizzbuzz.FormClosed += new FormClosedEventHandler(cerrarFizz);

                        fizzbuzz.TopLevel = false;
                        fizzbuzz.MinimizeBox = false;
                        fizzbuzz.Dock = DockStyle.Fill;
                        panel1.Controls.Add(fizzbuzz);
                        fizzbuzz.Show();

                        button1.BackColor = Color.LightBlue;
                        button1.Text = "Cerrar FIZZ BUZZ";
                    }
                    else
                    {
                        MessageBox.Show("Ya tienes habierto un reto!\nCierralo antes de abrir otro retro.", "Aviso");
                    }
                }
                else
                {
                    panel1.Controls.Clear();
                    fizzbuzz = null;
                    frms = frmHabilitados.Deshabilitado;
                    button1.BackColor = Color.White;
                    button1.Text = "FIZZ BUZZ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        void cerrarFizz (object sender, FormClosedEventArgs e)
        {
            try
            {
                fizzbuzz = null;
                frms = frmHabilitados.Deshabilitado;
                button1.BackColor = Color.White;
                button1.Text = "FIZZ BUZZ";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void cerrarLH(object sender, FormClosedEventArgs e)
        {
            try
            {
                lenguajeH = null;
                frms = frmHabilitados.Deshabilitado;
                button2.BackColor = Color.White;
                button2.Text = "LENGUAJE HACKER";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            try
            {
                if (frms == frmHabilitados.FizzBuzz)
                {
                    panel1.Controls.Clear();
                    fizzbuzz.Dock = DockStyle.Fill;
                    panel1.Controls.Add(fizzbuzz);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (button2.BackColor == Color.White)
                {
                    if (lenguajeH == null && frms == frmHabilitados.Deshabilitado)
                    {
                        frms = frmHabilitados.LenguajeHacker;

                        lenguajeH = new LENGUAJE_HACKER();
                        lenguajeH.FormClosed += new FormClosedEventHandler(cerrarLH);

                        lenguajeH.TopLevel = false;
                        lenguajeH.MinimizeBox = false;
                        lenguajeH.Dock = DockStyle.Fill;
                        panel1.Controls.Add(lenguajeH);
                        lenguajeH.Show();

                        button2.BackColor = Color.LightBlue;
                        button2.Text = "Cerrar LENGUAJE HACKER";
                        button2.AutoSize = true;
                    }
                    else
                    {
                        MessageBox.Show("Ya tienes habierto un reto!\nCierralo antes de abrir otro retro.", "Aviso");
                    }
                }
                else
                {
                    panel1.Controls.Clear();
                    lenguajeH = null;
                    frms = frmHabilitados.Deshabilitado;
                    button2.BackColor = Color.White;
                    button2.Text = "LENGUAJE HACKER!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
