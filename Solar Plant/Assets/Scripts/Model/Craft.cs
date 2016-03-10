using SolarPlant;

namespace SolarPlant
{
    public class Craft : PowerModel
    {
        private Planet destination;
        private float poweredSpeed;
        private float unpoweredSpeed;
        private CraftAction action;

        public Planet Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public float PoweredSpeed
        {
            get
            {
                return poweredSpeed;
            }

            set
            {
                poweredSpeed = value;
            }
        }

        public float UnpoweredSpeed
        {
            get
            {
                return unpoweredSpeed;
            }

            set
            {
                unpoweredSpeed = value;
            }
        }

        public CraftAction Action
        {
            get
            {
                return action;
            }

            set
            {
                action = value;
            }
        }
    }
}
