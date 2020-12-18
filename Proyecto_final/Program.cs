using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final;


namespace Proyecto_final
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            
        }

        public static void LlenarCola(Queue<string> cola)
        {
            
            cola.Enqueue("1");
            cola.Enqueue("2");
            cola.Enqueue("3");
            cola.Enqueue("4");
            cola.Enqueue("5");
            cola.Enqueue("6");
            cola.Enqueue("7");
            cola.Enqueue("8");
            cola.Enqueue("9");
            cola.Enqueue("10");
            
        }
    }
}
