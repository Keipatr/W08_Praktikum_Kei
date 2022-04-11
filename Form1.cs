using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace W08_Praktikum_Kei
{
    public partial class formPertandingan : System.Windows.Forms.Form
    {
        public formPertandingan()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=; database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void formPertandingan_Load(object sender, EventArgs e)
        {
            DataTable dtTeamHome = new DataTable();
            DataTable dtTeamAway = new DataTable();
            sqlQuery = "SELECT * FROM team,manager,player where team.manager_id = manager.manager_id and team.captain_id = player.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamHome);
            sqlAdapter.Fill(dtTeamAway);
            cBoxTimAway.DataSource = dtTeamAway;
            cBoxTimAway.DisplayMember = "team_name";
            cBoxTimAway.ValueMember = "manager_name";
            cBoxTimHome.DataSource = dtTeamHome;
            cBoxTimHome.DisplayMember = "team_name";
            cBoxTimHome.ValueMember = "manager_name";
        }

        private void cBoxTimHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxTimHome.ValueMember = "manager_name";
            lblManagerHome.Text = cBoxTimHome.SelectedValue.ToString();            
            DataTable dtCaptain = new DataTable();
            DataTable dtStadium = new DataTable();
            DataTable dtCapacity = new DataTable();
            sqlQuery = "SELECT * FROM team,manager,player where team.manager_id = manager.manager_id and team.captain_id = player.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCaptain);
            sqlAdapter.Fill(dtCapacity);
            sqlAdapter.Fill(dtStadium);
            lblCaptainHome.Text = dtCaptain.Rows[cBoxTimHome.SelectedIndex]["player_name"].ToString();
            lblStadium.Text = dtStadium.Rows[cBoxTimHome.SelectedIndex]["home_stadium"].ToString();
            lblCapacity.Text = dtCapacity.Rows[cBoxTimHome.SelectedIndex]["capacity"].ToString();
        }

        private void cBoxTimAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxTimAway.ValueMember = "manager_name";
            lblManagerAway.Text = cBoxTimAway.SelectedValue.ToString();
            DataTable dtCaptain = new DataTable();
            sqlQuery = "SELECT * FROM team,manager,player where team.manager_id = manager.manager_id and team.captain_id = player.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCaptain);
            lblCaptainAway.Text = dtCaptain.Rows[cBoxTimAway.SelectedIndex]["player_name"].ToString();
        }
    }
}
