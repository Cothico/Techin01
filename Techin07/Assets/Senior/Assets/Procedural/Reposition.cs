using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    public LevelGenerator lg;

    private void OnTriggerEnter2D(Collider2D other)
    {

        //if(onPause)
        //{
        //	return;
        //}

        /*if (other.tag == "MovingGround")
        {
            lg.PlaceGround(other.gameObject);
            lg.GetBorderNew(other.gameObject);
        }*/
        if (other.CompareTag ("MovingGround") == true)
        {
            //halfBlockSize = GetComponent<BoxCollider2D>().bounds.extents.x;

            Debug.Log("ColidiuTrigger");
            lg.PlaceGround(other.gameObject);
            lg.GetBorderNew(other.gameObject);
            //lg.PlaceGround(other.gameObject);            
        }
    }
}
