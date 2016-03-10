namespace SolarPlant
{
    public class PowerGenerator
    {
        private int maxPowerCapacity;
        private int currentPowerCapacity;

        public int MaxPowerCapacity
        {
            get
            {
                return maxPowerCapacity;
            }

            set
            {
                maxPowerCapacity = value;
            }
        }

        public int CurrentPowerCapacity
        {
            get
            {
                return currentPowerCapacity;
            }

            set
            {
                currentPowerCapacity = value;
            }
        }
    }
}
