using UnityEngine;

public class Cube : MonoBehaviour
{
    private bool isInHitZone = false;
    public int spawnDirection; // 0 = cima, 1 = esquerda, 2 = baixo, 3 = direita

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HitZone"))
        {
            isInHitZone = true;
            // Debug.Log("Bloco entrou na área!");
            // Debug.Log("Direção de spawn: " + spawnDirection);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("HitZone"))
        {
            isInHitZone = false;
            // Debug.Log("Bloco saiu da área!");
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;

        if (isInHitZone && gameObject.layer == LayerMask.NameToLayer("b"))
        {
            if (spawnDirection == 0 && Input.GetKeyDown(KeyCode.W))
            {
                Destroy(gameObject);  // Destrói o bloco quando a tecla é pressionada
                Debug.Log("Bloco destruído!");
            }
            else if (spawnDirection == 1 && Input.GetKeyDown(KeyCode.A))
            {
                Destroy(gameObject);  // Destrói o bloco quando a tecla é pressionada
                Debug.Log("Bloco destruído!");
            }
            else if (spawnDirection == 2 && Input.GetKeyDown(KeyCode.S))
            {
                Destroy(gameObject);  // Destrói o bloco quando a tecla é pressionada
                Debug.Log("Bloco destruído!");
            }
            else if (spawnDirection == 3 && Input.GetKeyDown(KeyCode.D))
            {
                Destroy(gameObject);  // Destrói o bloco quando a tecla é pressionada
                Debug.Log("Bloco destruído!");
            }
        }
        if (isInHitZone && gameObject.layer == LayerMask.NameToLayer("r"))
        {
            if (spawnDirection == 0 && Input.GetKeyDown(KeyCode.UpArrow))
            {
                Destroy(gameObject);  // Destrói o bloco quando a tecla é pressionada
                Debug.Log("Bloco destruído!");
            }
            else if (spawnDirection == 1 && Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Destroy(gameObject);  // Destrói o bloco quando a tecla é pressionada
                Debug.Log("Bloco destruído!");
            }
            else if (spawnDirection == 2 && Input.GetKeyDown(KeyCode.DownArrow))
            {
                Destroy(gameObject);  // Destrói o bloco quando a tecla é pressionada
                Debug.Log("Bloco destruído!");
            }
            else if (spawnDirection == 3 && Input.GetKeyDown(KeyCode.RightArrow))
            {
                Destroy(gameObject);  // Destrói o bloco quando a tecla é pressionada
                Debug.Log("Bloco destruído!");
            }
        }
    }
}
