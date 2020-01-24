using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFP_05_12.Models.Services
{
    public class ProdutoService
    {
        private readonly ProdutosContext _context;
        
        public ProdutoService (ProdutosContext context)
        {
            _context = context;
        }
       
        public List<Produto> FindAll()
        {
            return _context.Produto.ToList();
            
        }
            
        
    }
}
