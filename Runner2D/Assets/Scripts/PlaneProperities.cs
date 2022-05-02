using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneProperities : MonoBehaviour
{
    List<Transform> scorePositions;
    List<Transform> sawPositions;

    [SerializeField] GameObject score;
    [SerializeField] GameObject saw;

    // Start is called before the first frame update
    void Start()
    {
        scorePositions = new List<Transform>();
        sawPositions = new List<Transform>();

        foreach (Transform child in transform)
        { 
            switch (child.tag)
            {
                case "ScorePos":
                    scorePositions.Add(child);
                    break;
                case "SawPos":
                    sawPositions.Add(child);
                    break;
                default:
                    break;
            }
        }

        int ScoreNumbers = Random.Range(0, scorePositions.Count);
        int SawNumbers = Random.Range(0, sawPositions.Count);
        Debug.Log("all scores: " + scorePositions.Count + " My scores: " + ScoreNumbers);

        ShuffleList<Transform>(sawPositions);
        ShuffleList<Transform>(scorePositions);

        for (int i = 0; i <= ScoreNumbers; i++)
        {
            Debug.Log("instantiating scores");
            Instantiate(score, scorePositions[i].position, Quaternion.identity);
        }
        for (int i = 0; i <= SawNumbers; i++)
        {
            Debug.Log("instantiating saws");
            Instantiate(saw, sawPositions[i].position, Quaternion.identity);
        }
    }

    private void ShuffleList<T>(List<T> ts)
    {
        for (int i = 0; i < ts.Count; i++)
        {
            T temp = ts[i];
            int randomIndex = Random.Range(i, ts.Count);
            ts[i] = ts[randomIndex];
            ts[randomIndex] = temp;
        }
    }

}
