using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float speed = 500f;
    [SerializeField] private float up = 500f;
    [SerializeField] private float down = 500f;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    private bool started;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float dikeyHareket = Input.GetAxis("Vertical");
        float yatayHareket = Input.GetAxis("Horizontal");

        Vector3 hareket = new Vector3(yatayHareket, 0, dikeyHareket);

        transform.Translate(hareket * speed * Time.deltaTime);




        /*if (Input.GetKeyDown(KeyCode.W))
        {
            _rigidbody2D.AddForce(new Vector2(0f, up));

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _rigidbody2D.AddForce(new Vector2(0f, down));
        } */
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(speed, _rigidbody2D.velocity.y);
        if (Input.GetKeyDown(KeyCode.W))
        {
            _rigidbody2D.AddForce(new Vector2(0f, up));

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _rigidbody2D.AddForce(new Vector2(0f, down));
        }
        /*if (started)
        {
            _rigidbody2D.velocity = new Vector2(speed, _rigidbody2D.velocity.y);   
        }*/
    }
}
