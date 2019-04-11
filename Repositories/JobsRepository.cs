using System.Collections.Generic;
using System.Data;
using contracted.Models;
using Dapper;

namespace contracted.Repositories
{
  public class JobsRepository
  {

    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }
    public IEnumerable<Job> GetAll()
    {
      return _db.Query<Job>("SELECT * FROM jobs");
    }



  }
}