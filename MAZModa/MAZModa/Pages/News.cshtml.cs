using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAZModa.Data;
using MAZModa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MAZModa.Pages
{
    public class NewsModel : PageModel
    {
        public MAZModaDbContext context { get; set; }
        public Note NextNote { get; set; }
        public Note PreviousNote { get; set; }
        

        [BindProperty]
        public int CurrentNoteId { get; set; }
        public ICollection<Note> NotesList { get; set; }

        public NewsModel(MAZModaDbContext _context)
        {
            this.context = _context;
            this.CurrentNoteId = context.Note.Where(n=>n.IsDisplayed==true).Select(n=>n.Id).FirstOrDefault();
            this.NotesList = context.Note.OrderByDescending(n => n.Date).ToList();
            
        }
        public void OnGet()
        {
            
            //PreviousNote.IsDisplayed = false;
            
            //context.Note.Where(n => n.Id == CurrentNoteId).FirstOrDefault() = EditedNote;
        }

        public IActionResult OnPost(int _noteId)
        {
            foreach (var note in NotesList)
            {
                if (note.IsDisplayed == false)
                {
                    NextNote = note;
                    NextNote.IsDisplayed = true;
                    NextNote.Date = DateTime.Now.ToString("MMMM dd");
                    //context.Note.Update(NextNote);
                    context.SaveChanges();
                    break;
                }
            }
            PreviousNote = context.Note.Where(n => n.Id == _noteId).FirstOrDefault();
            PreviousNote.IsDisplayed = false;
            //context.Add(PreviousNote);
            context.SaveChanges();

            return Page();
            
        }
    }
}