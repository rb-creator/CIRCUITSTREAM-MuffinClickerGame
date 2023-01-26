using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class MyFirstScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _totalMuffinsText;
    [SerializeField]
    private int _counter = 0;
    [SerializeField]
    private int _criticalClicks = 10;
    [SerializeField]
    private float _probabilityFactor = 0.01f;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello World!");
        UpdateTotalMuffins();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void OnMuffinClicked()
    {
        if (Random.value < _probabilityFactor)
        {
            _counter = _counter + _criticalClicks;
            Debug.Log("Critical Hit!");
        }
        else
        {
            _counter = _counter + 1;
            //Debug.Log("Plus 1");
        }

        UpdateTotalMuffins();
        //Debug.Log(_counter);
    }

    private void UpdateTotalMuffins()
    {
        if(_counter == 1)
        {
            _totalMuffinsText.text = _counter.ToString() + " muffin";
        }
        else
        {
            _totalMuffinsText.text = _counter.ToString() + " muffins";
        }


    }
}
