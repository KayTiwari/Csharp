using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using BlackJackWPF.Data;

namespace BlackJackWPF
{
  public class MainWindowVM : BaseVM
  {
    private bool isDeadChecked;
    private string firstName;

    private ObservableCollection<Person> people;

    public MainWindowVM()
    {
      this.People = new ObservableCollection<Person>();
      this.People.CollectionChanged += (s, arg) =>
      {
        if (arg.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
        {
          CommandManager.InvalidateRequerySuggested();          
        }
      };

      this.ClickMeCommand = new SimpleCommand((obj) => true,
        (obj) =>
          {
            Person newGuy = new Person()
            {
              FirstName = "New",
              LastName = "Person",
              BirthDate = new DateTime(1995, 12, 25),
              Gender = Gender.Male,
              IsDead = this.IsDeadChecked
            };

            this.People.Add(newGuy);
          });
    }

    public string FirstName
    {
      get
      {
        return this.firstName;
      }

      set
      {
        this.firstName = value;
        // this.Names.Add(value);
        this.OnNotify();
      }
    }

    public bool IsDeadChecked
    {
      get
      {
        return this.isDeadChecked;
      }

      set
      {
        this.isDeadChecked = value;
        this.OnNotify();
      }
    }

    public ICommand ClickMeCommand { get; set; }

    public ObservableCollection<Person> People
    {
      get
      {
        return this.people;
      }

      set
      {
        this.people = value;
        this.OnNotify();
      }
    }

    public void SetName(string firstName, string LastName)
    {
      this.FirstName = firstName;
    }
  }
}
