using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IHittable
{
    [SerializeField, Tooltip("The Scriptable Object which holds the correct EnemyStats for this Enemy. See \"Scriptables\" -> \"EnemySOs\" folder.")]
    EnemyStatsSO enemyStatsSO;

    [SerializeField]
     EnemyStats stats;

    private void Awake()
    {
        Init();
    }
    public void Init()
    {
        if(enemyStatsSO == null)
        {
            Debug.LogError("No EnemySOs set in inspector!");
            return;
        }    

        stats = enemyStatsSO.enemyStats;
    }


    public void GetHit(IProjectile projectile)
    {
        if (!stats.TakeDamage(projectile.GetDamageValue())) //applies damage, and returns bool isAlive
        {
            //enemy has died!
            Debug.Log($"{name} has died.");
            Destroy(gameObject, 2); // The enemy will disappear in 2 seconds...
        }
    }
}
