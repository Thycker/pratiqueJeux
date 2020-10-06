using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnnemy : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveLeft();
    }

    private void moveLeft()
    {
        transform.Translate(-1*Time.deltaTime * 2, 0, 0);
    }
}
