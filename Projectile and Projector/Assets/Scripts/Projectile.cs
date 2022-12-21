using UnityEngine;

public class Projectile : MonoBehaviour, IProjectile
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _berolePosion;
    [SerializeField] private float _damageValue;

    Rigidbody _projRigidbody;


    enum Tipe
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        _projRigidbody = _projectile.GetComponent<Rigidbody>();
    }

    public void shot(int force)
    {
        Vector3 shotDirection = _berolePosion.position + (_berolePosion.forward * force);
        _projRigidbody.AddForce(shotDirection, ForceMode.Impulse);
    }

    public float GetDamageValue()
    {
        return _damageValue;
    }
}