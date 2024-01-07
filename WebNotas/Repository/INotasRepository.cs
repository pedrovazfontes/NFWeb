using WebNotas.Models;


namespace WebNotas.Repository
{
    public interface INotasRepository
    {
        NF CriarNF(NF nota);
        List<NF> ListarTodasNF();
        NF ListarPorNumero(int numero); 
        NF Atualizar(NF nota);

        bool Deletar(int numero);
    }
}
