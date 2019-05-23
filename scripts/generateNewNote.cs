using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateNewNote : MonoBehaviour
{
	List<GameObject> notesArray = new List<GameObject>();
	public GameObject StickyNotesPink;
	public GameObject StickyNotesYellow;
	public GameObject StickyNotesBlue;
	public GameObject StickyNotesGreen;

    // Start is called before the first frame update
    void Start()
    {
        notesArray.Add(StickyNotesPink);
        notesArray.Add(StickyNotesYellow);
        notesArray.Add(StickyNotesBlue);
        notesArray.Add(StickyNotesGreen);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnMouseDown(){
     	//get current mouse position
     	var mousePositionInWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

     	int rand = UnityEngine.Random.Range(0,notesArray.Count);
       Instantiate(notesArray[rand], new Vector3(0,0,0), Quaternion.identity);
 	}
}
