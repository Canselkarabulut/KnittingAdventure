using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButtonActive : MonoBehaviour
{
    public Button resetButton; // Açılacak olan buton

    void Start()
    {
        resetButton.gameObject.SetActive(false); // Buton başlangıçta gizli olsun
    }

    void Update()
    {
        if (Input.touchCount == 4 ||Input.GetKeyDown(KeyCode.Space)) // Eğer dört parmak ekrana dokunuyorsa
        {
            resetButton.gameObject.SetActive(true); // Butonu göster
        }
      //  else
      //  {
      //     // resetButton.gameObject.SetActive(false); // Dokunma sayısı 4'ten azsa butonu gizle
      //  }
        
    }
}
