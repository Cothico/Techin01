using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			GetComponent<CircleCollider2D>().enabled = false;
			GetComponent<SpriteRenderer>().enabled = false;

			StartCoroutine("EnabledTrue");
			//gbValues.coinPoints += 1;
			//coinText.text = "" + gbValues.coinPoints;
		}
	}


	IEnumerator EnabledTrue()
	{
		yield return new WaitForSeconds(2.0f);
		GetComponent<CircleCollider2D>().enabled = true;
		GetComponent<SpriteRenderer>().enabled = true;
	}
}
