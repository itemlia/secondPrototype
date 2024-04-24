
using TMPro;
using UnityEngine.UI;
using UnityEngine;


public class plantSeed : MonoBehaviour
{
   public GameObject waterBar;
   public GameObject stem;
   public GameObject trimPlant;
   public GameObject barBackgrnd;
   
   public Vector3 offset;
   public Vector3 scale;

   public float distance;
   private string planted = "planted";

   public TextMeshProUGUI textComp;

   private void Update()
   {
      raycastSeed();

      if (Input.GetMouseButton(1))
      {
         OnMouseDrag();
      }
      else if (Input.GetMouseButtonDown(0) && gameObject.CompareTag("planted"))
      {
         OnMouseDown();
      }

      if (waterBar.transform.localScale.x >= 0.44)
      {
         scale.x = 0;
         gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
         stem.SetActive(true);
         trimPlant.SetActive(true);
      }
   }
   private void raycastSeed()
   {
      RaycastHit2D down = Physics2D.Raycast(gameObject.transform.position, Vector2.down, distance);
      RaycastHit2D up = Physics2D.Raycast(gameObject.transform.position, Vector2.up, distance);
      RaycastHit2D left = Physics2D.Raycast(gameObject.transform.position, Vector2.left, distance);
      RaycastHit2D right = Physics2D.Raycast(gameObject.transform.position, Vector2.right, distance);

      if (up.transform != null && down.transform != null && left.transform != null && right.transform != null)
      {
         if (up.transform.CompareTag("ground") || down.transform.CompareTag("ground") ||
             left.transform.CompareTag("ground") || right.transform.CompareTag("ground"))
         {
            gameObject.tag = "planted";
            textComp.text = planted;
            barBackgrnd.SetActive(true);
         }
      }
   }
   private void OnMouseDrag()
   {
      gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
   }

   private void OnMouseDown()
   {
      waterBar.SetActive(true);
      waterBar.transform.localScale += scale;
      
   }
}


