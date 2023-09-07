using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{
public GameObject q;
public GameObject w;
public GameObject e;
public GameObject r;
public GameObject t;
public GameObject y;
public GameObject U;

void OnTriggerStay2D(Collider2D other)
         {
            if (other.tag==("wall"))
            {
        
              q.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("cerf");
              w.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("cerf");
              e.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("cerf");
              r.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("cerf");
              t.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("cerf");
              y.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("cerf");
              U.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("cerf");
            }
}
void OnTriggerExit2D(Collider2D other){q.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");
              w.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");
              e.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");
              r.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");
              t.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");
              y.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");
              U.GetComponent<Renderer>().sortingLayerID = SortingLayer.NameToID("Default");}
}
