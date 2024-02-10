using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly_Body_up : MonoBehaviour
{
    Rigidbody rigiStarship;
    public float forceStrength = 10f;
    AudioSource audioStarship;
    // Start is called before the first frame update
    void Start()
    {
        audioStarship= GetComponent<AudioSource>();
        rigiStarship = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RotationInput();
        Launch();
    }
    void Launch()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigiStarship.AddRelativeForce(Vector3.up * forceStrength);
            if (!audioStarship.isPlaying)
            {
                audioStarship.Play();
            }

        }
        else
        {
            audioStarship.Pause();
        }
    }
    void RotationInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigiStarship.AddRelativeTorque(new Vector3(0, 0, -3));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigiStarship.AddRelativeTorque(new Vector3(0, 0, 3));
        }
        if (Input.GetKey(KeyCode.S))
        {
            //rigiStarship.freezeRotation = true;
            rigiStarship.AddRelativeTorque(new Vector3(-3, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            //rigiStarship.freezeRotation = true;
            rigiStarship.AddRelativeTorque(new Vector3(3, 0, 0));
        }
    }
}
