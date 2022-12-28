using UnityEngine;
public interface IProjectile
{
    public void shot(float force);
    float GetDamageValue();
}