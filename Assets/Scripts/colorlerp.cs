using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorlerp : MonoBehaviour
{
    public SpriteRenderer S_render;
    public Color[] s_color;
    private int index;
    public float speed;

    private float changer;

    // Start is called before the first frame update
    void Start()
    {
        S_render = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        S_render.material.color = Color.Lerp(S_render.material.color, s_color[index], speed * Time.deltaTime);

        changer = Mathf.Lerp(changer, 1f, speed * Time.deltaTime);

        if(changer > 0.9f){
            changer = 0;
            index++;
            index = (index >= s_color.Length) ? 0 : index;
        }
    }
}
