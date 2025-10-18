using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayetMovement : MonoBehaviour
{ 
     private Rigidbody2D _rigidbody2D;
      public int speed = 4; 
    
    // Start is called before the first frame update
    void Start()
    {
      _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(horizontal * speed, _rigidbody2D.velocity.y);
    }

}
