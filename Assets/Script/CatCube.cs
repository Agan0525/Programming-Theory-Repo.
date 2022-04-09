using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCube : BaseCube
{
    // 需要在这里完成继承（重载和复写）
    // Start is called before the first frame update
    // Update is called once per frame
    private void Start() {
        playerRb = GetComponent<Rigidbody>();
        names = "Cat";
        rotationSpeed = 200;
        color = Color.green;
        GetComponent<Renderer>().material.color = color;
    }
     void Update()
    {
        Rotate();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int power = 300;
            Jump(power);

        }
    }
    public override void Rotate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.down, 2*rotationSpeed * Time.deltaTime * horizontalInput);
    }
}
