using SolarPlant;

namespace SolarPlant
{
    public class PowerModel
    {
        private PowerPriority priority;
        private int powerUnlock;
        private int basePowerDraw;
        private int maxPowerDraw;
        private int currentPowerDraw;

        public PowerPriority Priority
        {
            get
            {
                return priority;
            }

            set
            {
                priority = value;
            }
        }

        public int PowerUnlock
        {
            get
            {
                return powerUnlock;
            }

            set
            {
                powerUnlock = value;
            }
        }

        public int BasePowerDraw
        {
            get
            {
                return basePowerDraw;
            }

            set
            {
                basePowerDraw = value;
            }
        }

        public int MaxPowerDraw
        {
            get
            {
                return maxPowerDraw;
            }

            set
            {
                maxPowerDraw = value;
            }
        }

        public int CurrentPowerDraw
        {
            get
            {
                return currentPowerDraw;
            }

            set
            {
                currentPowerDraw = value;
            }
        }
    }
}
