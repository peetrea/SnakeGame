using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelObstacles : MonoBehaviour
{
    public static LevelObstacles Instance { get; private set; }
    public GameObject Level1Objects;
    public GameObject Level2Objects;
    public GameObject Level3Objects;
    public GameObject Level4Objects;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
}
