using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour {

    // Settings
    public float MoveSpeed = 5;
    public float SteerSpeed = 180;
    public float BodySpeed = 5;
    public int Gap = 10;
    public int appleScore;
    public int pearScore;
    public int orangeScore;
    private GameplayManager gameplayManager;

    // References
    public GameObject BodyPrefab;

    // Lists
    private List<GameObject> BodyParts = new List<GameObject>();
    private List<Vector3> PositionsHistory = new List<Vector3>();

    void Start() 
    {
        gameplayManager = FindObjectOfType<GameplayManager>();
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
    }

    void Update() 
    {

        // Move forward
        transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        // Steer
        float steerDirection = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * steerDirection * SteerSpeed * Time.deltaTime);

        // Store position history
        PositionsHistory.Insert(0, transform.position);

        // Move body parts
        int index = 0;
        foreach (var body in BodyParts) 
        {
            Vector3 point = PositionsHistory[Mathf.Clamp(index * Gap, 0, PositionsHistory.Count - 1)];

            // Move body towards the point along the snakes path
            Vector3 moveDirection = point - body.transform.position;
            body.transform.position += moveDirection * BodySpeed * Time.deltaTime;

            // Rotate body towards the point along the snakes path
            body.transform.LookAt(point);

            index++;
        }
    }

    private void GrowSnake() 
    {
        // Instantiate body instance and
        // add it to the list
        GameObject body = Instantiate(BodyPrefab);
        BodyParts.Add(body);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacles"))
        {
            gameplayManager.PauseGame();
            gameplayManager.ShowLosePanel();
        }

        if (other.CompareTag("Apple"))
        {
            GlobalManager.Instance.score -= appleScore;
            GlobalManager.Instance.totalScore += appleScore;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Pear"))
        {
            GlobalManager.Instance.score -= pearScore;
            GlobalManager.Instance.totalScore += pearScore;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Orange"))
        {
            GlobalManager.Instance.score -= orangeScore;
            GlobalManager.Instance.totalScore += orangeScore;
            Destroy(other.gameObject);
        }
    }
}