using UnityEngine;
using UnityEngine.InputSystem; 

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody2D;
    public float flapStrength;
    void Start()
    {
        gameObject.name = "Bobby Bird";
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            myRigidbody2D.linearVelocity = Vector2.up * flapStrength;
        }
    }
}