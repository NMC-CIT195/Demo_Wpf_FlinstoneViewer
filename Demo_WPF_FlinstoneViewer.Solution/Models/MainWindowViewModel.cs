﻿using Demo_WinForms_FlintstonesViewer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WPF_FlinstoneViewer.Models
{
    public class MainWindowViewModel
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private TalentAgency _talentAgency;
        private ObservableCollection<Character> _characters;





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

        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS



        #endregion

        #region EVENTS



        #endregion


    }
}