using S12_P4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace S12_P4.ViewModels
{
    public class SuperheroViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        public ObservableCollection<Superhero> Heroes { get; set; }

        public Superhero selectedHero;

        public Superhero SelectedHero 
        { 
            get => selectedHero; 
            set 
            { 
                if (selectedHero != value) 
                { 
                    selectedHero = value; 
                    OnPropertyChanged(nameof(SelectedHero));
                }
            }
        }

        public ICommand ShowHeroCommand { get; set; }

        public SuperheroViewModel()
        {
            Heroes = new ObservableCollection<Superhero>
            {
                new Superhero {Name = "Batman", Power = "Inteligencia", Image = "Batman.png"},
                new Superhero {Name = "Iron Man", Power = "Inteligencia", Image = "IronMan.png"},
                new Superhero {Name = "Superman", Power = "Superfuerza", Image = "Superman.png"},
                new Superhero {Name = "Wonder Woman", Power = "Fuerza y habilidades divinas", Image = "WonderWoman.png"},
                new Superhero {Name = "Flash", Power = "Velocidad", Image = "Flash.png"},
                new Superhero {Name = "Spider-Man", Power = "Agilidad y telarañas", Image = "SpiderMan.png"},
                new Superhero {Name = "Thor", Power = "Martillo Mjolnir y trueno", Image = "Thor.png"},
                new Superhero {Name = "Hulk", Power = "Fuerza descomunal", Image = "Hulk.png"},
                new Superhero {Name = "Doctor Strange", Power = "Magia y artes místicas", Image = "DoctorStrange.png"},
                new Superhero {Name = "Black Panther", Power = "Agilidad y tecnología avanzada", Image = "BlackPanther.png"},
                new Superhero {Name = "Captain America", Power = "Resistencia y liderazgo", Image = "CaptainAmerica.png"},
                new Superhero {Name = "Green Lantern", Power = "Anillo de poder", Image = "GreenLantern.png"}
            };

            SelectedHero = Heroes.Count > 0 ? Heroes[0] : null;
            ShowHeroCommand = new Command(async()=>
            {
                if (SelectedHero == null)
                {
                    await Application.Current.MainPage.DisplayAlert("Superheroes", "Selecciona un heroe", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(
                        "Heroe Seleccionado",
                        $"{SelectedHero.Name}\nPoder: {SelectedHero.Power}",
                        "OK");
                }
            });
        }
    }

}
