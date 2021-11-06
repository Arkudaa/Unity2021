using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public GameObject myHealth;
    public int health;
    
    void Start()
    {
        health = 10;
        myHealth.GetComponent<Text>().text = "Health:" + health;
    }

    
    void Update()
    {
        
    }



}
