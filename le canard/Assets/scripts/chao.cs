using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class chao : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    private Vector3 posicaoInicial;
    private float tamanhoImagem;

    private void Awake()
    {
        this.posicaoInicial = this.transform.position;
        float tamanhoImagemOriginal = GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoImagem = tamanhoImagemOriginal * escala;

    }


    // Update is called once per frame
    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, tamanhoImagem);
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento;
    }
}
