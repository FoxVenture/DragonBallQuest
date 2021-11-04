using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScouterMaterial : MonoBehaviour
{
    List<Material> myMaterials;
    [SerializeField] Material newMat;
    Color materialcolor;
    // Start is called before the first frame update
    void Start()
    {
        myMaterials = GetComponent<Renderer>().materials.ToList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColour()
    {
        materialcolor.r = newMat.color.r;
        materialcolor.g = newMat.color.g;
        materialcolor.b = newMat.color.b;

        foreach (Material matt in myMaterials)
        {
            if (matt.name == "Scouter Lens Equiped")
            {
                matt.color = materialcolor;
            }
 }
    }
}
