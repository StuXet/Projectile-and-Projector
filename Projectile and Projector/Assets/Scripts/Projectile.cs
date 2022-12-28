using UnityEngine;

public class Projectile : MonoBehaviour, IProjectile
{
    [SerializeField] private float _damageValue;

    [SerializeField] Rigidbody _projRigidbody;


    enum TrgetTipe
    {
        Enemy,
        Environment
    }
    // Start is called before the first frame update

    void Start()
    {
        _projRigidbody = gameObject.GetComponent<Rigidbody>();

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


    public void shot(float force)
    {
        Vector3 shotDirection =  (transform.forward * force);
        _projRigidbody.isKinematic = false;
        _projRigidbody.AddForce(shotDirection, ForceMode.Impulse);
    }

    public float GetDamageValue()
    {
        return _damageValue;
    }
}