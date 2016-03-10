using SolarPlant;
using System.Collections.Generic;

public class PowerController
{
    private List<PowerModel> poweredUnits;
    private List<PowerGenerator> powerGenerators;

    public PowerController()
    {
        Initialize();
    }

    private void Initialize()
    {
        poweredUnits = new List<PowerModel>();
        powerGenerators = new List<PowerGenerator>();
    }

    private void updatePowerDraw()
    {
        //Work out how much power there is to spread around
        int totalGridPower = 0;
        foreach (PowerGenerator p in powerGenerators)
            totalGridPower += p.CurrentPowerCapacity;

        //Separate units into high and regular priority
        List<PowerModel> high = new List<PowerModel>();
        List<Planet> regular = new List<Planet>();
        foreach (PowerModel p in poweredUnits)
        {
            if (p.Priority == PowerPriority.HIGH)
                high.Add(p);
            else
                regular.Add((Planet)p);
        }

        //Assign high priority crafts their max power
        foreach (PowerModel p in high)
            totalGridPower -= p.MaxPowerDraw;

        //Add up the relative size units of planets
        int totalPowerUnits = 0;
        foreach (Planet p in regular)
            totalPowerUnits += (int)p.Size;

        //Divide the remaining power to planets based on their size
        int powerUnit = totalGridPower / totalPowerUnits;
        foreach (Planet p in regular)
            p.CurrentPowerDraw = powerUnit * (int)p.Size;
    }

    public void addPoweredUnit(PowerModel unit)
    {
        poweredUnits.Add(unit);
        updatePowerDraw();
    }

    private void removePoweredUnit(PowerModel unit)
    {
        for (int i = 0; i < poweredUnits.Count; i++)
        {
            if (poweredUnits[i] == unit)
            {
                poweredUnits.RemoveAt(i);
                return;
            }
        }
    }

    public void addPowerGenerator(PowerGenerator generator)
    {
        powerGenerators.Add(generator);
        updatePowerDraw();
    }
}