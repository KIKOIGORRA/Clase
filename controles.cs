using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestVarios
{
    public class controles 
    {
        public const string stringVacio = "";
        public const int intVacio = 0;
        public const string stringNone = "None";

        public Button CrearBotonDirecto(string nombre, string texto, Point posicion, Size tamano, int orden, EventHandler evento)
        {
            Button MiBoton = new Button();
            MiBoton.Name = nombre;
            MiBoton.Text = texto;
            MiBoton.Location = posicion;
            MiBoton.Size = tamano;
            MiBoton.TabIndex = orden;
            MiBoton.Click += new EventHandler(evento);

            return MiBoton;
        }

        public TextBox CrearTexbox(string nombre, string texto, Point posicion, Size tamano, int orden, string tag)
        {
            TextBox Mitexto = new TextBox();
            Mitexto.Name = nombre;
            Mitexto.Text = texto;
            Mitexto.Location = posicion;
            Mitexto.Size = tamano;
            Mitexto.TabIndex = orden;
            Mitexto.Tag = tag;

            return Mitexto;
        }

        public Panel CrearPanel(string nombre, string texto, Point posicion, [Optional] Size tamano, [Optional] DockStyle lugar)
        {
            Panel MiPanel= new Panel();
            MiPanel.Name = nombre;
            MiPanel.Text = texto;
            MiPanel.Location = posicion;
            MiPanel.Size = tamano;
            MiPanel.Dock= lugar;

            return MiPanel;
        }
    }
}