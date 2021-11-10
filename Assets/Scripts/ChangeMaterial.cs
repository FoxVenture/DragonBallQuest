using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    [SerializeField] Material newMat;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        foreach(Material m in rend.materials)
        {
            if(m.name == "Scouter Lens Equiped")
            {
                Debug.Log("FOUND MATERIAL");
            }
        }

    }
}
