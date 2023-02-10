using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SimpleRandomWalkMapGenerator : MonoBehaviour
{
    [SerializeField]
    protected Vector2Int startPostition = Vector2Int.zero;

    [SerializeField]
    private int iterations = 10;
    [SerializeField]
    public int walkLengh = 10;
    [SerializeField]
    public bool startRandomlyEachIteration = true;
    private HashSet<Vector2Int> currentPosition;

    public void RunProceduralGenerations()
    {
        HashSet<Vector2Int> floorPositions = RunRandomWalk();
        foreach (var position in floorPositions)
        {
            Debug.Log(position);
        }
    }

    protected HashSet<Vector2Int> RunRandomWalk()
    {
        var curentPositions = startPostition;
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
        for (int i = 0; i < iterations; i++)
        {
            var path = ProceduralGenerationAlgorithms.SimpleRandomWalk(curentPositions, walkLengh);
            floorPositions.UnionWith(path);
            if (startRandomlyEachIteration)
                currentPosition = floorPositions.ElementAt(Random.Range(0, floorPositions.Count));
        }
        return floorPositions;
    }
}
