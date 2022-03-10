using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBE1 : MonoBehaviour
{
    public Camera mainCamera;
    public LayerMask cube;
    public float tocdo = 50;
  
    public Transform cube2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitinfo, Mathf.Infinity,cube))
        {
            if (Input.GetMouseButton(0))
            {
                if (hitinfo.collider.gameObject.layer == 8)
                {
                    transform.Translate((hitinfo.collider.transform.position - transform.position) * tocdo * Time.deltaTime) ;
                }
            }
            Debug.Log(hitinfo.collider.gameObject.name);

        }
    }
}
