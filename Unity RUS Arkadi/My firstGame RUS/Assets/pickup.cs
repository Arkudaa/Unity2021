using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class pickup : MonoBehaviour
{
  
    public int score;
    public AudioSource coinmusic;
    public GameObject coinText;
   // public int health;
    
    
    
    
    void Start()
    { score = 0;
        coinText.GetComponent<Text>().text = "Score:" + score;
       
    }

   
    void Update()
    {
        coinText.GetComponent<Text>().text = "Score:" + score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            
            Destroy(collision.gameObject);
            coinmusic.Play();
            score++;
            



        }
    }



}
