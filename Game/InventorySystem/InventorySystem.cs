using RPGinventory;

namespace RPGInventory
{
    public class InventorySystem
    {
        private const int MAXIMUM_SLOTS_IN_INVENTORY = 10;
        public readonly List<InventoryRecord> inventoryRecords = new List<InventoryRecord>();
        public void AddItem(Obtainableitem item, int qauntityToAdd)
        {
            while(qauntityToAdd > 0){
                if(inventoryRecords.Exists(x => (x.InventoryItem.ID == item.ID) && (x.Qauntity < item.MaximumStackableQauntity)))
                {
                    

                }
            }
        }
    }
}