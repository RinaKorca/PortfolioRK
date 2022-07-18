using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioRK.Model
{
    public class Repository
    {
        [Key]
        public int RepositoryId { get; set; }

        public String RepoName { get; set; }

        public String RepoDescription { get; set; }

        public String Language { get; set; }
    }
}
