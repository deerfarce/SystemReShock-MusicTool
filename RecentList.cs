namespace SSR_Music_Packer_GUI;
public class RecentList<T> : List<T> {

    public int capacity = 10;

    public RecentList() { }
    //public RecentList(int capacity) { this.capacity = capacity; }
    public RecentList(params T[] items) { this.AddRange(items); this.RemoveExcess(); }
    public RecentList(List<T> items) { this.AddRange(items); this.RemoveExcess(); }

    public void AddItem(T item) {
        for (int i = this.Count - 1; i >= 0; i--) {
            if (item.Equals(this[i])) RemoveAt(i);
        }
        RemoveExcess();
        this.Add(item);
    }

    public void RemoveExcess() {
        for (int i = this.Count - 1; i >= this.capacity - 1; i--) {
            RemoveAt(i);
        }
    }

    public ToolStripItem[] GetItems() {
        ToolStripItem[] items = new ToolStripItem[Math.Max(this.Count, 1)];
        if (this.Count <= 0) {
            items[0] = new ToolStripMenuItem("(none)");
            items[0].Enabled = false;
        } else {
            string itemname;
            for (int i = 0; i < this.Count; i++) {
                itemname = this[this.Count - 1 - i].ToString();
                ToolStripMenuItem item = new ToolStripMenuItem((i + 1) + ". " + itemname);
                item.Tag = itemname;
                items[i] = item;
            }
        }
        return items;
    }

}
