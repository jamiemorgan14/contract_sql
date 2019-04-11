using System.Collections.Generic;
using System.Data;
using contracted.Models;
using Dapper;

namespace contracted.Repositories
{
  public class ContractorsRepository
  {

    private readonly IDbConnection _db;
    public ContractorsRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Contractor> GetAll()
    {
      return _db.Query<Contractor>("SELECT * FROM contractors");
    }

    public Contractor GetById(string Id)
    {
      return _db.QueryFirstOrDefault<Contractor>($"SELECT * FROM contractors WHERE id = @Id", Id);
    }

    public Contractor NewContractor(Contractor contractor)
    {
      _db.Execute<int>("INSERT INTO contractors(id, name, rate)"
      + "VALUES (@Id, @Name, @Rate), ", contractor);
      return contractor;
    }

  }
}