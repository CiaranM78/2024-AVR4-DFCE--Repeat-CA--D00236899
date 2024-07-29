namespace AVR
{
    /// <summary>
    /// Defines the core attributes that an object can modify in a player.
    /// For example, a health pickup will modify speed, strength, or stamina.
    /// </summary>
    /// <see cref="Objects.ConsumableObjectData"/>
    public enum AttributeType : sbyte
    {
        Agility, Ammo, Armor, Intelligence, Knowledge, Mana, Sight, Speed, Strength, Stamina
    }
}