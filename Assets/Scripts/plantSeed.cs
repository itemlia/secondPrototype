
using TMPro;
using UnityEngine.UI;
using UnityEngine;


public class plantSeed : MonoBehaviour
{
   [SerializeField] private GameObject waterBar;
   [SerializeField] private GameObject stem;
   [SerializeField] private GameObject trimPlant;
   [SerializeField] private GameObject barBackgrnd;
   
   [SerializeField] private Vector3 offset;
   [SerializeField] private Vector3 scale;

   [SerializeField] private Color color;
   
   [SerializeField] private float distance;
   private string planted = "planted";

   [SerializeField] public TextMeshProUGUI textComp;
   
   [SerializeField] private Button click;

   public void Start()
   {
      var btn = click.GetComponent<Button>();
      btn.onClick.AddListener(WaterSeed);
   }

   private void Update()
   {
      RaycastSeed();

     if (Input.GetMouseButtonDown(0) && gameObject.CompareTag("planted"))
      {
         WaterSeed();
      }
      
   }
   private void RaycastSeed()
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

   public void WaterSeed()
   {
      waterBar.SetActive(true);
      waterBar.transform.localScale += scale;
      
      if (waterBar.transform.localScale.x >= 0.44)
      {
         scale.x = 0;
         gameObject.GetComponent<SpriteRenderer>().color = color;
         stem.SetActive(true);
         trimPlant.SetActive(true);
      }
   }
   private void OnMouseDrag()
   {
      gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
   }

   
}


