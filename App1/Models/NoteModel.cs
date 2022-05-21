using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class NoteModel
    {
        public string NotesText { get; set; }
        public bool Submit { get; set; }

        public NoteModel(string NotesText, bool Submit) 
        {
            this.NotesText = NotesText;
            this.Submit = Submit;
        
        }

    }
}
