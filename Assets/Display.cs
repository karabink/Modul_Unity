using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    // Start is called before the first frame update

    public Text violationText;

    public GameObject messageText;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        violationText.text = "Ви порушили правило";
        if (Storage.CarOver)
        {
            (messageText).SetActive(true);
        }
    }
}