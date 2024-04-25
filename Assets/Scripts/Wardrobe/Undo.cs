using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Undo : MonoBehaviour
{
    public Image characterJumper;
    public Image characterPants;
    public Image characterDreses;
    public Image defaultJumper;
    public Image defaultPants;
    public Image defaultDreses;
    public void Dresses()
    {
        characterJumper.sprite = defaultJumper.GetComponent<Image>().sprite;
        characterJumper.color = defaultJumper.GetComponent<Image>().color;
        characterPants.sprite = defaultPants.GetComponent<Image>().sprite;
        characterPants.color = defaultPants.GetComponent<Image>().color;
        characterDreses.sprite = defaultDreses.GetComponent<Image>().sprite;
        characterDreses.color = defaultDreses.GetComponent<Image>().color;
    }

}