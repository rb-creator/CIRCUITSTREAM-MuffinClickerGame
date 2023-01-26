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
    private int _muffinsPerClick = 1;

    [SerializeField]
    private int _bonusClicks = 10;
    
    [SerializeField]
    private float _criticalChance = 0.01f;

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
        if (Random.value <= _criticalChance)
        {
            //Critical Hit
            _counter = _counter + (_muffinsPerClick * _bonusClicks);
            Debug.Log("Critical Hit!");
        }
        else
        {
            //Normal Hit
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
