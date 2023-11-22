using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _speed;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rb.AddForce(0f, 0f, 1f * _speed);
        }else if(Input.GetKey(KeyCode.DownArrow))
        {
            _rb.AddForce(0f, 0f, -1f * _speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rb.AddForce(1f * _speed, 0f, 0f);
        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rb.AddForce(-1f * _speed, 0f, 0f);
        }
    }
}
