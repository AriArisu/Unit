using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chão : MonoBehaviour
{
        [SerializeField]
        private float velocidade = 2f;

        private Vector3 posicaoInicial;

        private float tamanhoReal;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoImagem = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoReal = tamanhoImagem * escala;
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento =  Mathf.Repeat( this.velocidade * Time.time,tamanhoReal);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;

    }


}
