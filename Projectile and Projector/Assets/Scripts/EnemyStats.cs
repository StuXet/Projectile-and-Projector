using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct EnemyStats
{
    [ReadOnly]
    [SerializeField]
    float currentHP;
    [ReadOnly]
    [SerializeField]
    float maxHP;

    bool isAlive;

    public EnemyStats(float hp)
    {
        maxHP = currentHP = hp;
        isAlive = true;
    }


    ///// <summary>
    ///// also sets currentHP to newMaxHP 
    ///// </summary>
    ///// <param name="newMaxHP"></param>
    //public void SetMaxHP(float newMaxHP)
    //{
    //    maxHP = currentHP = newMaxHP;
    //}
    /// <summary>
    /// returns bool isAlive
    /// </summary>
    /// <param name="damage"></param>
    /// <returns></returns>
    public bool TakeDamage(float damage)
    {
        currentHP -= damage;
        if(currentHP<=0f)
        {
            currentHP = 0; // We don't want to accidentally display a negative value for HP... Unless it is mechanically meaningful.
                           // There is no technical problem with having negative HP values in your game.
                           // E.g. If characters in your game may "heal allies to revive them",
                           // allowing for negative HP value would make it harder to ressurect a character (especially if it was low-on-HP and then took massive damage)
                           // or if your game doesn't normally display damage to the player, but DOES display currentHP ->
                           // allowing for a negative HP value will provide valueable information to the Player (mainly, amount of damage delt)
                           // 
                           // So there are plenty of good reasons to have/allow-for negative HP values in your game -> but there must be a reason! 
                           // Because if I look at an HP bar in a game, and I see a negative value (even if just for a second, during their "death animation")
                           // information reaches my brain.
                           // "In this game, HP can be negative." - Fact.
                           // If there is no follow-up on this concept, no game-feature/mechanic/special-ability that uses negative HP,
                           // and there is no thematic/narrative reason for it being there
                           // "then why was it there?
                           // as a mistake? does it have a deeper meaning?
                           // is this game actually a piece of shit?"
                           // - and we don't want that, do we?
            
            isAlive = false;

            Debug.Log($"Dead");
        }
        return isAlive;
    }
}
