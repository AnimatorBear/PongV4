using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRemover : MonoBehaviour
{
    public float timeToLive;
    public bool disable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToLive -= Time.deltaTime;
        if(timeToLive < 0)
        {
            if (disable)
            {
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
