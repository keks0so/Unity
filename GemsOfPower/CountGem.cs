using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountGem : MonoBehaviour
{
    public int ab_number_33;

    // Start is called before the first frame update
    public void Start()
    {
        var aboba=new List<bool>() {sc.Instance.ab1,sc.Instance.ab2,sc.Instance.ab3,sc.Instance.ab4,sc.Instance.ab5,sc.Instance.ab6,sc.Instance.ab7,sc.Instance.ab8,sc.Instance.ab9,sc.Instance.ab10};
        aboba[ab_number_33]=true;
    }

    
}
