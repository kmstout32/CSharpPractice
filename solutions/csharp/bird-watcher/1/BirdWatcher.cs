class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
      return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return this.birdsPerDay[this.birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
 // Today's count is at the last index of the array: (length - 1).
    // Increment the value at that array position.
    this.birdsPerDay[this.birdsPerDay.Length - 1]++;    }

    public bool HasDayWithoutBirds()
    {
         return this.birdsPerDay.Any(count => count == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
         int totalCount = 0;
        
        // Use Math.Min to ensure the loop doesn't go beyond the array bounds 
        // if numberOfDays is larger than the number of recorded days.
        int limit = Math.Min(numberOfDays, this.birdsPerDay.Length);

        // Sum the counts for the first 'limit' number of days, starting from index 0.
        for (int i = 0; i < limit; i++)
        {
            totalCount += this.birdsPerDay[i];
        }

        return totalCount;
        }



    public int BusyDays()
    {
       return this.birdsPerDay.Count(count => count >= 5);
    }
}
