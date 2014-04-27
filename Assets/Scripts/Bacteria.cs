using UnityEngine;
using System.Collections;

public class Bacteria : MonoBehaviour
{
    public Vector3 targetPosition;
    public Vector3 Direction;
    public Vector3 Acceleration;
    public Vector3 Velocity;
    public float Friction;
    public float Speed;
    public float Mass;
    public float Bounce;

    // Use this for initialization
    void Start()
    {
        targetPosition = new Vector3(0, 0, 0);
        //Velocity = new Vector3 (0, 0, 0);
        Speed = 1.0f;
        Bounce = -1.0f;
        Friction = 1.0f;
        Mass = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Velocity * Speed * Friction * Time.deltaTime;
    }

    private void SelfDestuct()
    {
        Debug.Log("Destroying bacteria");
        Destroy(this.gameObject);
    }

    //private void gravitateTo(Vector3 currentPos, Vector3 target)
    //{
    //    var grav = currentPos - target;
    //    var dist = grav.magnitude;
    //    grav.Normalize();
    //    grav *= (1 / (dist * dist));
    //    Velocity += grav;
    //}

    void OnTriggerEnter2D(Collider2D other)
    {
        var heart = other.GetComponent<HeartScript>();
        if (heart != null)
        {
            heart.ColidedWithBacteria();
            SelfDestuct();
        }
    }
}
