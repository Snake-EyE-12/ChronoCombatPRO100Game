using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    public void Reset()
    {
        MapManager.Instance().levelCount = 0;
    }
}
