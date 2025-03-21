using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public List<GameObject> enemies;
    
    public static StageManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
}
