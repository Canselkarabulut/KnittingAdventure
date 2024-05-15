using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{

    public GameObject image1;
    public Camera mainCamera;
    public LayerMask canvasLayer; 
    void Update()
    {
        Vector2 center = image1.GetComponent<RectTransform>().position;
        Vector2 rayDirection = new Vector2(-1, -1);
        // Back yönünde bir ray oluştur
        RaycastHit2D hit =  Physics2D.Raycast(center, rayDirection,1000);
        if (hit.collider != null)
        {
            // Ray bir şeye çarptıysa
            Debug.Log("Ray bir şeye çarptı: " + hit.collider.gameObject.name);
            Debug.DrawLine(center, rayDirection, Color.red,1000);

        }
        else
        {
            // Ray hiçbir şeye çarpmadıysa
            Debug.Log("Ray hiçbir şeye çarpmadı.");
            Debug.DrawLine(center, rayDirection, Color.green,1000);
        }
    }
}
