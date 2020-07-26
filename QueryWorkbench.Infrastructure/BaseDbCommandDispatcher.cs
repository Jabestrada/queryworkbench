﻿using System.CodeDom;
using System.Collections.Generic;
using System.Data;

namespace QueryWorkbench.Infrastructure {
    public abstract class BaseCommandDispatcher : IDbCommandDispatcher {
        public string ConnectionString { get; set; }
        public Dictionary<string, object> Parameters { get; set; }

        public BaseCommandDispatcher(string connectionString, Dictionary<string, object> parameters) {
            ConnectionString = connectionString;
            Parameters = parameters;
        }
        public abstract DataSet RunQuery(string query);
    }
}
