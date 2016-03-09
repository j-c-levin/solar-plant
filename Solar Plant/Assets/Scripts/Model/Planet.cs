using SolarPlant;

namespace SolarPlant
{
    public class Planet
    {
        private PlanetSize size;
        private int powerUnlock;
        private int basePowerDraw;
        private int maxPowerDraw;
        private PlanetAction currentAction;
        private int[] actionProgress;

        public PlanetSize Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
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

        public PlanetAction CurrentAction
        {
            get
            {
                return currentAction;
            }

            set
            {
                currentAction = value;
            }
        }

        public void updateActionProgress(int progress)
        {
            actionProgress[(int)currentAction] = progress;
        }
    }
}
