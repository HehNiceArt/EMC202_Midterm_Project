using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehavior : MonoBehaviour
{
    public List<Color> colors;
    //public Color[] color;
    [Header("Material")]
    public MeshRenderer parent;
    public MeshRenderer child;
    public MeshRenderer bullet;

    public static ColorBehavior Instance;
    public int index;
    int randIndex;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this; 
        parent = GetComponent<MeshRenderer>();
        
    }
    public Color RandomColor()
    {
        randIndex = Random.Range(0, colors.Count);
        return colors[randIndex];
    }
    private void OnMouseDown()
    {
        ChangeColor();
       
    }
    public void ChangeColor()
    {
        

        index += 1;
        if (index == colors.Count) { index = 0; }
        parent.sharedMaterial.color = colors[index];
        child.sharedMaterial.color = colors[index];
        bullet.sharedMaterial.color = colors[index];


       

    }
}
