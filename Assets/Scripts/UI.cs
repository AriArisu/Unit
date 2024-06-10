using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class UI : MonoBehaviour
{
    private int pontos;
    private Label textoPontos;
    public void adicionarPontos()
    {
        this.pontos++;
        this.textoPontos.text = this.pontos.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontos = root.Q<Label>("pontos");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
