using UnityEngine;

public class Floating : MonoBehaviour
{
  public float rotationSpeed = 50f; // Velocidad de rotaci�n
  public float moveSpeed = 2f; // Velocidad de movimiento
  public float startY = 10f; // Altura inicial
  public float endY = 0f; // Altura final
  public float moveDuration = 5f; // Duraci�n de la interpolaci�n en segundos

  private float elapsedTime = 0f;

  void Start()
  {
    // Establece la posici�n inicial del objeto
    transform.position = new Vector3(transform.position.x, startY, transform.position.z);
  }

  void Update()
  {
    // Rotar el objeto sobre su propio eje Y
    transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

    // Interpolaci�n de arriba hacia abajo
    if (elapsedTime < moveDuration)
    {
      float newY = Mathf.Lerp(startY, endY, elapsedTime / moveDuration);
      transform.position = new Vector3(transform.position.x, newY, transform.position.z);
      elapsedTime += Time.deltaTime;
    }
    else
    {
      // Asegurarse de que el objeto termine exactamente en la posici�n final
      transform.position = new Vector3(transform.position.x, endY, transform.position.z);
    }
  }
}
