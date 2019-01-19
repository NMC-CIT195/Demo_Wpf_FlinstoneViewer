﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WPF_FlinstoneViewer.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenderType Gender { get; set; }
        public string ImageFileName { get; set; }
        public string Description { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName()
        {
            return FirstName + (LastName != null ? " " + LastName : "") ;
        }

        #region ENUMS

        public enum GenderType { Male, Female }

        #endregion

        #region FIELDS



        #endregion

        #region PROPERTIES



        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS



        #endregion

        #region EVENTS



        #endregion
    }
}
