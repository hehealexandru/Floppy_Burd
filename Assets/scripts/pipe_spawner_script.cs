using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spawner_script : MonoBehaviour

{
    public GameObject pipe;
    [HideInInspector]
    public float spawnRate = 4;
    private float timer = 0;
    public float heightOffset = 10;
    public logic_management logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_management>();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.gameOverScreen.activeSelf) // check if game is not over
        {
            if (timer < spawnRate)
            {
                timer = timer + Time.deltaTime;
            }
            else
            {
                spawnPipe();
                timer = 0;
            }
        }
        if (logic.gameOverScreen.activeSelf)
        {
            spawnRate = 100000;

        }
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}