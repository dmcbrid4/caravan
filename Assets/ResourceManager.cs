using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public int food = 100;  // start food
    public int water = 100; // start water
    public int fuel = 50;   // start fuel plump

    public int money = 0;

    public float resourceDecreaseRate = 1f; // this variable will be how quickly you are getting new resources.
    //you might want a separate variable for each kind of resource
    public float moneyIncreaseRate = 1f;

    void Update() // holden idk if you know about this part of unity/c# but the update function is the part of the script
                  // that runs constantly after hitting play. so this is constantly "updating" as the player plays
    {
        CollectResources();
    }

    void CollectResources()
    {
        food -= Mathf.FloorToInt(resourceDecreaseRate * Time.deltaTime);
        water -= Mathf.FloorToInt(resourceDecreaseRate * Time.deltaTime);
        fuel -= Mathf.FloorToInt(resourceDecreaseRate * Time.deltaTime);
        money += Mathf.FloorToInt(moneyIncreaseRate * Time.deltaTime);

        // max capacity of resources
        food = Mathf.Min(food, 200);
        water = Mathf.Min(water, 200);
        fuel = Mathf.Min(fuel, 100);
        //no max for money

        Debug.Log($"Food: {food}, Water: {water}, Fuel: {fuel}, Money: {money}");

    }
}
