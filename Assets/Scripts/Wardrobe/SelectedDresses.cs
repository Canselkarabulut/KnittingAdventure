using UnityEngine;
using UnityEngine.UI;

public class SelectedDresses : MonoBehaviour
{
    public Image selected;
    public void Dresses()
    {
        selected.sprite = GetComponent<Image>().sprite;
        selected.color = GetComponent<Image>().color;
    }
}