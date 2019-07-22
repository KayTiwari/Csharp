using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWPF.Data
{
  public enum Gender
  {
    Unknown = 0,
    Male = 1,
    Female = 2
  }

  public class Person
  {
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDate { get; set; }

    public Gender Gender { get; set; }

    public bool IsDead { get; set; }
  }
}
