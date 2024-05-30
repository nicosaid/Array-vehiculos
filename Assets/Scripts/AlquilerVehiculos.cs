using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;
    public int vehiculorandom;
    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            vehiculorandom = Random.RandomRange(0, vehiculos.Length);
            DesactivarTodosLosVehiculos();
            vehiculos[vehiculorandom].SetActive(true);

        }
    }

    void ResetearVehiculos()
    {

        DesactivarTodosLosVehiculos();
        vehiculos[0].SetActive(true);

    }
    void DesactivarTodosLosVehiculos()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }

}
