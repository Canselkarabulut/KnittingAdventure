using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Tumbnails : MonoBehaviour
{
    private Vector3 _imageNewPosition;
    [HideInInspector]public GameObject _obj;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="row"></param> // satır   //22
    /// <param name="col"></param> //stun     //22
    ///
    /// startRow // satır başlangıcı
    /// startCol // stun Başlangını
    public void Stitch(GameObject imagePrefabInstantiate, GameObject parentInstantiate, int startRow, int EndRow,
        int startCol, int Endcol) //Kare diz
    {
        for (int y = startCol; y < Endcol; y++)
        {
            for (int x = startRow; x < EndRow; x++)
            {
                _imageNewPosition = new Vector3(transform.position.x + x * .2f, transform.position.y + y * .2f,
                    transform.position.z);
                _obj = Instantiate(imagePrefabInstantiate, _imageNewPosition, transform.rotation,
                    parentInstantiate.transform);
                _obj.gameObject.name = "x: " + x + "y: " + y;
            }
        }
    }
    public void Stitch(GameObject imagePrefabInstantiate, GameObject parentInstantiate, int startRow, int EndRow,
        int startCol, int Endcol,Color color) 
    {
        for (int y = startCol; y < Endcol; y++)
        {
            for (int x = startRow; x < EndRow; x++)
            {
                _imageNewPosition = new Vector3(transform.position.x + x * .2f, transform.position.y + y * .2f,
                    transform.position.z);
                _obj = Instantiate(imagePrefabInstantiate, _imageNewPosition, transform.rotation,
                    parentInstantiate.transform);
                _obj.GetComponent<Image>().color = color;
                _obj.gameObject.name = "x: " + x + "y: " + y;
              
            }
        }
    }
}