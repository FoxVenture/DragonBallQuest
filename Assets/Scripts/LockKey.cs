using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockKey : MonoBehaviour
{
    // Unlocked by default. Set 1 or 2 locks to locked in the inspector
    [SerializeField] bool isLocked_1, isLocked_2 = false;

    void Start()
    {
        
    }

    // Unlock locks
    public void UnlockLockOne()
    {
        isLocked_1 = false;
    }

    public void UnlockLockTwo()
    {
        isLocked_2 = false;
    }

    // Lock locks
    public void LockLockOne()
    {
        isLocked_1 = true;
    }

    public void LockLockTwo()
    {
        isLocked_2 = true;
    }

    //Check locks
    public bool CheckIsLockedOne()
    {
        return isLocked_1;
    }

    public bool CheckIsLockedTwo()
    {
        return isLocked_2;
    }

    public bool CheckIsLockedBoth()
    {
        if (!isLocked_1 && !isLocked_2) return false;
        
        return true;
    }

}
