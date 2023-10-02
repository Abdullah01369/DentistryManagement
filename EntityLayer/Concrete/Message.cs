using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        public int Id { get; set; }
        public string MailSender { get; set; }
        public string MailReceiver { get; set; }
        public DateTime Date { get; set; }
        public string Tite { get; set; }
        public string Text { get; set; }
        public bool Status { get; set; }
    }
}
