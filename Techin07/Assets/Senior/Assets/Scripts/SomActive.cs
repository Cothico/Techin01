using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomActive : MonoBehaviour
{
    public bool isMadera;

    public GameObject audioMoeda;
    public GameObject newAudio;

    AudioSource bla;
    private void Start()
    {
        //bla = GameObject.Find("SomPedra").GetComponent<AudioSource>();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player") == true)
        {
            newAudio = Instantiate(audioMoeda, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            //Destroy(gameObject); 
            //bla.Play();
        }
    }

   /* public void OnCollisionEnter2D(Collision2D col)
    {
        if (isMadera)
        {
            newAudio = Instantiate(audioMoeda, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
        else
        {
            if (col.gameObject.CompareTag("Player") == true)
            {
                //newAudio = Instantiate(audioMoeda, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                //Destroy(gameObject); 
                if(bla != null)
                {
                    bla.Play();
                }
                
            }
        }
  
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") == true)
        {
            //newAudio = Instantiate(audioMoeda, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            //Destroy(gameObject); 
            bla.Stop();
            //bla.loop = false;
        }        
        //newAudio = GetComponent<AudioSource>().loop(false);
        //Destroy(newAudio.gameObject);
    }*/

}
