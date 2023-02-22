using System.Collections.Generic;
using System;

namespace ConsoleRPG.Models
{
  public class Character 
  {
    Dictionary<string, int> attributes;
    public Character(Dictionary<string, int> attributes) {
      this.attributes = new Dictionary<string, int>(attributes);
      // maxHealth, maxMana, health, mana, str, def, dex, wis, luck, aggro
    }
    // methods...

    public int GetHealth(){
      return this.attributes["health"];
    }

    public int GetBasicAttackDamage(Character target)
    {
      Random myRand = new Random();
      int baseAttack = myRand.Next((int)this.attributes["str"] + 1);
      int damageReturn = (baseAttack - (int)Math.Ceiling((double)target.attributes["def"] / 10));
      if (damageReturn <= 0) 
      {
        damageReturn = 0;
      }
      return damageReturn;
    }

    public void changeHealth(int healthDelta) {
      this.attributes["health"] -= healthDelta;
    }
  }

  public class Enemy : Character {
    public Enemy(Dictionary<string, int> attributes): base (attributes){ // add Lists for gear and loot drop
      
    }


  }
}