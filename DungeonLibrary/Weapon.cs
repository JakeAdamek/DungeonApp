using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //Fields
        private int _minDamage; //Should not exceed maxDamage
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //Properties
        //Properties with business rules should come last
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }//End MaxDamage Prop

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//End Name Prop

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }//End BonusHitChanceProp

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }//End IsTwoHanded Prop

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //Can't be more than MaxDamage
                //Can't be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//End If
                else
                {
                    //Tried to set the value outside of our range
                    //Default it
                    _minDamage = 1;
                }//End Else
            }
        }//End MinDamage Prop


        //Constructors
        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            //Assignment
            //Properties with business rules that need other properties -- the other properties MUST be set first
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }//End FQCTOR

        //Methods
        public override string ToString()
        {
            return String.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t{4}",
                Name, MinDamage, MaxDamage, BonusHitChance, IsTwoHanded ? "Two-Handed" : "One-Handed");
        }//End ToString()

    }//End Class
}//End Namespace
