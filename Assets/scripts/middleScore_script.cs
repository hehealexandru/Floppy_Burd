using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleScore_script : MonoBehaviour
{
    public logic_management logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_management>();
    }

    void Update()
    {

    }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.layer == 3)
            {
                logic.addScore(1);
            }
        }
    
}
