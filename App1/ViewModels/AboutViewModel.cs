using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace App1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ObservableCollection<FeedNoteModel> FeedNotes { get; set; }

        public AboutViewModel()
        {
            Title = "Home_Feed";

            FeedNotes = new ObservableCollection<FeedNoteModel>();
            FeedNotes.Add(new FeedNoteModel("note 1", false));
        }
        public ICommand AddFeedNoteCommand => new Command(AddFeedNote);
        public string NewFeedNote { get; set; }

        void AddFeedNote()
        {
            FeedNotes.Add(new FeedNoteModel(DateTime.Now + " " + NewFeedNote, false));
        }

    }
}