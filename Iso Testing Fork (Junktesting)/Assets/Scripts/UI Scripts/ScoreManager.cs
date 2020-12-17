using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public static bool quitOn;

    public GameObject grapes;
    public GameObject lifecoin;
    public int prevRoundScore;
    public float difficultyshifter = 0;

    public bool firstInc;
    public bool secondInc;
    public bool thirdInc;
    public bool fourthInc;
    public bool fifthInc;
    public bool sixthInc;
    public bool diffShift;

    public static float diffFactor;
    public static float diffLevel;
    public static int currentDiffTier = 1;
    public bool isCalc;

    public float startScore;
    public float endScore;
    public float scoreChange;
    public float lastscoreChange;
    public static float percentChange = 1;
    public static int totalScore;

    private void OnApplicationQuit()
    {
        Debug.Log("QuitOn true");
        quitOn = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        prevRoundScore = 0;
        diffFactor = 0;
        diffLevel = 0;
        currentDiffTier = 1;
        percentChange = 1;
        totalScore = 0;

        quitOn = false;
        totalScore = 0;
        lastscoreChange = 50;

        IEnumerator ScoreChange()
        {
            startScore = totalScore;
            yield return new WaitForSeconds(10);
            endScore = totalScore;
            scoreChange = endScore - startScore;
            //Debug.Log("Score change");
            //Debug.Log(scoreChange);
            //Debug.Log("Last score change");
            //Debug.Log(lastscoreChange);
            percentChange = scoreChange / lastscoreChange;
            lastscoreChange = scoreChange;
// maybe? not working yet            EnemyAI.enMoveSpeed = 1 - percentChange / 10;
            StartCoroutine(ScoreChange());

            //Debug.Log("Percent change");
            //Debug.Log(percentChange);
        }
        StopCoroutine(ScoreChange());
        StartCoroutine(ScoreChange());

    }



    // Update is called once per frame
    void Update()
    {
//        Debug.Log(currentDiffTier);

//        Debug.Log(EnemyAI.enHealthFactor);
        IEnumerator DiffCalc()
        {
            isCalc = true;
            diffFactor = totalScore / AltEnemySpawner.totalKills;
           // Debug.Log("Factor");
           // Debug.Log(diffFactor);
            diffLevel = (diffFactor / 100) + (Time.timeSinceLevelLoad / 100);

      //      diffLevel = (5) + (Time.timeSinceLevelLoad / 100);

            //Debug.Log("Level");
            // Debug.Log(diffLevel);
            yield return new WaitForSeconds(10);
            yield return null;
            isCalc = false;
        }
        if (isCalc == false)
        {
            StartCoroutine(DiffCalc());
        }

        //quad x + difficultyshifter if encountered problems/ difficultyshifter = 6

        if (diffLevel >= (0 + difficultyshifter) && diffLevel < (.25 + difficultyshifter))
        {
            currentDiffTier = 1;
            if(firstInc == false)
            {
                sixthInc = false;
     //           AltEnemySpawner.spawnTime = (AltEnemySpawner.spawnTime * .95f);
     //           EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 1.05f;
                firstInc = true;
            }
        }
        if (diffLevel >= (.25 + difficultyshifter) && diffLevel < (.5 + difficultyshifter))
        {
            currentDiffTier = 2;

            if (secondInc == false)
            {
                AltEnemySpawner.spawnTime = (AltEnemySpawner.spawnTime * .9f);
                EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 1.05f;
                secondInc = true;
            }
        }
        if (diffLevel >= (.5 + difficultyshifter) && diffLevel < (.75 + difficultyshifter))
        {
            currentDiffTier = 3;

            if (thirdInc == false)
            {
                AltEnemySpawner.spawnTime = (AltEnemySpawner.spawnTime * .9f);
        //        EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 1.05f;
                thirdInc = true;
            }
        }
        if (diffLevel >= (.75 + difficultyshifter) && diffLevel < (1 + difficultyshifter))
        {
            currentDiffTier = 4;

            if (fourthInc == false)
            {
                AltEnemySpawner.spawnTime = (AltEnemySpawner.spawnTime * .9f);
                EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 1.05f;
                fourthInc = true;
            }
        }
        if (diffLevel >= (1 + difficultyshifter) && diffLevel < (1.25 + difficultyshifter))
        {
            currentDiffTier = 5;

            if (fifthInc == false)
            {
                AltEnemySpawner.spawnTime = (AltEnemySpawner.spawnTime * .9f);
      //          EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 1.05f;
                fifthInc = true;
            }
        }
        if (diffLevel >= (1.25 + difficultyshifter))
        {
            diffShift = false;
            currentDiffTier = 6;

            if (sixthInc == false)
            {
                AltEnemySpawner.spawnTime = (AltEnemySpawner.spawnTime * .9f);
                EnemyAI.enMoveSpeed = EnemyAI.enMoveSpeed * 1.05f;
          //      EnemyAI.enHealthFactor = Enemy2AI.enHealthFactor + 1;
           //     Enemy2AI.enHealthFactor = Enemy2AI.enHealthFactor + 1;
           //     Enemy3AI.enHealthFactor = Enemy3AI.enHealthFactor + 1;
                sixthInc = true;
            }
            firstInc = false;
            secondInc = false;
            thirdInc = false;
            fourthInc = false;
            fifthInc = false;
        }

//difficultyshifter added to equation here remove if problems
        if((diffLevel + difficultyshifter) >= (1.5 + difficultyshifter) && diffShift == false)
        {
            diffShift = true;

            if(totalScore >= prevRoundScore + 2500 && totalScore < prevRoundScore + 5000)
            {
                Instantiate(grapes, new Vector2(-1.5f, 0), transform.rotation);
            }

            if (totalScore >= prevRoundScore + 5000)
            {
                Instantiate(lifecoin, new Vector2(-1.5f, 0), transform.rotation);
            }

            prevRoundScore = totalScore;
            difficultyshifter = difficultyshifter + 1.5f;
        }
    }
}
