using UnityEngine;

public class TestScript : MonoBehaviour
{
    public float hor,ver;
    public float speed = 2f;
    public float tiempoEspera;
    float delay;
    public GameObject proyectilPrefab;
//    public float tiempoRestante;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hola Mundo!"); 
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoJugador();
        Disparar();
    }

    void MovimientoJugador()
    {
        /*
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Has presionado la tecla espacio");
            transform.Translate(new Vector3(0,0,0.1f));
        }
        */

        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(hor,0,ver) * speed * Time.deltaTime);
    }
/*
    void ResetearTemporizador()
    {
        tiempoRestante = tiempoEspera;
    }

    void Temporizador()
    {
        tiempoRestante -= Time.deltaTime;
        if(tiempoRestante <= 0)
        {
            Debug.Log("La espera terminó");
        }
    }
*/
    void ResetearDisparo()
    {
        delay = tiempoEspera;
    }

    void Disparar()
    {
        delay -= Time.deltaTime;
        if(delay <= 0)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(proyectilPrefab , transform.position , transform.rotation);
            }
            else
            {
                Instantiate(proyectilPrefab , transform.position , transform.rotation);
            }
            ResetearDisparo();
        }
        
/*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectilPrefab , transform.position , transform.rotation);
        }
 */
    }
}
