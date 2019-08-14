using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * STUDENT NAME: Chowdhury Atika Parvin
 * STUDENT ID: 301007336

 */
/*STUDENT NAME:
 * STUDENT ID:
 * DESCRIPTION: This is the character class used in character creation.
                This is also the Data container for the application.
 */

namespace COMP_123_S2019_FinalTestB.Objects

{
    public class Character
    {   // names
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //character Abilities
        public string Strength { get; set; }
        public string Dexterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }
        
        //secondary abilities
        public int ArmourClass { get; set; }
        public int HiPoints { get; set; }

        //Character class
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        //Equipment class
        List<Item> Inventory;

        //Constructor
        Character()
        {
            this.Inventory = new List<Item>();
        }
    }
}
