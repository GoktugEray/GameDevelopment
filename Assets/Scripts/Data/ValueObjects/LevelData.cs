using System.Collections.Generic;
using System;

[Serializable]
public class LevelData 
{
    public List<PoolData> PoolList = new List<PoolData>();
}

[Serializable]
public struct PoolData
{
    public sbyte RequiredObjectCount;
}