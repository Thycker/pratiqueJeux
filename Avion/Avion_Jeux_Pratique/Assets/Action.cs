using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D myPlayer;
    void Start()
    {
        myPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Mouvement = Input.GetAxis("Vertical") * Time.deltaTime * 10;
        Vector2 monVecteur = new Vector2(0, Mouvement);
        if (myPlayer.transform.position.y + Mouvement > 4.5 || myPlayer.transform.position.y + Mouvement < -4.5)
        { 
        
        }
        else
        {
            gameObject.transform.Translate(0, Mouvement, 0);
        }
    }
}
