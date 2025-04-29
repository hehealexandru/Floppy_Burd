using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_script : MonoBehaviour
{
    public float moveSpeed = 15f;
    public float deadZone = -35f;
    public logic_management logic;
    private int lastScoreChecked = 0;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_management>();
    }

    void Update()
    {
        if (!logic.gameOverScreen.activeSelf)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            if (logic.playerScore != lastScoreChecked)
            {
                int difference = logic.playerScore - lastScoreChecked;
                moveSpeed += 0.2f * difference;
                lastScoreChecked = logic.playerScore;
            }
        }
        else
        {
            moveSpeed = 0f;
        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
