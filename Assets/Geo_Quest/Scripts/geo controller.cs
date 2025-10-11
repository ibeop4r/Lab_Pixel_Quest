using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class geocontroller : MonoBehaviour
{
    string varibleOne = "hello ";
    Rigidbody2D rb;
    public float speed = 10;
    int num = 1;
    string nextlevel = "geo_quest_scene_2";
    // Start is called before the first frame update
    void Start()
    {
        string varibleTwo = "world";
        Debug.Log("helloworld");
        Debug.Log(varibleOne + varibleTwo);

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // transform.position += new Vector3(-0.01f, 0, 0);
        // rb.velocity = Vector3.left;
        float xinput = Input.GetAxis("Horizontal");
        rb. velocity=new Vector2 (xinput*speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;
                }

        }

    }
}
