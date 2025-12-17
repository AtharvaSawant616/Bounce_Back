using UnityEngine;
using UnityEngine.UI;

public class obsdetectionscript : MonoBehaviour
{
    private movementscript m;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Lives.text = "Lives:" + m.lives;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Obstacle")
        {
            Debug.Log("Player damaged.");
            GameObject platform = GameObject.Find("Trampoline");
            m = platform.GetComponent<movementscript>();
            m.lives -= 1;
            Destroy(col.gameObject);
            if(m.lives==0)
            {
                Debug.Log("GAME OVER!");
            }
        }
        if(col.gameObject.tag=="Coin" || col.gameObject.tag=="Powerup")
        {
            Destroy(col.gameObject);
        }
    }
}
