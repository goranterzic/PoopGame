using Firebase.Auth;
using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ViewScore : MonoBehaviour
{
    [SerializeField]
    Text Text;
    [SerializeField]

    DataSnapshot dataSnapshot;
    public DatabaseReference reference;

    public FirebaseUser User;
    public FirebaseAuth Auth;
    // Start is called before the first frame update
    void Awake()
    {
        reference = FirebaseDatabase.DefaultInstance.RootReference;

    }
    void Start()
    {
        StartCoroutine(LoadFromDatabase());
    }
    IEnumerator LoadFromDatabase()
    {
        DataSnapshot snapshot;
        var DBTask = reference.Child("Users").OrderByChild("score").LimitToFirst(10).GetValueAsync();
        yield return new WaitUntil(predicate: () => DBTask.IsCompleted);
        snapshot = DBTask.Result;
        int i = 1;
           foreach (DataSnapshot childSnapshot in snapshot.Children.Reverse<DataSnapshot>())
           {
               string nickName = childSnapshot.Child("nickName").Value.ToString();
               int score = int.Parse(childSnapshot.Child("score").Value.ToString());
                Text.text += i+"." + nickName.ToString() + "" + score.ToString() + "\n";
            i++;
            }
       }
    }





