﻿using BuscaCepApi.Models;
using BuscaCepApi.Repositories.Cep;

namespace BuscaCepApi.Services.Cep
{
    public class ViaCepService : IViaCepService
    {
        private readonly IViaCepRepository _viaCepRepository;
        public ViaCepService(IViaCepRepository viaCepRepository)
        {
            _viaCepRepository = viaCepRepository;
        }
        public Task<EnderecoModel> BuscarEndereco(int cep)
        {
            if (cep.ToString().Length != 0)
            {
                return null;
            }

            return _viaCepRepository.BuscarEndereco(cep);
        }
    }
}
