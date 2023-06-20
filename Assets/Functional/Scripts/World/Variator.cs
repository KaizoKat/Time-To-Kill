using UnityEngine;

public class Variator : MonoBehaviour
{
    private SpriteRenderer spRR;
    Color init;
    private void Start()
    {
        spRR = GetComponent<SpriteRenderer>();
        init = spRR.color;
        RandomizeAll();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
            RandomizeAll();
    }

    private void RandomizeAll()
    {
        spRR.color = new Color(init.r + Random.Range(-0.2f, 0.2f), init.g, init.b + Random.Range(-0.05f, 0.05f), init.a);
        if (Random.Range(0, 1) == 0)
            spRR.flipX = false;
        else
            spRR.flipX = true;
    }
}
