using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnCollisionEnter(Collision collider)
    {
        int y = CollisionCounter();
        print(collider.gameObject.name + " has bounced " + y + " times");
    }

    int CollisionCounter()
    {
        int x = 0;
        int a = 1;
        while (x<=100)
        {
            int sum = x+a;
        }

    }    // Update is called once per frame
    void Update()
    {
        
    }
}
