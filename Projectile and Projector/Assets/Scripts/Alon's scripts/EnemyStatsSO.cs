using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class EnemyStatsSO : ScriptableObject
{
    [HideInInspector]
    public EnemyStats enemyStats => new EnemyStats(InputMaxHP);

    public float InputMaxHP;
}
