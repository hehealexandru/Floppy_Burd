using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawner_script : MonoBehaviour
{
    public GameObject pipe;
    [HideInInspector]
    public float spawnRate = 1f;
    private float timer = 0f;
    public float heightOffset = 10f;
    public logic_management logic;
    private int lastScoreChecked = 0;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_management>();
        spawnPipe();
    }

    void Update()
    {
        if (!logic.gameOverScreen.activeSelf)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                spawnPipe();
                timer = 0f;
            }

           
            if (logic.playerScore != lastScoreChecked)
            {
                int difference = logic.playerScore - lastScoreChecked;
                spawnRate -= 0.02f * difference;

                
                if (spawnRate < 0.5f)
                {
                    spawnRate = 0.5f;
                }

                lastScoreChecked = logic.playerScore;
            }
        }
        else
        {
            spawnRate = 10000f; 
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0f), transform.rotation);
    }
}
