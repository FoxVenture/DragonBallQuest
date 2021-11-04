using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScouterController : MonoBehaviour
{
    [SerializeField]
    LockAndKeyController screwLock, insideLock;

    bool screwlocked;
    bool insidelocked;

    void Start()
    {
        screwlocked = true;
        insidelocked = true;
    }

    void Update()
    {
        /*
        if(screwlocked)
        {
            if(!screwLock.getLocked())
            {
                screwlocked = false;
            }
        }

        if(!screwlocked && insidelocked)
        {
            if(!insideLock.getLocked())
            {
                insidelocked = false;
            }
        }
*/
    }
    
}
