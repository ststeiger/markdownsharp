
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SampleApplication
{


    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool bShowWindow = false;

            if (bShowWindow)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }

            //HTML 2 Markdown:
            // http://domchristie.github.io/to-markdown/

            //Editor:
            // https://stackedit.io/editor#
            // http://dillinger.io/


            string input = @"* * *\n\n***\n\n*****\n\n- - -\n\n---------------------------------------\n\n";

            MarkdownSharp.Markdown m = new MarkdownSharp.Markdown();
            string actual = m.Transform(input);
            Console.WriteLine(actual);


            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(" --- Press any key to continue --- ");
            Console.ReadKey();
        }


    }


}
