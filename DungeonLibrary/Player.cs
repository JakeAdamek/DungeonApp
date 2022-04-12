using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //public is an access modifier. It determines where
    //this class can be used in our application. Since
    //we want to make player objects in our Dungeon App
    //project, we need this class to be public.
    public class Player
    {
        //FIELDS
        //Variables to store information related to this kind of object.
        //Access is ALWAYS private.
        //Strong naming convention: _camelCase;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _life;
        private int _maxLife;
        private Race _characterRace;
        private Weapon _equippedWeapon;

        //PROPERTIES
        //Publicly available "gatekeepers" of the information in the fields.
        //Define the "rules" for interacting with the fields & their values.
        //Access for properties is ALWAYS public.
        //Naming convention: PascalCase
        public string Name
        {
            //Getter - Defines the rules for handling when information is requested
            get { return _name; }
            //Setter - Defines the rules for handling when we attempt to assign a value
            set { _name = value; }
        }//End Name Prop

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }//End HitChance Prop

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }//End Block Prop

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }//End MaxLife Prop

        public Race CharacterRace
        {
            get { return _characterRace; }
            set { _characterRace = value; }
        }//End CharacterRace Prop

        public Weapon EquippedWeapon
        {
            get { return _equippedWeapon; }
            set { _equippedWeapon = value; }
        }//End EquippedWeapon Prop

        public int Life
        {
            get { return _life; }
            set
            {
                //Business rule: Life should not be more than MaxLife
                if (value <= MaxLife)
                {
                    //Good to go - set it as normal
                    _life = value;
                }//End If
                else
                {
                    //Tried to assign a value to life that was greater than MaxLife
                    //Instead, default life to MaxLife (set the player to full)
                    _life = MaxLife;
                }//End Else
            }
        }//End Life Prop
         //Properties and Fields that require custom "business rules"
         //should come after any properties/fields that use the default.


        //CONSTRUCTORS
        //Special methods used to create objects of this type
        //Access is always public
        //Naming convention: PascalCase, must match the name of the class
        //Fully-Qualified Constructor - All properties are accounted for with parameters
        public Player(string name, int hitChance, int block, int life, int maxLife, Race characterRace, Weapon equippedWeapon)
        {
            //Assignment
            //Property = parameter;
            //PascalCase = camelCase;
            //Since Life depends on MaxLife, we need to set MaxLife FIRST.
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }//End FQCTOR

        //METHODS
        public override string ToString()
        {
            string description = "";
            switch (CharacterRace)
            {
                case Race.Orc:
                    description = "Orc";
                    Life += 5; //This makes the Orc Race have more life
                    break;
                case Race.Human:
                    description = "Human";
                    break;
                case Race.Elf:
                    description = "Elf";
                    break;
                case Race.Dwarf:
                    description = "Dwarf";
                    break;
                case Race.Gnome:
                    description = "Gnome";
                    break;
                case Race.Halfling:
                    description = "Halfling";
                    break;
                case Race.Tiefling:
                    description = "Tiefling";
                    break;
                case Race.DragonBorn:
                    description = "Dragon Born";
                    break;
            }//End Switch

            return string.Format("-=-=- {0} -=-=-\n" +
                "Life: {1} of {2}\n" +
                "Hit Chance: {3}%\n" +
                "Weapon:\n{4}\nBlock: {5}\nDescription: {6}\n",
                Name,
                Life,
                MaxLife,
                HitChance,
                EquippedWeapon,
                Block,
                description);
        }//End ToString()

    }//End Class
}//End Namespace
