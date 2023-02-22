using System.Collections.Generic;
using System;

namespace ConsoleRPG.Models
{
  public class Game 
  {
    
    public Game() 
    {
      Dictionary<string, int> myAttributes = new Dictionary<string, int>() {
        {"health", 100},
        {"str", 10},
        {"def", 10}
      };
      Character character = new Character(myAttributes);
      Character enemy = new Character(myAttributes);
      
      int damageRoll = character.GetBasicAttackDamage(enemy);
      enemy.changeHealth(damageRoll);
      Console.WriteLine("damage " + damageRoll);
      Console.WriteLine(enemy.GetHealth());

    }
  }
}