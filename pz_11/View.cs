using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace pz_11
{
    public class View
    {
        public string TextBookName { get; set; }
        public string TextYear { get; set; }
        public string TextAuthor { get; set; }
        public Button ButtonSave { get; set; }
        public ListView ListViewBooks { get; set; }
    }
}
