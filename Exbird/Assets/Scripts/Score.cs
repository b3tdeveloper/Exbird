using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    [SerializeField] TextMeshProUGUI textMeshProUGUI;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject)
        {
            score++;
            textMeshProUGUI.text = "Score : " + score.ToString();
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (score > 1)
        {
            //moveObjects.speed = 20;
            //other.gameObject.GetComponent<MoveObjects>().speed +=2f;
        }
    }
}
