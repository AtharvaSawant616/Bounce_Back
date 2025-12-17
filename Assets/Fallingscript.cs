using UnityEngine;

public class Fallingscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Obstacle;
    public GameObject Coin;
    public GameObject Powerup;
    private movementscript m;
    float wait = 3f;
    
    void Start()
    {
        InvokeRepeating("Fall", wait, wait-0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Fall()
    {
        int i = Random.Range(0, 3);
        if (i==0)
        {
            Instantiate(this.Obstacle, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
        }
        else if (i==1)
        {
            Instantiate(this.Coin, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
        }
        else if (i==2)
        {
            Instantiate(this.Powerup, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity);
        }
        
    }
}
