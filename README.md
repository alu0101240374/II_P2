## Práctica 2 - Interfaces Inteligentes

### 1)
*a.*  Ninguno de los objetos será físico.
![gifSinFisicas](./GIFs/Sin_Fisicas.gif)  

*b.*  La esfera tiene físicas, el cubo no.
![gifEsferaFisicas](./GIFs/Esfera_fisicas.gif)

*c.*  La esfera y el cubo tienen físicas.
![gifEsferaCuboFisicas](./GIFs/Esfera_Cubo_fisicas.gif)

*d.* La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo
![gifEsferaMasa](./GIFs/Esfera_masa.gif)

*e.*  La esfera tiene físicas y el cubo es de tipo isTrigger
![gifisTriggerCubo](./GIFs/isTrigger_Cubo.gif)

*f.*  La esfera tiene físicas, el cubo es de tipo isTrigger y tiene físicas.
![gifisTriggerFisicaCubo](./GIFs/isTrigger_fisicas_Cubo.gif)

*g.*  La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ.  
Ejemplo **con** rotación:  
![gifFreeRotation](./GIFs/Free_rotation.gif)

Ejemplo **sin** rotación:  
![gifNoRotation](./GIFs/No_rotation.gif)

### 2)

Para este ejercicio he creado dos scripts:  

**CharacterController**

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float speed = .1f;

    void Update()
    {
      PlayerMovement();
    }

    void PlayerMovement()
    {
      float hor = Input.GetAxis("Horizontal");
      float ver = Input.GetAxis("Vertical");
      Vector3 playerMovement = new Vector3(hor, 0.0f, ver);
      Debug.Log(playerMovement);
      transform.Translate(playerMovement * speed * Time.deltaTime, Space.Self);
    }
}
```

**CameraController**

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    void Start()
    {
      Cursor.visible = false;
      Cursor.lockState = CursorLockMode.Locked;
    }
    public float rotationSpeed = 1;
    public Transform Target, Player;
    float mouseX, mouseY;

    void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
      mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
      mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
      mouseY = Mathf.Clamp(mouseY, -35, 30);

      transform.LookAt(Target);

      Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
      Player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}
```

El primero nos sirve para mover el cubo en función de lo que introduzca el jugador con las flechas AWSD. El segundo script sirve para mover la cámara en función del ratón, y que siempre la flecha W sea hacia adelante.

Aquí tenemos un ejemplo del resultado:   
![gifEjercicio2](./GIFs/Ejercicio2.gif)