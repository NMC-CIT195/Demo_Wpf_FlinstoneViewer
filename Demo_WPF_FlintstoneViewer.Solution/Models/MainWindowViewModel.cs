using Demo_WPF_FlintstonesViewer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Demo_WPF_FlintstoneViewer.Models
{
    public class MainWindowViewModel : ObservableObject
    {
        public ICommand DeleteCharacterCommand
        {
            get { return new DelegateCommand(OnDeleteCharacter); }
        }

        #region ENUMS



        #endregion

        #region FIELDS

        private TalentAgency _talentAgency;
        private ObservableCollection<Character> _characters;
        private Character _selectedCharacter;

        #endregion

        #region PROPERTIES

        public TalentAgency TalentAgency
        {
            get { return _talentAgency; }
            set { _talentAgency = value; }
        }

        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set { _characters = value; }
        }

        public Character SelectedCharacter
        {
            get { return _selectedCharacter; }
            set
            {
                if (_selectedCharacter == value)
                {
                    return;
                }
                _selectedCharacter = value;
                RaisePropertyChangedEvent("SelectedCharacter");
            }
        }


        #endregion

        #region CONSTRUCTORS

        public MainWindowViewModel()
        {
            
        }

        #endregion

        #region METHODS

        private void OnDeleteCharacter()
        {
            _characters.Remove(_selectedCharacter);
        }

        #endregion

        #region EVENTS


        #endregion


    }
}
