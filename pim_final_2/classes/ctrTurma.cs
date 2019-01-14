using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim_final_2
{
    class ctrTurma
    {
        Dao_turma daoTurma;

        public ctrTurma()
        {
            daoTurma = new Dao_turma();
        }
        
        public void Adicionar(Turma T)
        {
            daoTurma.create(T);
        }
        public Turma Consultar(Turma T)
        {
            return daoTurma.read(T);
        }
        public void Excluir(Turma T)
        {
            daoTurma.delete(T);
        }
        public void Alterar(Turma T)
        {
            daoTurma.update(T);
        }
        public List<Turma> ListarTurmas()
        {
            return daoTurma.lista_turma();
        }
    }
}
