using Microsoft.Data.SqlClient;

public abstract class Database : IDisposable
{
    protected SqlConnection connection;

    public Database()
    {
        connection = new SqlConnection("Data Source= localhost; Initial" + 
        "Catalog=LOGIN_IETELSOLAR; Integrated Security = false;user id = SA; password = @Rthur552; TrustServerCertifica=true;");
        connection.Open();
    }

    public void Dispose()
    {
        connection.Close();

    }
}