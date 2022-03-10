using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bai3 : MonoBehaviour
{
    public Camera maincamera;
    public Vector2 turn;
    float tocdoxoay = 50;
    public Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        rotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation);
        Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
        
            if (Input.GetMouseButton(0))
            {
                turn.x = Input.GetAxis("Mouse X"); // khi rê chuột sang trái thì giá trị âm và ngược lại
                turn.y = Input.GetAxis("Mouse Y"); //khi rê chuột lên trên thì giá trị dương và ngược lại
                if (turn.x > 0 || turn.y > 0)
                {
                    if (transform.rotation.y > rotation.y - 0.5)
                    {
                        transform.Rotate(Vector3.up, -tocdoxoay * Time.deltaTime);
                    }
                }
                if (turn.x < 0 || turn.y < 0)
                {
                    if (transform.rotation.y < rotation.y + 0.5)
                    {
                        transform.Rotate(Vector3.up, tocdoxoay * Time.deltaTime);
                    }
                }

            }
        
        
    }
}

