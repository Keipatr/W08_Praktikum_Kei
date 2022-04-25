using MySql.Data.MySqlClient;
using System;
using System.Data;


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
            sqlQuery = "SELECT * FROM team,manager,player,`match` where team.manager_id = manager.manager_id and team.captain_id = player.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamHome);
            sqlAdapter.Fill(dtTeamAway);
            cBoxTimAway.DataSource = dtTeamAway;
            cBoxTimAway.DisplayMember = "team_name";
            cBoxTimHome.DataSource = dtTeamHome;
            cBoxTimHome.DisplayMember = "team_name";
            cBoxTimAway.ValueMember = "team_id";
            cBoxTimHome.ValueMember = "team_id";
        }

        private void cBoxTimHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtCaptain = new DataTable();
            DataTable dtStadium = new DataTable();
            DataTable dtCapacity = new DataTable();
            DataTable dtManager = new DataTable();
            sqlQuery = "SELECT * FROM team,manager,player where team.manager_id = manager.manager_id and team.captain_id = player.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCaptain);
            sqlAdapter.Fill(dtCapacity);
            sqlAdapter.Fill(dtStadium);
            sqlAdapter.Fill(dtManager);
            lblManagerHome.Text = dtManager.Rows[cBoxTimAway.SelectedIndex]["manager_name"].ToString();
            lblCaptainHome.Text = dtCaptain.Rows[cBoxTimHome.SelectedIndex]["player_name"].ToString();
            lblStadium.Text = dtStadium.Rows[cBoxTimHome.SelectedIndex]["home_stadium"].ToString();
            lblCapacity.Text = dtCapacity.Rows[cBoxTimHome.SelectedIndex]["capacity"].ToString();
        }

        private void cBoxTimAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtCaptain = new DataTable();
            DataTable dtManager = new DataTable();
            sqlQuery = "SELECT * FROM team,manager,player where team.manager_id = manager.manager_id and team.captain_id = player.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCaptain);
            sqlAdapter.Fill(dtManager);
            lblCaptainAway.Text = dtCaptain.Rows[cBoxTimAway.SelectedIndex]["player_name"].ToString();
            lblManagerAway.Text = dtManager.Rows[cBoxTimAway.SelectedIndex]["manager_name"].ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            DataTable dtTanggal = new DataTable();
            sqlQuery = "select date_format(match_date, \"%e %M %Y\") as Tanggal from `match`  where team_home = '" + cBoxTimHome.SelectedValue.ToString() + "' and team_away = '" + cBoxTimAway.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTanggal);
            lbTanggal.Text = dtTanggal.Rows[cBoxTimHome.SelectedIndex]["Tanggal"].ToString();

            DataTable dtSkor = new DataTable();
            sqlQuery = "select concat(goal_home, ' - ', goal_away) as skor from `match` where team_home = '" + cBoxTimHome.SelectedValue.ToString() + "' and team_away = '" + cBoxTimAway.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);                            
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtSkor);
            lbSkor.Text = dtSkor.Rows[cBoxTimHome.SelectedIndex]["skor"].ToString();

            DataTable dtGrid = new DataTable();
            sqlQuery = "select minute,if (p.team_id = team_home, player_name,'') as 'Player Name 1', if (p.team_id = team_home,if (type = 'CY','Yellow Card',if (type = 'CR','Red Card',if (type = 'GO','Goal',if (type = 'GP','Goal Penalty',if (type = 'GW','Own Goal','Penalty Miss'))))),'') as 'Tipe 1', if (p.team_id = team_away, player_name,'') as 'Player Name 2', if (p.team_id = team_away,if (type = 'CY','Yellow Card',if (type = 'CR','Red Card',if (type = 'GO','Goal',if (type = 'GP','Goal Penalty',if (type = 'GW','Own Goal','Penalty Miss'))))),'') as 'Tipe 2' from `match` m,dmatch d, player p where p.player_id = d.player_id and d.match_id = m.match_id and m.team_away = '" + cBoxTimAway.SelectedValue.ToString() + "'and m.team_home = '" + cBoxTimHome.SelectedValue.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtGrid);                        
            dtgMatch.DataSource = dtGrid;
        }
    }
}
