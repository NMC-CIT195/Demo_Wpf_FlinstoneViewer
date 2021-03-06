﻿using Demo_WPF_FlintstonesViewer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Demo_WPF_FlintstoneViewer.Models
{
    public class MainWindowViewModel : ObservableObject
    {
        public ICommand DeleteCharacterCommand
        {
            get { return new DelegateCommand(OnDeleteCharacter); }
        }

        public ICommand EditCharacterCommand
        {
            get { return new DelegateCommand(OnEditCharacter); }
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
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show($"Are you sure you want to delete {_selectedCharacter.FullName}?", "Delete Character", System.Windows.MessageBoxButton.OKCancel);

            if (messageBoxResult == MessageBoxResult.OK)
            {
                _characters.Remove(_selectedCharacter);
            }
        }

        private void OnEditCharacter()
        {

        }

        #endregion

        #region EVENTS


        #endregion


    }
}
