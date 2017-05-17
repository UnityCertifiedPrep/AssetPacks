using UnityEngine;
using System.Collections;

public class GoalScoring : MonoBehaviour
{
    public Highlighter highlighter;

    void OnTriggerEnter(Collider other)
    {
        if (highlighter)
        {
            highlighter.Highlight();
        }
    }
}