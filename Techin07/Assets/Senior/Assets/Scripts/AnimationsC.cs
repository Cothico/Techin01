using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class AnimationsC : MonoBehaviour
{

    public Rigidbody2D playerRb;

    [SerializeField] private LayerMask platformLayerMask;

    public int nroPulosAcess;
    public bool segundoPulo;

    //PuloDuplo
    public bool freePuloDuplo;
    private int nroPulos;
    //public int checkMana;

    public static bool isGround;

    ManaC manaC;

    //Animação
    private int i;
    private int n = 4;
    public Animator animator;

    //Pular
    public float speed;
    public float distance;

    public Transform groudCheck;

    //TESTE
    public float JumpForce;
    private Rigidbody2D rig;
    private AudioSource som;

    //SOM
    AudioSource somPulo;

    private CapsuleCollider2D boxCollider2d;
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Correr", true);
        animator.SetBool("Pular", false);
        //TESTE
        rig = GetComponent<Rigidbody2D>();
        boxCollider2d = transform.GetComponent<CapsuleCollider2D>();

        //MANA
        manaC = GetComponent<ManaC>();
        freePuloDuplo = false;
        //nroPulos = 1;
        segundoPulo = false;
        som = GetComponent<AudioSource>();
        som.enabled = true;

        somPulo = GameObject.Find("SomPulo").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        LayerMask platformLayerMask = LayerMask.GetMask("ground");

        animator.SetBool("Correr", true);
        animator.SetBool("Pular", false);

        //checkMana = ManaC.manaAcess;
        isGround = IsGrounded();

        nroPulosAcess = nroPulos;


        if (manaC.mana >= 10)
        {
            nroPulos = 2;
        }

        if (isGround == false)
        {
            som.enabled = false;
        }
        if (isGround == true)
        {
            som.enabled = true;
        }

        Jump2();

    }

    void Jump2()
    {
        if (Input.GetKeyDown(KeyCode.Space) && nroPulos >= 1 && isGround == true)
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGround == false && nroPulos == 2 && segundoPulo == false)
        {
            //Debug.Log("SegundoPulo");
            nroPulos = 1;
            Jump();
            manaC.mana -= 10;
            if (manaC.mana < 0)
            {
                manaC.mana = 0;
            }
            segundoPulo = true;

        }
        if (isGround == true)
        {
            nroPulos = 1;
            segundoPulo = false;
        }

    }
    void CheckInput()
    {
        if (IsGrounded() && manaC.mana >= 1)
        {
            Debug.Log("manas > 1");
            //nroPulos = 2;
        }
        else if (IsGrounded() && manaC.mana == 0)
        {
            Debug.Log("mana = 0");
            //nroPulos = 1;
        }
        else
        {
            //Debug.Log("fora do chao");
            //nroPulos = 0;
        }

        /* if (IsGrounded() )
         {
             nroPulos = 1;
             if (ManaC.manaAcess >= 1)
             {
                 nroPulos = 2;
                 ManaC.manaAcess = -1;
             }
         }

         if(Input.GetKeyDown(KeyCode.Space) && nroPulos > 0)
         {
             Jump();
         }*/
    }

    void Jump()
    {

        //rig.velocity = Vector2.up * JumpForce;
        //rig.AddForce(new Vector2(0, 3) * JumpForce * Time.deltaTime);
        //rig.AddForce(Vector3.up * JumpForce * Time.deltaTime);
        rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
        somPulo.Play();
        for (i = 1; i <= n; i++)
        {
            //transform.Translate(Vector2.up * speed * Time.deltaTime);
            if (i == 1)
            {
                //rig.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
                animator.SetBool("Pular", true);
                animator.SetBool("Correr", false);
            }
            else if (i == 2)
            {
                animator.SetBool("Planar", true);
                animator.SetBool("Correr", false);
            }
            else if (i == 3)
            {
                animator.SetBool("Cair", true);
                animator.SetBool("Correr", false);
            }
            else if (i == 4)
            {
                animator.SetBool("Correr", true);
                break;
            }
        }
    }

    private bool IsGrounded()
    {
        float extraHeightText = 0.5f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, extraHeightText, platformLayerMask);
        //RaycastHit2D raycastHit = Physics2D.BoxCast(transform.position, transform.forward, 20f, Vector2.down,  platformLayerMask);
        //RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, transform.forward, 20f, platformLayerMask);

        Color rayColor;
        if (raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        //Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(0, 0), Vector2.down * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
        Debug.DrawRay(boxCollider2d.bounds.center + new Vector3(boxCollider2d.bounds.extents.x, -1.3f), Vector2.down * extraHeightText, rayColor);
        Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, 1.3f), Vector2.down * extraHeightText, rayColor);
        Debug.DrawRay(boxCollider2d.bounds.center - new Vector3(boxCollider2d.bounds.extents.x, boxCollider2d.bounds.extents.y), Vector2.right * (boxCollider2d.bounds.extents.y + extraHeightText), rayColor);
        return raycastHit.collider != null;
    }

 
}