using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleScore_script : MonoBehaviour
{
    public logic_management logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_management>();
    }

    // Update is called once per frame
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
