using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFirstMove : MonoBehaviour
{
    [SerializeField] float startSpeed = -4f;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, startSpeed);
    }

}
