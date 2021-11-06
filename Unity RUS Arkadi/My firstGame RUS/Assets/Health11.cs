using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health11 : MonoBehaviour
{
    public int hp;
    public GameObject myHealth;
    public GameObject spawner;
    public GameObject winText;
    public GameObject guide;
 
    
    
    void Start()
    {
        hp = 10;
        myHealth.GetComponent<Text>().text = "Health:" + hp;
        winText.SetActive(false);
        guide.SetActive(false);

    }

    
    void Update()
    {
        myHealth.GetComponent<Text>().text = "Health:" + hp;
        if (hp <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
            Debug.Log("Eto rabotjet!!");
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "danger")
        {
            hp--;
        }

        if (collision.gameObject.tag == "finish")
        {
            spawner.SetActive(true);
            winText.SetActive(true);
            guide.SetActive(true);
            
            

        }

        
    }




}
