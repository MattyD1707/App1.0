using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using System.Collections.Generic;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ObservableCollection<FeedNoteModel> FeedNotes { get; set; }

        public AboutViewModel()
        {
            Title = "Home_Feed";

            FeedNotes = new ObservableCollection<FeedNoteModel>();
           // FeedNotes.Add(new FeedNoteModel("note 1", false));
        }
        public ICommand AddFeedNoteCommand => new Command(AddFeedNote);
        public string NewFeedNote { get; set; }

        public void AddFeedNote()
        {
            string note = NewFeedNote;
            App.FDatabase.SaveFeedAsync(new Feed
            {
                Date = DateTime.Now,
                Text = note

            });
         //   FeedNotes.Add(new FeedNoteModel(DateTime.Now + " " + NewFeedNote, false));

        }



    }
}