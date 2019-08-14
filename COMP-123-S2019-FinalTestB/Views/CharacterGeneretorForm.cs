using COMP_123_S2019_FinalTestB.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using COMP_123_S2019_FinalTestB.Objects;

/*
 * STUDENT NAME: Chowdhury Atika Parvin
 * STUDENT ID: 301007336
 * DESCRIPTION: This is the main form for the application
 */

namespace COMP_123_S2019_FinalTestB.Views
{
    public partial class CharacterGeneretorForm : COMP_123_S2019_FinalTestB.Views.MasterForm
    {
        Random random = new Random();
        string[] FirstNameList;
        string[] LastNameList;
        string[] SkillsList;

        public CharacterGeneretorForm()
        {
            InitializeComponent();
            Program.character = new CharacterClass();
        }
        private void LoadNames()
        {
            FirstNameList = File.ReadAllLines("..\\..\\Data\\firstNames.txt");
            LastNameList = File.ReadAllLines("..\\..\\Data\\lastNames.txt");
        }
        private void GenerateNames()
        {
            Program.character.FirstName = FirstNameList[random.Next(FirstNameList.Length)];
            Program.character.LastName = LastNameList[random.Next(LastNameList.Length)];

            FirstNameDataLabel.Text = Program.character.FirstName;
            LastNameDataLabel.Text = Program.character.LastName;
        }
        private void LoadInventory()
        {
            InventoryList = File.ReadAllLines("..\\..\\Data\\Inventory.txt");
        }
        private void GenerateRandomInventory()
        {
            Program.character.Inventory[0] = InventoryList[random.Next(InventoryList.Length)];
            Program.character.Inventory[1] = SkillsList[random.Next(InventoryList.Length)];
            Program.character.Inventory[2] = SkillsList[random.Next((InventoryList.Length)];
            Program.character.Inventory[3] = SkillsList[random.Next(InventoryList.Length)];

            InventoryFirstlabel.Text = Program.character.Inventory[0];
            InventorySecondlabel.Text = Program.character.Inventory[1];
            InventoryThirdlabel.Text = Program.character.Inventory[2];
            InventoryFourthlabel.Text = Program.character.Inventory[3];
        }
        private void CharacterGeneretorForm_Load(object sender, EventArgs e)
        {

        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void GenerateName_Click(object sender, EventArgs e)
        {
            LoadNames();
            GenerateRandomSkills();
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // configure the file dialog
            CharaterSheetSaveFileDialog.FileName = "Character.txt";
            CharaterSheetSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharaterSheetSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = CharaterSheetSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open the stream for writing
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(CharaterSheetSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write content - string type - to the file
                    outputStream.WriteLine(Program.character.FirstName);
                    outputStream.WriteLine(Program.character.LastName);
                    outputStream.WriteLine(Program.character.Strength);
                    //outputStream.WriteLine(characterInfo.Dexterity);
                    //outputStream.WriteLine(characterInfo.Endurance);
                    //outputStream.WriteLine(characterInfo.Intellect);
                    //outputStream.WriteLine(characterInfo.Education);
                    //outputStream.WriteLine(characterInfo.SocialStanding);



                    // cleanup
                    outputStream.Close();
                    outputStream.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // configure the file dialog
            CharaterSheetOpenFileDialog.FileName = "Student.txt";
            CharaterSheetOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            CharaterSheetOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = CharaterSheetOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open the  streawm for reading
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(CharaterSheetOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read from the file
                        Program.character.FirstName = inputStream.ReadLine();
                        Program.character.LastName = inputStream.ReadLine();
                        Program.character.Strength = inputStream.ReadLine();
                        Program.character.Dexterity = inputStream.ReadLine();
                        Program.character.Constitution = inputStream.ReadLine();
                        Program.character.Intelligence = inputStream.ReadLine();
                        Program.character.Wisdom = inputStream.ReadLine();
                        Program.character.Charisma = inputStream.ReadLine();

                        // cleanup
                        inputStream.Close();
                        inputStream.Dispose();


                    }
                    FirstNameDataLabel.Text = Program.character.FirstName;
                    LastNameDataLabel.Text = Program.character.LastName;
                    StrengthDataLabel.Text = Program.character.Strength;
                    DexterityDataLabel.Text = Program.character.Dexterity;
                    ConstitutionDataLabel.Text = Program.character.Constitution;
                    IntelligenceDataLabel.Text = Program.character.Intelligence;
                    WisdomDataLabel.Text = Program.character.Wisdom;
                    CharismaDataLabel.Text = Program.character.Charisma;
                    NextButton_Click(sender, e);
                }
                catch (IOException exception)
                {

                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the appropriate file type", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CharacterGenerationForm_Load(object sender, EventArgs e)
        {
            LoadNames();
            GenerateNames();
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            int strength = random.Next(3, 19);
            Program.character.Strength = strength.ToString();
            StrengthDataLabel.Text = Program.character.Strength;
            int dexterity = random.Next(3, 19);
            Program.character.Dexterity = dexterity.ToString();
            DexterityDataLabel.Text = Program.character.Dexterity;
            int constitution = random.Next(3, 19);
            Program.character.Constitution = constitution.ToString();
            ConstitutionDataLabel.Text = Program.character.Constitution;
            int intelligence = random.Next(3, 19);
            Program.character.Intelligence = intelligence.ToString();
            IntelligenceDataLabel.Text = Program.character.Intelligence;
            int wisdom = random.Next(3, 19);
            Program.character.Wisdom = wisdom.ToString();
            WisdomDataLabel.Text = Program.character.Wisdom;
            int charisma = random.Next(3, 19);
            Program.character.Charisma = charisma.ToString();
            CharismaDataLabel.Text = Program.character.Charisma;
        }
    }
}
