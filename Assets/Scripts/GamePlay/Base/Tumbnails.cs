using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public abstract class Tumbnails : MonoBehaviour
{
    private Vector3 _imageNewPosition;
    [HideInInspector] public GameObject _obj;


    /// <summary>
    /// 
    /// </summary>
    /// <param name="row"></param> // satır   //22
    /// <param name="col"></param> //stun     //22
    ///
    /// startRow // satır başlangıcı
    /// startCol // stun Başlangını
    ///
    

    public GameObject Stitch(GameObject imagePrefabInstantiate, GameObject parentInstantiate, int startRow, int EndRow,
        int startCol, int Endcol) //Kare diz
    {
        for (int y = startCol; y < Endcol; y++)
        {
            for (int x = startRow; x < EndRow; x++)
            {
                _imageNewPosition = new Vector3(transform.position.x + x * .155f, transform.position.y + y * .155f,
                    transform.position.z);
                _obj = Instantiate(imagePrefabInstantiate, _imageNewPosition, transform.rotation,
                    parentInstantiate.transform);
                _obj.gameObject.name = "x: " + x + "y: " + y;
                _obj.AddComponent<StitchState>();


            }
        }

        return _obj;
    }

    // public Texture2D foregroundImage; // Ön plan resmi
    [Header("PixelColors")] 
    
    [SerializeField] protected Image before2Image;
    [SerializeField] protected  Image before1Image;
    [SerializeField] protected  Image nowImage;
    [SerializeField] protected  Image after1Image;
    [SerializeField] protected  Image after2Image;
    [SerializeField] protected  Image woolBeforeImage;
    [SerializeField] protected  Image woolNowImage;
    [SerializeField] protected  Image woolAfterImage;
    public GameObject Stitch(GameObject imagePrefabInstantiate, GameObject parentInstantiate, int startRow, int EndRow,
        int startCol, int Endcol, Texture2D levelTexture2d, List<Color> colorArrayList) //backgroundStitch
    {
        for (int y = startCol; y < Endcol; y++)
        {
            for (int x = startRow; x < EndRow; x++)
            {
                _imageNewPosition = new Vector3(transform.position.x + x * .155f, transform.position.y + y * .155f,
                    transform.position.z);
                _obj = Instantiate(imagePrefabInstantiate, _imageNewPosition, transform.rotation,
                    parentInstantiate.transform);
                _obj.GetComponent<Image>().color = levelTexture2d.GetPixel(x, y);
                _obj.gameObject.name = "bg.x: " + x + "bg.y: " + y;
                var a = _obj.AddComponent<BoxCollider2D>().size = new Vector2(94, 94);
                colorArrayList.Add(levelTexture2d.GetPixel(x, y));
                _obj.AddComponent<StitchState>();
            }
        }

        return _obj;
    }
    
}