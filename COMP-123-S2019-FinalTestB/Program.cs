using COMP_123_S2019_FinalTestB.Objects;
using COMP_123_S2019_FinalTestB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * STUDENT NAME: Chowdhury Atika Parvin
 * STUDENT ID: 301007336
 * DESCRIPTION: This is the main form for the application
 */

namespace COMP_123_S2019_FinalTestB
{
    static class Program
    {   ///temporary
        public static CharacterGeneretorForm characterForm;
        public static CharacterClass character;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            characterForm = new CharacterGeneretorForm();

            Application.Run(characterForm);
            Application.Exit();
        }
    }
}
