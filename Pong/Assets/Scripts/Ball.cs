using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 100.0f;
    private void Awake()
    {
        _rigidbody= GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        addStartingForce();
    }
    private void addStartingForce()
    {
        float x = Random.value<0.5f? -1.0f: 1.0f;
        float y = Random.value < 0.5f? Random.Range(-1.0f, -0.5f): Random.Range(0.5f, 1.0f) ;
        Vector2 direc= new Vector2(x,y);
        _rigidbody.AddForce(direc * speed);
    }
}
