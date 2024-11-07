using Microsoft.Data.SqlClient;

namespace WFA241107;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
        this.Load += FrmMain_Load;
    }

    private void FrmMain_Load(object? sender, EventArgs e)
    {
        //server 'címe':
        string connectionString = 
            "SERVER = (localdb)\\MSSQLLocalDB;" +
            "DATABASE = elso;";

        //csatlakozni a serverhez
        using SqlConnection conn = new(connectionString);
        conn.Open();

        //def. query
        SqlCommand cmd = new("SELECT * FROM emberek;", conn);

        //run. query
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            //output
            rtb.Text += $"{reader["id"]} {reader["nev"]} {reader["szul"]} {reader["jogsi"]}\n";
        }

    }
}
