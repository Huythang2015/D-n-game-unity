using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    // tạo 1 ray có điểm bát đầu = vị trí của camera hướng là con trỏ chuột
    //kiểm tra xem ray nó có chạm vào collider nào ko , nếu chạm vào collider thì thông thin gameobj được lưa vào biến tạm hitinfo
    // cho vị trí gameobj = với điếm va chạm của ray
    public Camera maincamera;
   
  
     void Update()
    {
      
        // tạo 1 ray có điểm bắt đầu = vị trí của camera hướng là con trỏ chuột
        Ray ray = maincamera.ScreenPointToRay(Input.mousePosition);
        // kiểm tra xem ray nó có chạm vào collider nào ko , nếu chạm vào collider thì thông thin gameobj được lưa vào biến tạm hitinfo
        if (Physics.Raycast(ray, out RaycastHit hitinfo)) 
        {
            if (Input.GetMouseButton(0))
            {
                transform.position = new Vector3(hitinfo.point.x,transform.position.y,hitinfo.point.z);// cho vị trí gameobj = với điếm va chạm của ray
            } 
        }
        Debug.DrawRay(ray.origin,ray.direction * 1000);


    }
}
