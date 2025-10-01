public class Lasagna
{
    // The expected time is 40 minutes.
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven(int actualMinutesInOven)' method
        // This method calculates the remaining time: ExpectedMinutesInOven() - actualMinutesInOven
    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return ExpectedMinutesInOven()-actualMinutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes(int layers)' method
        // This method calculates preparation time: layers * 2 minutes
        // Each layer takes 2 minutes. Multiply the number of layers by 2.
        public int PreparationTimeInMinutes(int layers)
    {
           return layers*2;
    }

    // TODO: define the 'ElapsedTimeInMinutes(int layers, int actualMinutesInOven)' method
        // This method calculates total time: PreparationTimeInMinutes(layers) + actualMinutesInOven
        public int ElapsedTimeInMinutes(int layers, int actualMinutesInOven)
        {
        // Total time is preparation time plus oven time.
        // We reuse the PreparationTimeInMinutes method to get the prep time.
        int totalPreparationTime = PreparationTimeInMinutes(layers);

        // Sum the preparation time and the time already spent in the oven.
        return totalPreparationTime + actualMinutesInOven; 
        }
}