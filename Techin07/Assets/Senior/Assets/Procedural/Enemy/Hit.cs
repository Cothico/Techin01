using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    public Animator anim;
    //Collider2D col;

    //StaminaBar staminaB;

    public Slider staminaBar;

    // Start is called before the first frame update
    void Start()
    {
        // col = GameObject.Find("Espada").GetComponent<BoxCollider2D>();
        //col.enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        //staminaB = GetComponent<StaminaBar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit") &&  staminaBar.value == 100)
        {

            StaminaBar.instance.UseStamina(100);
            HitOn();
        }
        else
        {
            anim.SetBool("Golpe", false);
            anim.SetBool("Cavalgar", true);
        }
    }

    IEnumerator ColliderActive()
    {
        yield return new WaitForSeconds(0.50f);
        GetComponent<BoxCollider2D>().enabled = false;
    }

    public void HitOn()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        anim.SetBool("Cavalgar", false);
        anim.SetBool("Golpe", true);
        StartCoroutine(ColliderActive());
    }
}
