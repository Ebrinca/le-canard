using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D fisica;
    private float velocidade = 3f;
    private void Awake()
    {
        this.fisica = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetMouseButtonDown(0)) 
            {
                {
                this.Impulsionar();
                }
            }
        }
    void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * 3, ForceMode2D.Impulse);
       // this.fisica.AddForce(Vector2.right * 2, ForceMode2D.Impulse);
    }
}
