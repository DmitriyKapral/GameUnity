using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountBalls : MonoBehaviour
{
    private int count;
    public Text CountText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        count++;
        CountText.text = "Count balls:\n" + count;
        Destroy(other.gameObject);
    }
}
