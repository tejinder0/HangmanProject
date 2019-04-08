using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
namespace Hangman.Resources
{
    [Table("HangmanQuestions")]
    public class HangmanQuestion
    {
        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
