using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteF : MonoBehaviour
{
    public Vector2 destination;
    public GameObject point;
    public Transform cavalo;

    // Start is called before the first frame update
    void Start()
    {
        //cavalo = GameObject.FindGameObjectWithTag("FollowPoint").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.Lerp(transform.position, destination, Time.deltaTime);
        //transform.position = Vector2.Lerp(transform.position, cavalo, Time.deltaTime);
    }
}
