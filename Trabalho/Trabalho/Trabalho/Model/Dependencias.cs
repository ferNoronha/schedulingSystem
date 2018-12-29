using ProjAgendamento.Repository;
using ProjDesignPattern.Repository.MySqlRepository;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using System.Data;
using Trabalho.Repository;
using Trabalho.Repository.Interface;
using Trabalho.View;

namespace Trabalho.Model
{
    public class Dependencias
    {
        public static Container Container { get; set; } = new Container();

        static Dependencias()
        {
            Dependencias.Container.Options.DefaultLifestyle = Lifestyle.Transient;
            Dependencias.Container.Options.DefaultScopedLifestyle = new ThreadScopedLifestyle();
        }

        public static void Configurar()
        {
            //Container.Register(typeof(IDbConnection), Connection.GetConnection, Lifestyle.Scoped);
            Container.Register<IDbConnection>(Connection.GetConnection, Lifestyle.Scoped);
            Container.Register<IAgendamentoExameRepository, MySqlAgendamentoExameRepository>(Lifestyle.Scoped);
            Container.Register<IAgendamentoRepository, MySqlAgendamentoRepository>(Lifestyle.Scoped);
            Container.Register<FrmCadastroAgendamento>();
            Container.Register<ICidadeRepository, MySqlCidadeRepository>(Lifestyle.Scoped);
            Container.Register<FrmCadastroCidade>();
            Container.Register<IConvenioRepository, MySqlConvenioRepository>(Lifestyle.Scoped);
            Container.Register<FrmCadastroConvenio>();
            //Container.Register<FrmCadAgendamentoExame>();
            Container.Register<IExameRepository, MySqlExameRepository>(Lifestyle.Scoped);
            Container.Register<FrmCadastroExame>();
            Container.Register<IMedicoConvenioRepository, MySqlMedicoConvenioRepository>(Lifestyle.Scoped);
            //Container.Register<FrmCadastroConvenio>();
            Container.Register<IMedicoHorarioRepository, MySqlMedicoHorarioRepository>(Lifestyle.Scoped);
            //Container.Register<FrmCadAgendamentoExame>();
            Container.Register<IMedicoRepository, MySqlMedicoRepository>(Lifestyle.Scoped);
            Container.Register<FrmCadastroMedico>();
            Container.Register<IPacienteRepository, MySqlPacienteRepository>(Lifestyle.Scoped);
            Container.Register<FrmCadastroPaciente>();
            //Container.Verify();
        }
    }
}
