using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    //public int acessStamina;

    public float atributoForca;

    public Slider staminaBar;

    public float maxStamina = 100;
    public float currentStamina;

    private WaitForSeconds regemTick = new WaitForSeconds(0.1f);
    private Coroutine regen;

    public static StaminaBar instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        currentStamina = maxStamina;
        staminaBar.maxValue = maxStamina;
        staminaBar.value = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        //acessStamina = staminaBar.value;
    }

    public void UseStamina(int amount)
    {
        if(currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            staminaBar.value = currentStamina;

            if(regen != null)
            {
                StopCoroutine(regen);
            }

            regen = StartCoroutine(RegenStamina());
        }
        else
        {

        }
    }

    private IEnumerator RegenStamina()
    {
        yield return new WaitForSeconds(1);

        while(currentStamina < maxStamina)
        {
            float bla = atributoForca * 0.25f;

            currentStamina += maxStamina / 100 + bla;
            staminaBar.value = currentStamina;
            yield return regemTick;

        }
    }
}
