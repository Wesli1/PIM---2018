using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pim_final_2
{
    class ctrAluno
    {
        Dao_Aluno dao_aluno;

        public ctrAluno()
        {
            dao_aluno = new Dao_Aluno();
        }

        public void Adicionar(Aluno A) //create
        {
            dao_aluno.create(A);
        }
        public Aluno Consultar(Aluno A)
        {
            return dao_aluno.read(A);
        }
        public void Excluir(Aluno A)//d
        {
            dao_aluno.delete(A);
        }
        public void Alterar(Aluno A)//u
        {
            dao_aluno.update(A);
        }
        public List<Aluno> ListarAlunos() 
        {
            return dao_aluno.lista_aluno();
        }
        public List<Aluno> ListarAlunosTurmas(Aluno A)
        {
            return dao_aluno.lista_aluno_turma(A);
        }
       
    }
}
