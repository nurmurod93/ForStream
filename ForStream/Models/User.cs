using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForStream.Models
{
    public class User : IEqualityComparer<User>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
        public int CarId { get; set; }

        //public List<int> CarId = new List<int>();

        public string Phone { get; set; }

        public bool Equals(User x, User y)
        {
            return (x.FirstName == y.FirstName && x.LastName == y.LastName && x.Phone == y.Phone);
        }

        public int GetHashCode([DisallowNull] User obj)
        {
            if(obj is null)
            return 0;
            
            int IdHashCode = obj.Id.GetHashCode();
            int NameHeshCode = obj.FirstName is null ? 0 : obj.FirstName.GetHashCode();

            return IdHashCode ^ NameHeshCode;
        }
    }
}
