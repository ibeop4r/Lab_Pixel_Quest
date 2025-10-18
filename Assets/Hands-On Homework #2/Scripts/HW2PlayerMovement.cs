using System.Runtime.CompilerServices;
using UnityEngine;

public class HW2PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2d;

    private float _xSpeed;
    private float _ySpeed;

    private float speed = 3;

    private string InputX = "Horizontal";
    private string InputY = "Vertical";

       private void Start()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _xSpeed = Input.GetAxis("Horizontal");
        _ySpeed = Input.GetAxis("vertical");

        _rigidbody2d.velocity = new Vector2(_xSpeed, _ySpeed) * speed;
    }
}
