using System;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using GMS_BusinessLogic;

namespace GMS_Desktop.Report
{
    public partial class frmReport : Form
    {
        Membership _Membership;
        Coach _Coach;
        OfferClassSubscription _OfferClassSubscription;
        SalesOrder _SalesOrder;


        public frmReport()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _NumberOfMembershipsInCategories()
        {   
            chart2.Series.Clear();
            chart2.Titles.Clear();
            chart2.Titles.Add("Memberships In Each Categories");

            _Membership = new Membership();

            Dictionary<string, int> data = _Membership.numberOfMembershipsInCategories();

            foreach (var item in data)
            {
                Series series = new Series(item.Key);

                series.ChartType = SeriesChartType.Column;
                series.Points.AddXY("Current", item.Value);
                series.IsValueShownAsLabel = true;

                chart2.Series.Add(series);
            }

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            chart1.Titles.Add("Gym Report");
            _Membership = new Membership();
            _Coach = new Coach();
            _OfferClassSubscription = new OfferClassSubscription();
            _SalesOrder = new SalesOrder();

            // Add data for number of memberships
            Series membershipSeries = new Series("Memberships");
            membershipSeries.ChartType = SeriesChartType.Column;
            membershipSeries.Points.AddXY("Current", _Membership.get().Rows.Count);
            membershipSeries.IsValueShownAsLabel = true;

            // Add data for number of coaches
            Series coachSeries = new Series("Coaches");
            coachSeries.ChartType = SeriesChartType.Column;
            coachSeries.Points.AddXY("Total", _Coach.get().Rows.Count);
            coachSeries.IsValueShownAsLabel = true;

            // Add data for membershipsToOffers
            int offersCount = _OfferClassSubscription.getOfferSubscripers(_OfferClassSubscription).Rows.Count;
            Series membershipsToOffers = new Series("MembershipsToOffer");
            membershipsToOffers.ChartType = SeriesChartType.Column;
            membershipsToOffers.Points.AddXY("Offer", offersCount);
            membershipsToOffers.IsValueShownAsLabel = true;

            decimal salesProfits = _SalesOrder.getSalesProfits();
            Series profitsOfSales = new Series("Profits Of Sales");
            profitsOfSales.ChartType = SeriesChartType.Column;
            profitsOfSales.Points.AddXY("Profits", salesProfits);
            profitsOfSales.IsValueShownAsLabel = true;

            // Add series to chart
            chart1.Series.Add(membershipSeries);
            chart1.Series.Add(coachSeries);
            chart1.Series.Add(membershipsToOffers);
            chart1.Series.Add(profitsOfSales);

            _NumberOfMembershipsInCategories();
        }

    }
}
