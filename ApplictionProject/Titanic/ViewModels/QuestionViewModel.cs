using Titanic.Models;
using Titanic.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Titanic.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class QuestionViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;

        public string Id { get; set; }
        public ObservableCollection<Item> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command NextQuestion { get; } 
        public QuestionViewModel()
        {
            Title = "Question";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            NextQuestion = new Command(Question);
            text = "Press the button to start";

            Text = text;
            Description = description;
        }
        void Question()
        {
            try
            {
                IsBusy = true;
                int i = Items.Count;
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                int a = rand.Next(i + 1);
                Text = Items[a].Text;
                Description = Items[a].Description;

            }catch(Exception e)
            {
                Debug.WriteLine(e);
            }
            return;
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
