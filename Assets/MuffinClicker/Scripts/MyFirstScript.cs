using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class MyFirstScript : MonoBehaviour
{
    TextMeshProUGUI m_TextMeshProUGUI;

    [SerializeField]
    private int _counter = 0;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void OnMuffinClicked()
    {
        
        _counter = _counter + 1;
        Debug.Log(_counter);
    }
}
