using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{


    private Animator animator;
    private Rigidbody2D rb2D;
    private Transform transform;
    public GameObject Attack_A;
    //public GameObject Attack_B;
    float x;
    float y;

    public float baseSpeed = 4f;
    private float modifiedSpeed;

    // Use this for initialization
    void Start()
    {
        transform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //mouvement related
        modifiedSpeed = baseSpeed + (baseSpeed / 2); //add agility modificator

//#if UNITY_STANDALONE || UNITY_WEBPLATER
		float input_x = Input.GetAxisRaw ("Horizontal");
		float input_y = Input.GetAxisRaw ("Vertical");
//#else
//#endif

        bool isWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;

        animator.SetBool("isWalking", isWalking);

        if (isWalking)
        {
            x = input_x;
            y = input_y;
            animator.SetFloat("xInput", x);
            animator.SetFloat("yInput", y);
        }

        // Move senteces
        rb2D.velocity = new Vector2(input_x * baseSpeed, input_y * baseSpeed);



    }

    void Update()
    {
        //Debug.Log(Time.deltaTime * 5);

        if (Input.GetButtonDown("Attack"))
        {
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg - 90;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            Instantiate(Attack_A, transform.position, rotation);
        }
    }


}
