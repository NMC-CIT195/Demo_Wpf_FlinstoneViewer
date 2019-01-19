using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_WPF_FlintstonesViewer;
using Demo_Wpf_FlintstoneViewer;
using Demo_WPF_FlintstoneViewer.Models;

namespace Demo_WPF_FlintstoneViewer.BusinessLayer
{
    public class FlintstoneViewerBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        MainWindowViewModel _mainWindowViewModel;

        #endregion

        #region PROPERTIES



        #endregion

        #region CONSTRUCTORS

        public FlintstoneViewerBL()
        {
            _mainWindowViewModel = new MainWindowViewModel();
            InitializeTalentAgencyData();
            InitializeCharacterData();

            //
            // instantiate and show the Main Window
            //
            MainWindowView mainWindowView = new MainWindowView();
            mainWindowView.DataContext = _mainWindowViewModel;
            mainWindowView.Show();
        }

        #endregion

        #region METHODS

        private void InitializeTalentAgencyData()
        {
            _mainWindowViewModel.TalentAgency = new TalentAgency()
            {
                Name = "Troglodyte Talent Agency",
                Address = "465 Jurassic Lane",
                City = "Bedrock"
            };
        }


        private void InitializeCharacterData()
        {
            _mainWindowViewModel.Characters = new ObservableCollection<Character>()
            {
                new Character()
                {
                   Id = 1,
                   FirstName = "Fred",
                   LastName = "Flintstone",
                   Age = 28,
                   Gender = Character.GenderType.Male,
                   ImageFileName = "fred_flintstone.jpg",
                   Description = "Fred is the main character of the series. He's an accident-prone bronto-crane operator at the Slate Rock and Gravel Company and the head of the Flintstone household. He is quick to anger (usually over trivial matters), but is nonetheless a very loving husband and father. He's also good at bowling and is a member of the fictional Loyal Order of Water Buffaloes (Lodge No. 26), a men-only club paralleling real-life fraternities such as the Loyal Order of Moose.",
                  HireDate = DateTime.Parse("03-23-1963"),
                  AverageAnnualGross = 23445.85
                },
                new Character()
                {
                   Id = 1,
                   FirstName = "Wilma",
                   LastName = "Flintstone",
                   Age = 28,
                   Gender = Character.GenderType.Female,
                   ImageFileName = "wilma_flintstone.jpg",
                   Description = "Wilma is Fred's wife. She is more intelligent and level-headed than her husband, though she often has a habit of spending money recklessly (with Betty and her catchphrase being 'Da-da-da duh da-da CHARGE IT!!'). She's often a foil to Fred's poor behavior.",
                   HireDate = DateTime.Parse("03-23-1963"),
                   AverageAnnualGross = 45834.00
                },
                new Character()
                {
                   Id = 1,
                   FirstName = "Pebbles",
                   LastName = "Flintstone",
                   Age = 1,
                   Gender = Character.GenderType.Female,
                   ImageFileName = "wilma_flintstone.jpg",
                   Description = "Pebbles is the Flintstones' infant daughter, who is born near the end of the third season.",
                   HireDate = DateTime.Parse("03-23-1966"),
                   AverageAnnualGross = 8364.75
                }
            };
        }

        #endregion

        #region EVENTS



        #endregion

    }
}
