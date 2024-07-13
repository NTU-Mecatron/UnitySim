using System.Collections.Generic;
using UnityEngine;

public class VehicleControllerUnity : MonoBehaviour
{
    [SerializeField] float force = 15000f;
    [SerializeField] float torque = 400f;

    float dt;
    readonly List<KeyCode> keycodes = new List<KeyCode> { KeyCode.W, KeyCode.S, KeyCode.E, KeyCode.Q,
        KeyCode.A, KeyCode.D, KeyCode.X, KeyCode.Y, KeyCode.J, KeyCode.K };

    new Rigidbody rigidbody;
    //private new Collider collider;
    // Start is called before the first frame update

    void Start()  
    {
        AgentManager.Instance.Register(gameObject);
        rigidbody = GetComponent<Rigidbody>();
        dt = Time.fixedDeltaTime;
        
    }

    // Update is called once per frame
    void FixedUpdate()  
    {
        if (AgentManager.Instance.activeAgent != gameObject)
            return;
            
        foreach (var item in keycodes)
        {
            if (Input.GetKey(item))
                applyForce(dt, item);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Pool"))
        {
            Debug.Log("You hit the pool!");
        }
        
    }

    void applyForce(float dt, KeyCode key) {
        rigidbody.AddForce((key == KeyCode.E ? 1 : 0) * dt * force * transform.up);
        rigidbody.AddForce((key == KeyCode.Q ? 1 : 0) * dt * force * -transform.up);
        rigidbody.AddForce((key == KeyCode.W ? 1 : 0) * dt * force * transform.forward);
        rigidbody.AddForce((key == KeyCode.S ? 1 : 0) * dt * force * -transform.forward);
        rigidbody.AddForce((key == KeyCode.D ? 1 : 0) * dt * force * transform.right);
        rigidbody.AddForce((key == KeyCode.A ? 1 : 0) * dt * force * -transform.right);
        rigidbody.AddTorque((key == KeyCode.K ? 1 : 0) * dt * torque * transform.up);
        rigidbody.AddTorque((key == KeyCode.J ? 1 : 0) * dt * torque * -transform.up);
    }
}
