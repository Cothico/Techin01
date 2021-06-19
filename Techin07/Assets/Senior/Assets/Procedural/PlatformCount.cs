using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformCount : MonoBehaviour
{
	GBvalues gbValues;
	Text platformText;

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		gbValues = GameObject.FindObjectOfType<GBvalues>();
		platformText = GameObject.Find("PlatformText").GetComponent<Text>();

		platformText.text = "" + 000;
	}

	public void updatePlatformCounter()
	{
		platformText.text = "" + gbValues.platformCount;
	}


	// OnTriggerEnter is called when the Collider other enters the trigger.
	protected void OnTriggerEnter2D(Collider2D other)
	{
		//print("trigger");
		if (other.CompareTag("Player"))
		{
			//print("collide");
			gbValues.platformCount += 1;
			platformText.text = "" + gbValues.platformCount;
			this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
		}
	}
}
