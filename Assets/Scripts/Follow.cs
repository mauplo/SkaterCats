using UnityEngine;

public class Follow : MonoBehaviour
{
   // informacion sobre la posicion del jugador
    public Transform target;
    // velocidad de la camara
    public float smoothSpeed = 0.125f;
    // poner la camara alejada del target en los 3 ejes
    public Vector3 offset;

    // funcion para seguir a el target DESPUES de su movimiento
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
