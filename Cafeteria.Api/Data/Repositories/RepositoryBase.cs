﻿using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria.Api.Data.Repositories
{
    public class RepositoryBase
    {
        protected IConfiguration configuration; //acessar parâmetros de outras classes

        internal IDbConnection Connection
        {
            get
            {
                var connect = new NpgsqlConnection(configuration["ConnectionString"]); //npgsqlConnection para instânciar uma coneção com banco

                connect.Open(); //para abrir a coneção
                return connect;
            }
        }
    }
}
