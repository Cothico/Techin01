using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEnemy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag ("Espada"))
        {
            GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CapsuleCollider2D>().enabled = false;
            //StartCoroutine("EnabledTrue");
            //gbValues.coinPoints += 1;
            //coinText.text = "" + gbValues.coinPoints;
        }
    }

    IEnumerator EnabledTrue()
    {
        yield return new WaitForSeconds(2.0f);
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = true;
        GetComponent<CapsuleCollider2D>().enabled = true;
        Debug.Log("Reabilitou Orq");
    }
}
