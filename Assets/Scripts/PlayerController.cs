using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int spriteRotation;

    private Animator _anim;
    private SpriteRenderer _sprt;
    private MovementBehaviour _mv;
    private Rigidbody2D _rb2d;
    private static Camera mainCamera;

    public Vector3 direction;
    private Vector3 cameraDir;

    // Start is called before the first frame update
    void Start()
    {
        _mv = GetComponent<MovementBehaviour>();
        _rb2d = GetComponent<Rigidbody2D>();

        _anim = GetComponent<Animator>();
        _sprt = GetComponent<SpriteRenderer>();
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        //float ver = Input.GetAxisRaw("Vertical");
        direction = new Vector3(hor, _rb2d.velocity.y);

        /*
        if (ver > 0.1 || hor > 0.1 ||
            ver < -0.1 || hor < -0.1)
        {
            _anim.SetInteger("State", 1);
            _anim.SetBool("IsWalking", true);
            _mv.RotateDirection(direction.normalized, spriteRotation);

        }
        else
        {
            _anim.SetInteger("State", 0);
            _anim.SetBool("IsWalking", false);
        }*/

        //_mv.MoveTowards(direction.normalized);
    }

    private void FixedUpdate()
    {
        _mv.MoveRB(direction.normalized);
    }
}
