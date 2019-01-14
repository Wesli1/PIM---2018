using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim_final_2
{
    class ctrResponsavel
    {
        DAO_Responsavel dao_resp;

        public ctrResponsavel()
        {
            dao_resp = new DAO_Responsavel();
        }
        public void Adicionar(Responsavel R)
        {
            dao_resp.create(R);
        }
        public Responsavel Consultar(Responsavel R)
        {
            return dao_resp.read(R);
        }
        public void Excluir(Responsavel R)
        {
            dao_resp.delete(R);
        }
        public void Alterar(Responsavel R)
        {            
            dao_resp.update(R);
            

        }
        public List<Responsavel> ListarResponsaveis()
        {
            return dao_resp.lista_responsaveis();
        }
    }
}
