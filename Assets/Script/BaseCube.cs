using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCube : MonoBehaviour
{
    // 需要在这完成抽象和多态（不同的Jump）done，辅助完成 封装（NAme和Color） done，
    // Start is called before the first frame update
    public string names {get;  set; }
    public float rotationSpeed {get;  set;}
    public Color color {get;  set;}
    public Rigidbody playerRb;

    // void Start()
    // {
    //     playerRb = GetComponent<Rigidbody>();
    //     //playerRb.AddForce(Vector3.up*1000);
    // }

    public void Jump(int hight)
    {
        playerRb.AddForce(Vector3.up*hight);
    }

    public void Jump(Vector3 hight)
    {
        playerRb.AddForce(hight);
    }

    public virtual void Rotate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime * horizontalInput);
    }


}
