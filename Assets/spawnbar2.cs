using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbar2 : MonoBehaviour
{
    public float maxtime2;
    private float timer2 = 0;
    public GameObject coins;
    public float height2;
    public float breadth;

    // Start is called before the first frame update
    void Start2()
    {
        
    }

    // Update is called once per frame
    void Update2()
    {
        if(timer2>maxtime2){
            GameObject newcoins = Instantiate(coins);
            newcoins.transform.position = transform.position + new Vector3(Random.Range(-breadth,breadth),Random.Range(-height2,height2),0);
          
            Destroy(newcoins,15);
            timer2 = 0;
        }
        timer2+=Time.deltaTime;
    }
}
