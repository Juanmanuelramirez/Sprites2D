using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour
{
    Animator _anim;

    bool shoot;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Movements();
        {
            float move = Input.GetAxis("Horizontal");
            bool walking = move != 0 ? true : false;
            _anim.SetBool("Walking", walking);
            _anim.SetBool("Shoot", shoot);
        }
    }

    void Movements()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * 3f * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, -180);
        }

        shoot = Input.GetKey(KeyCode.R) ? true : false;
    }
}
