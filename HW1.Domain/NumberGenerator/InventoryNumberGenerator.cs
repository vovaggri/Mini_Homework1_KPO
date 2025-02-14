namespace HW1.Domain.NumberGenerator;

public class InventoryNumberGenerator : IInventoryNumberGenerator
{
    private int _current = 0;
    public int GetNextInventoryNumber()
    {
        _current++;
        return _current;
    }
}