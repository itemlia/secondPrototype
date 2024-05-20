
using System;
using TMPro;
using UnityEngine.UI;
using UnityEngine;


public class plantSeed : MonoBehaviour
{
   [SerializeField] private GameObject waterBar;
   [SerializeField] private GameObject trimPlant;
   [SerializeField] private GameObject barBackgrnd;
   
   [SerializeField] private Vector3 offset;
   [SerializeField] private Vector3 scale;

   [SerializeField] private Sprite sprite;
   
   [SerializeField] private float distance;
   private string planted = "planted";

   [SerializeField] public TextMeshProUGUI textComp;
   
   [SerializeField] private Button click;

   

   public void Start()
   {
      var btn = click.GetComponent<Button>();
      btn.onClick.AddListener(WaterSeed);
   }

   private void Awake()
   {
      barBackgrnd = GameObject.Find("bar background");
      waterBar = GameObject.Find("water b");
   }

   private void Update()
   {
      RaycastSeed();

     if (Input.GetMouseButtonDown(0) && gameObject.CompareTag("planted"))
      {
         WaterSeed();
      }
      
   }
   private void RaycastSeed() //checks if seed has reached the 'ground' and if so it can be 'planted'
   {
      RaycastHit2D down = Physics2D.Raycast(gameObject.transform.position, Vector2.down, distance);
      RaycastHit2D up = Physics2D.Raycast(gameObject.transform.position, Vector2.up, distance);
      RaycastHit2D left = Physics2D.Raycast(gameObject.transform.position, Vector2.left, distance);
      RaycastHit2D right = Physics2D.Raycast(gameObject.transform.position, Vector2.right, distance);

      if (up.transform != null && down.transform != null && left.transform != null && right.transform != null)
      {
         Debug.DrawRay(gameObject.transform.position, Vector2.down, Color.black);
         if (up.transform.CompareTag("ground") || down.transform.CompareTag("ground") ||
             left.transform.CompareTag("ground") || right.transform.CompareTag("ground"))
         {
            gameObject.tag = "planted";
            textComp.text = planted;
            barBackgrnd.SetActive(true);
         }
      }
   }

   public void WaterSeed() //allows player to water seed by clikin on the plant
   {
      waterBar.SetActive(true);
      waterBar.transform.localScale += scale;
      
      if (waterBar.transform.localScale.x >= 0.44) //increases a bar to show progress of watering and when reached the end plant is watered
      {
         scale.x = 0;
         gameObject.GetComponent<SpriteRenderer>().sprite = sprite;
         trimPlant.SetActive(true);
      }
   }
   private void OnMouseDrag() //allows for seed to be dragged around screen
   {
      gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - offset);
   }

   
}


