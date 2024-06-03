using Command.CeilingFan;

static class CeilingFanHelpers
{
    public static void Undo(int prevSpeed, CeilingFan ceilingFan)
    {
        if (prevSpeed == CeilingFan.HIGH) { ceilingFan.High(); }
        else if (prevSpeed == CeilingFan.MEDIUM) { ceilingFan.Medium(); }
        else if (prevSpeed == CeilingFan.LOW) { ceilingFan.Low(); }
        else if (prevSpeed == CeilingFan.OFF) { ceilingFan.Off(); }
    }
}