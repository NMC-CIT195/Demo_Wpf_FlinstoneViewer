using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WPF_FlinstoneViewer.BusinessLayer
{
    public class FlintstoneViewerBL
    {
        #region ENUMS



        #endregion

        #region FIELDS

        SalesTrackerViewModel _salesTrackerViewModel;

        #endregion

        #region PROPERTIES



        #endregion

        #region CONSTRUCTORS

        public SalesTrackerBL()
        {
            _salesTrackerViewModel = new SalesTrackerViewModel();
            InitializeSalespersonData();
            InitializeProduct();
            InitializeSalesData();

            //
            // instantiate and show the Main Window
            //
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = _salesTrackerViewModel;
            mainWindow.Show();
        }



        #endregion

        #region METHODS

        private void InitializeSalespersonData()
        {
            _salesTrackerViewModel.Salesperson = new Salesperson()
            {
                AccountId = 1001,
                FirstName = "Fred",
                LastName = "Flintstone"
            };
        }

        private void InitializeProduct()
        {
            _salesTrackerViewModel.Product = "Rainbow Widgets";
            _salesTrackerViewModel.UnitPrice = 3.95;
        }

        private void InitializeSalesData()
        {
            _salesTrackerViewModel.Transactions = new ObservableCollection<CityTransaction>()
            {
                new CityTransaction()
                {
                    CityName = "Detroit",
                    Date = DateTime.Parse("1/2/2018"),
                    Buy = 0,
                    Sell = 10,
                    Note = "Spent time with associate sales rep on the Circus discussing strategies.",
                    Photo = "detroit.jpg",
                    HasPhoto = true
                },
                new CityTransaction()
                {
                    CityName = "Grand Rapids",
                    Date = DateTime.Parse("1/3/2018"),
                    Buy = 5,
                    Sell = 5,
                    Note = "Met with the VP in charge of marketing for Widget International. It appears that their sales are skyrocketing and they will need us to increase our supply rate by 450%. After the meeting, she bought me a raspberry Bentley.",
                    Photo = "grand_rapids.jpg",
                    HasPhoto = true
                },
                new CityTransaction()
                {
                    CityName = "Traverse City",
                    Date = DateTime.Parse("1/7/2018"),
                    Buy = 15,
                    Sell = 0,
                    Note = "The drive up was rough and reported to the area representative later than anticipated.",
                    Photo = "",
                    HasPhoto = false
                }
            };
        }

        #endregion

        #region EVENTS



        #endregion

    }
}
