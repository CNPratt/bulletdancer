


IEnumerator rollMethod();
{
    canSpawn = false;
    int roll = (int)Random.Range(1f, 5f);

    if (roll == 1)
    {
        if (spawnPoint1.GetComponent<SpawnOpen>().isOpen == true)
        {
            Instantiate(puptoSpanwn, spawnPoint1.position, spawnPoint1.rotation);
        }
        else
        {
            StopCoroutine(rollMethod());
            StartCoroutine(rollMethod());
        }
    }
    if (roll == 2)
    {
        if (spawnPoint2.GetComponent<SpawnOpen>().isOpen == true)
        {
            Instantiate(puptoSpanwn, spawnPoint2.position, spawnPoint1.rotation);
        }
        else
        {
            StopCoroutine(rollMethod());
            StartCoroutine(rollMethod())
        }
    }
    if (roll == 3)
    {
        if (spawnPoint3.GetComponent<SpawnOpen>().isOpen == true)
        {
            Instantiate(puptoSpanwn, spawnPoint3.position, spawnPoint1.rotation);
        }
        else
        {
            StopCoroutine(rollMethod());
            StartCoroutine(rollMethod())
        }
    }
    if (roll == 4)
    {
        if (spawnPoint4.GetComponent<SpawnOpen>().isOpen == true)
        {
            Instantiate(puptoSpanwn, spawnPoint4.position, spawnPoint1.rotation);
        }
        else
        {
            StopCoroutine(rollMethod());
            StartCoroutine(rollMethod())
        }
    }
    yield return new WaitForSeconds(pupSpawnTime);
    canSpawn = true;
    yield return

}