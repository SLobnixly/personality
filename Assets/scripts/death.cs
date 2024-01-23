using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public Movement moving;
    private Animator anim;
    bool timer;
    float timing = 1;
    
    private void Update()
    {
        if (timer == true) 
        {
        if (timing > 0) 
            {
            timing-= Time.deltaTime;
            }
        else
            {
                Restart();
            }

        }
    }
    private void Awake()
    {
        anim = GetComponent<Animator>(); 
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moving.die();
            Debug.Log("hit");
           
            timer = true;
        }
    } 
    
    public void Restart()
    {
        SceneManager.LoadScene("Restart");
    }
}
