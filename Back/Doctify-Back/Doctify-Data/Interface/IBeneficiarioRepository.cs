using Doctify_Data.DTO.Beneficiario;
using Doctify_Data.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctify_Data.Interface
{
    public interface IBeneficiarioRepository
    {
        List<BeneficiarioDto> ListarTodos();
        BeneficiarioDto ListarPorId(int id);
        Beneficiario Criar(BeneficiarioCriarDto beneficiario);
        Beneficiario Atualizar(BeneficiarioAtualizarDto beneficiario);
        int Excluir(int Id);
    }
}
