using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudSqlServerDapper.Entitites
{
    /// <summary>
    /// Modelo de dados para entidade Cliente
    /// </summary>
    public class Client
    {
        #region properties
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }


         #endregion
     }
}
