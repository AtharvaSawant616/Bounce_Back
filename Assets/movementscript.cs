using UnityEngine;
using UnityEngine.UI;

public class movementscript : MonoBehaviour
{
    public Text Lives;
    public Text Coins;
    public int lives=3;
    int coins = 0;
    float speed = 7.5f;
    Vector3 movement;
    float horizontal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            //horizontal = Input.GetAxis("Horizontal");
            movement = transform.position;
            movement.x += speed * Time.deltaTime;
            transform.position = movement;
        }
        if(Input.GetKey(KeyCode.A))
        {
            movement = transform.position;
            movement.x -= speed * Time.deltaTime;
            transform.position = movement;
        }
        Lives.text = "Lives:" + lives;
        Coins.text = "Coins:" + coins;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Obstacle")
        {
            Debug.Log("DESTROY!");
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag=="Coin")
        {
            coins += 1;
            Debug.Log("Collected.");
            Destroy(col.gameObject);
        }
        if(col.gameObject.tag=="Powerup")
        {
            Debug.Log("Collected.");
            Destroy(col.gameObject);
        }
    }
}
