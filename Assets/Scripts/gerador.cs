using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerador : MonoBehaviour
{
    [SerializeField]
    private float tempoParaCriar;

    private float cronometro;

    [SerializeField]

    private GameObject ModeloObstaculo;

     private void Awake()
    {
        this.cronometro = this.tempoParaCriar;
    }

    // Update is called once per frame
    void Update()
    {
        this.cronometro = Time.deltaTime;
        if (this.cronometro < 0)
        {
            GameObject.Instantiate(this.ModeloObstaculo, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaCriar;
        }
    }
}
