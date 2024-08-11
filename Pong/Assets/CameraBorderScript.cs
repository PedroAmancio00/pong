using UnityEngine;

public class CameraBorderScript : MonoBehaviour
{
    public Transform leftBorder;
    public Transform rightBorder;
    public Transform topBorder;
    public Transform bottomBorder;

    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;

        // Tamanho da c�mera
        float camHeight = cam.orthographicSize * 2f;
        float camWidth = camHeight * cam.aspect;

        // Configurando tamanho e posi��o dos coliders
        leftBorder.localScale = new Vector3(1, camHeight, 1);
        rightBorder.localScale = new Vector3(1, camHeight, 1);
        topBorder.localScale = new Vector3(camWidth, 1, 1);
        bottomBorder.localScale = new Vector3(camWidth, 1, 1);

        leftBorder.position = new Vector2(-camWidth / 2, 0);
        rightBorder.position = new Vector2(camWidth / 2, 0);
        topBorder.position = new Vector2(0, camHeight / 2);
        bottomBorder.position = new Vector2(0, -camHeight / 2);


        BoxCollider2D leftCollider = leftBorder.GetComponent<BoxCollider2D>();
        BoxCollider2D rightCollider = rightBorder.GetComponent<BoxCollider2D>();
        BoxCollider2D topCollider = topBorder.GetComponent<BoxCollider2D>();
        BoxCollider2D bottomCollider = bottomBorder.GetComponent<BoxCollider2D>();
                
        float minSize = (float) 0.001;
        float colliderMinSize = (float) 0.1;
        float colliderSize = (float) 0.05;

        leftCollider.size = new Vector2(colliderSize, colliderMinSize); // Ajuste a largura conforme necess�rio
        leftCollider.offset = new Vector2(-colliderSize / 2, minSize); // Ajuste o offset para corrigir a posi��o

        // Ajustar o BoxCollider2D para RightBorder
        rightCollider.size = new Vector2(colliderSize, colliderMinSize); // Ajuste a largura conforme necess�rio
        rightCollider.offset = new Vector2(colliderSize / 2, minSize); // Ajuste o offset para corrigir a posi��o

        // Ajustar o BoxCollider2D para TopBorder
        topCollider.size = new Vector2(colliderMinSize, colliderSize); // Ajuste a altura conforme necess�rio
        topCollider.offset = new Vector2(minSize, colliderSize / 2); // Ajuste o offset para corrigir a posi��o

        // Ajustar o BoxCollider2D para BottomBorder
        bottomCollider.size = new Vector2(colliderMinSize, colliderSize); // Ajuste a altura conforme necess�rio
        bottomCollider.offset = new Vector2(minSize, -colliderSize/2); // Ajuste o offset para corrigir a posi��o

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
