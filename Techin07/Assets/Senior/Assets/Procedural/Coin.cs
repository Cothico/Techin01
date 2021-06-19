using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	//public Text coinText;
	//GBvalues gbValues;



	protected void Awake()
	{

		//gbValues = FindObjectOfType<GBvalues>();
	}


	protected void Start()
	{
		//coinText.text = "" + gbValues.coinPoints;
	}


	// Update is called every frame, if the MonoBehaviour is enabled.
	protected void Update()
	{
		//StartCoroutine("colorChange");
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			GetComponent<CircleCollider2D>().enabled = false;
			GetComponent<SpriteRenderer>().enabled = false;
			//gbValues.coinPoints += 1;
			//coinText.text = "" + gbValues.coinPoints;
		}
	}

	public void updateCoinCounter()
	{
		//coinText.text = "" + gbValues.coinPoints;
	}



	IEnumerator colorChange()
	{
		GetComponent<SpriteRenderer>().color = Color.red;
		yield return new WaitForSeconds(2f);
		GetComponent<SpriteRenderer>().color = Color.blue;
	}
}
