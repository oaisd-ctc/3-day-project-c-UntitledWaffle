using System.Security.Cryptography.X509Certificates;
using RPGinventory;

namespace RPGInventory
{
    public class InventorySystem
    {
        private const int MAXIMUM_SLOTS_IN_INVENTORY = 10;
        public readonly List<InventoryRecord> InventoryRecords = new List<InventoryRecord>();
        public void AddItem(Obtainableitem item, int quantityToAdd)
        {
            while (quantityToAdd > 0)
            {
                // If an object of this item type already exists in the inventory, and has room to stack more items,
                // then add as many as we can to that stack.
                if (InventoryRecords.Exists(x => (x.InventoryItem.ID == item.ID) && (x.Quantity < item.MaximumStackableQuantity)))
                {
                    InventoryRecord inventoryRecord =
                    InventoryRecords.First(x => (x.InventoryItem.ID == item.ID) && (x.Quantity < item.MaximumStackableQuantity));
                    int maximumQuantityYouCanAddToThisStack = item.MaximumStackableQuantity - inventoryRecord.Quantity;
                    int quantityToAddToStack = Math.Min(quantityToAdd, maximumQuantityYouCanAddToThisStack);
                    inventoryRecord.AddToQuantity(quantityToAddToStack);
                    quantityToAdd -= quantityToAddToStack;
                }
                else
                {
                    if (InventoryRecords.Count < MAXIMUM_SLOTS_IN_INVENTORY)
                    {
                        InventoryRecords.Add(new InventoryRecord(item, 0));
                    }
                    else
                    {
                        throw new Exception("There is no more space in the inventory");
                    }
                }
            }
        }
        public class InventoryRecord
        {
            public Obtainableitem InventoryItem { get; private set; }
            public int Quantity { get; private set; }
            public InventoryRecord(Obtainableitem item, int quantity)
            {
                InventoryItem = item;
                Quantity = quantity;
            }
            public void AddToQuantity(int amountToAdd)
            {
                Quantity += amountToAdd;
            }
        }
    }
}