using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Rigidbody2D rb;
    //public GameObject cavalo;
    public GameObject point;
    Transform goal;

    //private float lenght, startpos;

    // Start is called before the first frame update
    void Start()
    {
        //startpos = transform.position.x;
        goal = GameObject.Find("TestePlayer").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, goal.position);
        //transform.position = new Vector3(startpos, transform.position.y, transform.position.z);
    }
}
