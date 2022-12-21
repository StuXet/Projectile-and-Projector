using UnityEngine;

public class Projectile : MonoBehaviour, IProjectile
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _berolePosion;
    [SerializeField] private float _damageValue;

    Rigidbody _projRigidbody;


    enum TrgetTipe
    {
        Enemy,
        Environment
    }
    // Start is called before the first frame update
    void Start()
    {
        _projRigidbody = _projectile.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Enemy") )
        {
            Debug.Log("Trget is: Enemy");
        }
        else
        {
            Debug.Log("Trget is: Environment");
        }
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