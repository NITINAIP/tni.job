using System.Data;

namespace Tni.Job.Repositories;

public interface IExampleRepo
{

}

public class ExampleRepo(IDbConnection dbConnection) : IExampleRepo
{

}