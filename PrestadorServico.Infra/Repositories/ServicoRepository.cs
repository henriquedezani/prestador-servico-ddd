using System;
using System.Collections.Generic;
using PrestadorServico.Domain.Entities;
using PrestadorServico.Domain.Repositories;

namespace PrestadorServico.Infra.Repositories
{
  public class ServicoRepository : IServicoRepository
  {
    public void Create(Servico e)
    {
      // USAR O SQL SERVER, POSTGRES, MONGODB, Web Service (API)
    }

    public void Delete(Servico e)
    {
      throw new NotImplementedException();
    }

    public List<Servico> Read()
    {
      throw new NotImplementedException();
    }

    public List<Servico> Read(Status status)
    {
      throw new NotImplementedException();
    }

    public List<Servico> Read(string usuario, Status status)
    {
      throw new NotImplementedException();
    }

    public List<Servico> Read(string usuario)
    {
      throw new NotImplementedException();
    }

    public Servico Read(Guid id)
    {
      throw new NotImplementedException();
    }

    public void Update(Servico e)
    {
      throw new NotImplementedException();
    }
  }
}