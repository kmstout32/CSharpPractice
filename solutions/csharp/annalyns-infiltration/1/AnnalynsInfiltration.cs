static class QuestLogic
{
/// <summary>
/// The fast attack is only possible if the knight is sleeping.
/// </summary>
    public static bool CanFastAttack(bool knightIsAwake)
    {
      return !knightIsAwake;
    }
/// <summary>
/// The spy action is possible if at least one of them is awake.
/// </summary>
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        // the entire expression is true, meaning you can spy.
        return knightIsAwake || archerIsAwake || prisonerIsAwake;
    }
/// <summary>
/// The prisoner can be signaled if the archer is sleeping AND the prisoner is awake.
/// </summary>
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        // AND prisonerIsAwake must be true.
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
      // Scenario 1: Pet Dog is Present
        if (petDogIsPresent)
        {
            // With the dog, the knight is handled. Only the archer must be asleep.
            return !archerIsAwake;
        }
        else 
        {
            // Scenario 2: No Pet Dog is Present
            // All three conditions must be met: Knight asleep, Archer asleep, and Prisoner awake.
            return !knightIsAwake && !archerIsAwake && prisonerIsAwake;
        }
    }
}
