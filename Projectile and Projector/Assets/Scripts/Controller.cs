using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Controller : MonoBehaviour
{
    public float sensitivity = 100.0f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 0.0f;
    private float rotX;
<<<<<<< Updated upstream
    [SerializeField] private float force;
    [SerializeField] private Transform loadPositin;
    [SerializeField] private GameObject projectile;
    
=======
    [SerializeField] IProjectile projectile;
>>>>>>> Stashed changes

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * sensitivity;
        rotX += Input.GetAxis("Mouse Y") * sensitivity;
        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        // rotate the camera
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            projectile.GetComponent<IProjectile>().shot(force);
        }
    }

}
