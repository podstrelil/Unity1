using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    
    public void TakeDamage()
    {
        health--;
        if(health<= 0)
        {
            Destroy(gameObject);


        }

    }
}

