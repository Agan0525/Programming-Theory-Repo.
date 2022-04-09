using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCube : BaseCube
{
    // Start is called before the first frame update

    private void Start() {
        playerRb = GetComponent<Rigidbody>();
        names = "Dog";
        rotationSpeed = 100;
        color = Color.red;
        GetComponent<Renderer>().material.color = color;
    }
    // Update is called once per frame
     void Update()
    {
        Rotate();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(Vector3.up*6666);

        }
    }

}
