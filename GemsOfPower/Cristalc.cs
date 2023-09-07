using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cristalc : MonoBehaviour

{
    public GameObject Gem;


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            Gem.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Gem.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("cerf");
    }
}

