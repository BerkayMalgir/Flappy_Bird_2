
using System;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigigbody;
    public float flapStrenght;
    public LogicScript logic;
    public bool birdIsAlive = true;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic")?.GetComponent<LogicScript>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rigigbody.velocity = Vector2.up * flapStrenght;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
