using Microsoft.Data.SqlClient;

public class LoginSql : Database, ILoginData
{
    public void Verificacao(Login login)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = connection;
        cmd.CommandText = "SELECT * FROM [LOGIN] WHERE Email = @usuario AND Pass = @senha";
        cmd.Parameters.AddWithValue("@usuario", login.Usuario);
        cmd.Parameters.AddWithValue("@senha", login.Senha);

        SqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read())
        {
            Login login1 = new Login();
            login1.Usuario = reader.GetString(0);
            login1.Senha = reader.GetString(1);
        }
    }

}