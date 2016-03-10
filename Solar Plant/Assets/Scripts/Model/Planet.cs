namespace SolarPlant
{
    public class Planet : PowerModel
    {
        private PlanetSize size;
        private PlanetAction currentAction;
        private int[] actionProgress;

        public Planet()
        {
            Initialize();
        }

        private void Initialize()
        {
            actionProgress = new int[4];
        }

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
