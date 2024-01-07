using WebNotas.Data;
using WebNotas.Models;

namespace WebNotas.Repository
{
    public class NotasRepository : INotasRepository
    {
        private readonly AplicationContext _aplicationDbContext;


        public NotasRepository(AplicationContext aplicationContext)
        {
            _aplicationDbContext = aplicationContext;
        }

        public NF CriarNF(NF nota)
        {
            _aplicationDbContext.Notas.Add(nota);
            _aplicationDbContext.SaveChanges();
            return nota;
        }

        public List<NF> ListarTodasNF()
        {
            return _aplicationDbContext.Notas.ToList();

        }

        public NF ListarPorNumero(int numero)
        {
            return _aplicationDbContext.Notas.FirstOrDefault(x => x.NumeroNf == numero);
        }
            
        public NF Atualizar(NF nota)
        {
            NF notadb = ListarPorNumero(nota.NumeroNf);
            if (notadb == null) throw new System.Exception("Não foi encontrado Nota Fiscal com este numero");

            notadb.NumeroNf = nota.NumeroNf;
            notadb.ValorTotal = nota.ValorTotal;
            notadb.DataNf = nota.DataNf;
            notadb.CnpjEmissorNf = nota.CnpjEmissorNf;
            notadb.CnpjDestinatarioNf = nota.CnpjDestinatarioNf;

            _aplicationDbContext.Notas.Update(notadb);
            _aplicationDbContext.SaveChanges();
            return notadb;


          
        }

        public bool Deletar(int num)
        {
            NF notadb = ListarPorNumero(num);
            if (notadb == null) throw new System.Exception("Não foi encontrado Nota Fiscal com este numero");
            _aplicationDbContext.Notas.Remove(notadb);
            _aplicationDbContext.SaveChanges();
            return true;


        }
    }
}
