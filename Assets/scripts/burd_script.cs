using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burd_script : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrenght;
    public bool birdIsAlive = true;
    public logic_management logic;
    public Sprite deadBirdSprite; // Add this line

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_management>();
        myRigidBody = GetComponent<Rigidbody2D>(); // Add this line
        myRigidBody.simulated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive && !logic.gameStarted)
        {
            logic.StartGame();
            myRigidBody.simulated = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive && logic.gameStarted)
        {
            myRigidBody.velocity = Vector2.up * flapStrenght;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            GetComponent<SpriteRenderer>().sprite = deadBirdSprite;
            birdIsAlive = false;
            logic.gameOver();
        }
    }
}
