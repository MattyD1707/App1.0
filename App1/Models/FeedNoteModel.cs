using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class FeedNoteModel
    {
        public string FeedNotesText { get; set; }
        public bool FeedSubmit { get; set; }

        public FeedNoteModel(string FeedNotesText, bool FeedSubmit)
        {
            this.FeedNotesText = FeedNotesText;
            this.FeedSubmit = FeedSubmit;

        }

    }
}
