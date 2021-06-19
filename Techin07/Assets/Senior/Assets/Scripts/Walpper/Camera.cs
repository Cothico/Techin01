using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Rigidbody2D rb;
    //private float scrollSpeed = 2f;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        //scrollSpeed =+ Time.deltaTime;
        //rb.velocity = new Vector2(scrollSpeed, 0);
        //rb.velocity = new Vector2(2f, 0f);
        //transform.position += velocity * Time.deltaTime * Speed;

        //Vector3 movement = new Vector3(2f, 0f, 0f);
        //rb.transform.position += movement * Time.deltaTime * Speed;
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(2f, 0f, 0f);
        rb.transform.position += movement * Time.deltaTime * Speed;
    }
               
}
