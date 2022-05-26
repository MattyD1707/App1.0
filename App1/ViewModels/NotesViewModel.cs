using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Collections.ObjectModel;


namespace App1.ViewModels
{
    public class NotesViewModel : BaseViewModel
    {
        public ObservableCollection<NoteModel> Notes { get; set; }
        public NotesViewModel()
        {
            Title = "Notes";

            Notes = new ObservableCollection<NoteModel>();
        }

        public ICommand AddNoteCommand => new Command(AddNote);
        public string NewNote { get; set; }

        void AddNote() 
        {
            Notes.Add(new NoteModel(NewNote, false));
        }



    }
}
