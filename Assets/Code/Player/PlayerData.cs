using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData
{
    public int xp;
    public int level;
    
    public bool hasUnlockedMap;
    
    public Dictionary<string, bool> characterUnlockTable;


}
