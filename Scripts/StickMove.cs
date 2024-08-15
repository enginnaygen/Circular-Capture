using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMove : MonoBehaviour
{
    Vector2 mousePos;
    [SerializeField] float stickSpeed;

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(mousePos.x < 0 && Input.GetMouseButton(0)) //sol // if (Input.GetKey(KeyCode.A) ||
        {
            transform.Rotate(new Vector3(0, 0, -1 * stickSpeed * Time.deltaTime));
        }
        if(mousePos.x>=0 && Input.GetMouseButton(0)) //sag //if (Input.GetKey(KeyCode.D)||
        {
            transform.Rotate(new Vector3(0, 0, stickSpeed * Time.deltaTime));

        }
    }

}
