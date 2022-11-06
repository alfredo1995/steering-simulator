using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEditor;

public class Estiligui : MonoBehaviour
{
    //componenteRenderer tem uma matriz de dois ou mais pontos no espa�o 3D
    //3 variavel do tipo Transform para armazenar e manipular a posi��o, rota��o e escala do Estiligui.cs
    public LineRenderer[] lineRenderer;
    public Transform[] posicoesFaixa;
    public Transform posicaoFaixaCentro;
    public Transform posicaoFaixaParada;

    //Vector3 de tres posi��o atuais que armazene a extremidade da faixa
    public Vector3 currentPosition;

    public float maxLength;

    public float limiteElasticoSolo;

    //bool com o mouse para baixo
    bool mousePraBaixo;

    public GameObject passaroPrefabs;

    public float posicaoDeslocamentoPassaro;

    Rigidbody2D passaro;
    Collider2D passaroColider;

    public float disparo;


    void Start()
    {
        //definindo a contagem de ambos redenizador para 2
        lineRenderer[0].positionCount = 2;
        lineRenderer[1].positionCount = 2;

        //definindo a posi��o da linha dos renderizadores p/ a posi��o da faixa
        lineRenderer[0].SetPosition(0, posicoesFaixa[0].position);
        lineRenderer[1].SetPosition(0, posicoesFaixa[1].position);

        CriarPassaros();
    }
    void CriarPassaros()
    {
        passaro = Instantiate(passaroPrefabs).GetComponent<Rigidbody2D>();
        passaroColider = passaro.GetComponent<Collider2D>();
        passaroColider.enabled = false;

        passaro.isKinematic = true;

        ResertarPosicaoFaixa();
    }
    void Update()
    {
        //condi��o com o mouse p/ baixo ou p/ cima 
        if (mousePraBaixo)
        {
            ///posi��o do mouse do tipo Vector3 recebendo o Input.mousePosition que retorna a posi��o do mouse
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10;

            //main.screen definir a posi��o da faixa ao usar o mouse
            //adicionando a posi��o atual(Vector3), grampeando a magintude(ClampMagnitude) p/ saber o comprimento maximo(maxLength)
            currentPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            currentPosition = posicaoFaixaCentro.position + Vector3.ClampMagnitude(currentPosition - posicaoFaixaCentro.position, maxLength);

            currentPosition = ElasticoSolo(currentPosition);

            DefinirPosicaoFaixas(currentPosition);

            if (passaroColider)
            {
                passaroColider.enabled = true;
            }
        }
        else
        {
            ResertarPosicaoFaixa();
        }
    }

    //metodos chaamados pela unity quando o mouse for clicado p/ baixo ou p/ cima interagindo com objeto do jogo
    void OnMouseDown()
    {
        mousePraBaixo = true;
    }
    void OnMouseUp()
    {
        mousePraBaixo = false;
        AtirarPassaro();

        currentPosition = posicaoFaixaParada.position;
    }

    void AtirarPassaro()
    {
        passaro.isKinematic = false;

        Vector3 passaroDisparo = (currentPosition - posicaoFaixaCentro.position) * disparo * -1;
        passaro.velocity = passaroDisparo;

        passaro = null;
        passaroColider = null;

        Invoke("CriarPassaros", 2);

    }

    //metodo pegando a posi��o da faixa e passando a posi��o da faixa parada como argumento
    void ResertarPosicaoFaixa()
    {
        currentPosition = posicaoFaixaParada.position;
        DefinirPosicaoFaixas(posicaoFaixaParada.position);
    }

    //met�do para redefinir e definir a posi��o da faixa atr�ves de um param�tro do tipo Vector3 
    void DefinirPosicaoFaixas(Vector3 position)
    {
        //definir a posi��o das faixas pelo renderizadores de linhas com argumento do paremetro
        lineRenderer[0].SetPosition(1, position);
        lineRenderer[1].SetPosition(1, position);

        if (passaro)
        {
            Vector3 dir = position - posicaoFaixaCentro.position;

            passaro.transform.position = position + dir.normalized * posicaoDeslocamentoPassaro;
            passaro.transform.right = dir.normalized;
        }

    }
    Vector3 ElasticoSolo(Vector3 vector)
    {
        vector.y = Mathf.Clamp(vector.y, limiteElasticoSolo, 1000);
        return vector;
    }

}

