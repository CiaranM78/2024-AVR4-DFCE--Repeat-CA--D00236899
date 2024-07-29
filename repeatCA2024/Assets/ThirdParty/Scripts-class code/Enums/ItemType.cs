using System.ComponentModel;

namespace AVR
{
    /// <summary>
    /// Used in a ScriptableObject to indicate the type of the item about which the SO is storing information
    /// </summary>
    /// <see cref="Objects.BaseObjectData"/>
    public enum ItemType : sbyte
    {
        [Description("Ammunition for weapons.")]
        Ammo,

        [Description("Equipment for characters.")]
        Equipment,

        [Description("Consumable food items.")]
        Food,

        [Description("A building in the game.")]
        Building,

        [Description("Medical items for healing.")]
        Medicine,

        [Description("Non-playable character.")]
        NPC,

        [Description("The player character.")]
        Player,

        [Description("Items related to the game's story.")]
        Story,

        [Description("An item related to a game quest.")]
        Quest,

        [Description("Weapons for characters.")]
        Weapon
    }
}