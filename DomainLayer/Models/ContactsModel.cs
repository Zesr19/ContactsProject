using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class ContactsModel : BaseEntity
    {
        // Variables privadas
        private int _id;
        private string _name;
        private string _nickname;
        private string _email;
        private string _note;

        // Variables publicas
        //public int Id { get { return _id; } }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public string Telephone { get; set; }
        /*
        public List<TelephonesModel> Telephones { get; set; }
        public List<AddressesModel> Addresses { get; set; }
        public GroupsModel Group { get; set; }
        */
        // Constructor
        public ContactsModel() { }
        public ContactsModel(string name)
        {
            Name = name;
        }

        public ContactsModel(string name, string nickname) : this(name)
        {
            Nickname = nickname;
        }

        public ContactsModel(string name, string nickname, string email) : this(name, nickname)
        {
            Email = email;
        }

        public ContactsModel(string name, string nickname, string email, string note) : this(name, nickname, email)
        {
            Note = note;
        }
        /*
        public ContactsModel(string name, string nickname, string email, string note, List<TelephonesModel> telephones) : this(name, nickname, email, note)
        {
            Telephones = telephones;
        }
        */
    }
}
