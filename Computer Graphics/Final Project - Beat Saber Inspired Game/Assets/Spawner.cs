using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] cubes;
    public Transform[] points;
    public float beat = (60/130)*2;
    private float timer;
    private int rotate_value;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>beat)
        {
            GameObject cube = Instantiate(cubes[Random.Range(0,2)], points[Random.Range(0,4)]);
            cube.transform.localPosition = Vector3.zero;
            rotate_value = Random.Range(0,4);
            cube.transform.Rotate(transform.forward, 90 * rotate_value);

            // Define a direção de spawn
            Cube cubeScript = cube.GetComponent<Cube>();
            if (cubeScript != null)
            {
                cubeScript.spawnDirection = rotate_value;
            }
            timer -= beat;
        }

        timer += Time.deltaTime;
    }
}
