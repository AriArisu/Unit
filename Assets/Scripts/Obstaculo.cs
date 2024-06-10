using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.9f;

    [SerializeField]
    private float varairposicaoY;
    private Vector3 posicaoPassaro;
    private bool pontuei;
    private UI uicontroller;

     private void Start()
    {
      this.posicaoPassaro= GameObject.FindObjectOfType<passaro>().transform.position;
        this.uicontroller = GameObject.FindObjectOfType<UI>();
    }
    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-varairposicaoY,varairposicaoY));
}
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left*velocidade* Time.deltaTime);
        if(this.pontuei && this.transform.position.x < this.posicaoPassaro.x)
        {

            this.uicontroller.adicionarPontos();
            this.pontuei = true;

        }
    }
}
 