using UnityEngine;

public class ChargeColor : MonoBehaviour
{
    public Renderer indicator;
    public int charge = 0;

    void Start()
    {
        while (charge < 100)
        {
            charge += 25;

            Color color;
            if (charge < 50)
            {
                color = Color.red;
            }
            else if (charge < 100)
            {
                color = Color.yellow;
            }
            else
            {
                color = Color.green;
            }

            indicator.material.color = color;
            Debug.Log("Charge: " + charge + "%");
        }
    }
}