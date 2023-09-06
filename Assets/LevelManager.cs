using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject[] level1Objects;
    public GameObject[] level2Objects;
    public GameObject[] level3Objects;
    public GameObject[] level4Objects;
    public GameObject[] level5Objects;
    public GameObject[] level6Objects;
    public GameObject[] level7Objects;
    public GameObject[] level8Objects;
    public GameObject[] level9Objects;
    public GameObject[] level10Objects;

    public void StartLevel(int level)
    {
        // Dezactivați toate obiectele
        DisableAllObjects();

        // Activați obiectele specifice nivelului selectat
        switch (level)
        {
            case 1:
                EnableObjects(level1Objects);
                break;
            case 2:
                EnableObjects(level2Objects);
                break;
            case 3:
                EnableObjects(level3Objects);
                break;
            case 4:
                EnableObjects(level4Objects);
                break;
            case 5:
                EnableObjects(level5Objects);
                break;
            case 6:
                EnableObjects(level6Objects);
                break;
            case 7:
                EnableObjects(level7Objects);
                break;
            case 8:
                EnableObjects(level8Objects);
                break;
            case 9:
                EnableObjects(level9Objects);
                break;
            case 10:
                EnableObjects(level10Objects);
                break;
            default:
                Debug.LogError("Nivelul selectat nu este valid.");
                break;
        }
    }

    private void DisableAllObjects()
    {
        // Dezactivați toate obiectele din scenă
        // Iterați peste toate obiectele dvs. și folosiți gameObject.SetActive(false)
        
    }

    private void EnableObjects(GameObject[] objects)
    {
        // Activați obiectele primite ca parametrii
        foreach (GameObject obj in objects)
        {
            obj.SetActive(true);
        }
    }
}
