using Microsoft.Data.SqlClient;

namespace WFA241107;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
        this.Load += FrmMain_Load;
        txb.TextChanged += Txb_TextChanged;
    }

    private void Txb_TextChanged(object? sender, EventArgs e) 
        => Lekerdezes(txb.Text);

    private void FrmMain_Load(object? sender, EventArgs e) 
        => Lekerdezes();

    private void Lekerdezes(string szoveg = "")
    {
        rtb.Clear();

        //server 'címe':
        string connectionString =
            "SERVER = (localdb)\\MSSQLLocalDB;" +
            "DATABASE = elso;";

        //csatlakozni a serverhez
        using SqlConnection conn = new(connectionString);
        conn.Open();

        //def. query
        SqlCommand cmd = new(
            "SELECT * FROM emberek " +
            $"WHERE nev LIKE '{szoveg}%';",
            conn);

        //run. query
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            //output
            rtb.Text +=
                $"{reader["id"]} " +
                $"{reader["nev"]} " +
                $"{reader.GetDateTime(2):yyyy-MM-dd} " +
                $"{(reader.GetBoolean(3) ? "van" : "nincs")}\n";
        }
    }
}
