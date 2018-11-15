using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ShoeManagerBL.Service
{
    public class BaseService
    {
        private readonly IConfiguration _config;

        public BaseService(IConfiguration configuration)
        {
            this._config = configuration;
        }

        public IDbConnection connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MainConString"));
            }
        }
    }
}
