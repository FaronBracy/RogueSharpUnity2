﻿
public class HeadEquipment : Equipment
{
    public static HeadEquipment None()
    {
        return new HeadEquipment { Name = "None" };
    }

    public static HeadEquipment Leather()
    {
        return new HeadEquipment()
        {
            Defense = 1,
            DefenseChance = 5,
            Name = "LeatherH"
        };
    }

    public static HeadEquipment Chain()
    {
        return new HeadEquipment()
        {
            Defense = 1,
            DefenseChance = 10,
            Name = "ChainH"
        };
    }

    public static HeadEquipment Plate()
    {
        return new HeadEquipment()
        {
            Defense = 1,
            DefenseChance = 15,
            Name = "PlateH"
        };
    }
}
