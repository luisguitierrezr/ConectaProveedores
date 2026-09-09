using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OutSystems.Application.Abstractions;
using OutSystems.Application.Initialization.ASPNetCore;
using OutSystems.Application.Timers;

namespace ssConectaProveedores {
    public class Startup : StartupBaseApp {
        public Startup(IConfiguration configuration) : base(configuration, AppUtils.Instance, AppUtils.StaticProperties.Instance) {
        }

        public override IServiceCollection ConfigureApplicationServices(IServiceCollection services) {
            ConfigureTimers(services);
            ConfigureSemanticSearchExecutors(services);
            ConfigureAgentTools(services);
            ConfigureEntityConstantsGetter(services);

            return services;
        }

        private IServiceCollection ConfigureEntityConstantsGetter(IServiceCollection services) {
            services.AddSingleton<IEntityConstantsGetter, EntityConstantsGetter>();
            return services;
        }

        private IServiceCollection ConfigureAgentTools(IServiceCollection services) {
            
            return services;
        }

        private IServiceCollection ConfigureTimers(IServiceCollection services) {
                        services.AddSingleton<TimerTimerExpireDataCaptureRequisitions>();
            services.AddSingleton<TimerTimerNotifyAlmacenRejectedFolios>();
            services.AddSingleton<TimerTimerSendDailyWorkNotificationEmail>();
            services.AddSingleton<TimerTimerCloseBeingPaidProposals>();
            services.AddSingleton<TimerHotfixFoliosRemove1FromCurrentLevel>();
            services.AddSingleton<TimerTimerProcessBlockedEntries>();
            services.AddSingleton<TimerTimerProcessFileIntoProposal>();
            services.AddSingleton<TimerHotfixRequisitionsToFillTelcelDirectionId>();
            services.AddSingleton<TimerTimerLastApproverGerenteJefeOrdersFill>();
            services.AddSingleton<TimerTimerSendNotificationApprover>();
            services.AddSingleton<TimerTimerCreatePolizaDocumentRelation>();
            services.AddSingleton<TimerTimerSendNotificationTreasury>();
            services.AddSingleton<TimerTimerOrdersDistribution_SendEmails>();
            services.AddSingleton<TimerTimerPurgeAccountingLogs>();
            services.AddSingleton<ITimerService>(provider => {
                var timers = new Dictionary<string, ITimerExecutor>();
                timers.Add("123989b9-ca47-46bc-9c9c-40ebe9af69ea", provider.GetService<TimerTimerExpireDataCaptureRequisitions>());
                timers.Add("379c0cdd-dc6c-4df3-a975-100a262435a5", provider.GetService<TimerTimerNotifyAlmacenRejectedFolios>());
                timers.Add("384e5b04-edad-4328-85ef-57cadaab04ca", provider.GetService<TimerTimerSendDailyWorkNotificationEmail>());
                timers.Add("400a6bcd-d4cc-44ce-83a5-44daa159e4b7", provider.GetService<TimerTimerCloseBeingPaidProposals>());
                timers.Add("50575694-e94a-4d16-b3fe-04077f96f1ed", provider.GetService<TimerHotfixFoliosRemove1FromCurrentLevel>());
                timers.Add("55b5a328-2c1f-41df-949c-4e09687ec6a1", provider.GetService<TimerTimerProcessBlockedEntries>());
                timers.Add("65b8f88c-4e6e-4e97-8f4c-2351549e1558", provider.GetService<TimerTimerProcessFileIntoProposal>());
                timers.Add("6b89ec35-1fe7-4a00-9b98-cf08c59b0d7b", provider.GetService<TimerHotfixRequisitionsToFillTelcelDirectionId>());
                timers.Add("8b37f6e4-4ab3-498d-a824-171470257c16", provider.GetService<TimerTimerLastApproverGerenteJefeOrdersFill>());
                timers.Add("8c94b468-48ef-4d8f-b5b5-03cb57e498e8", provider.GetService<TimerTimerSendNotificationApprover>());
                timers.Add("9101b317-4716-4e6d-8386-5cb66a61255e", provider.GetService<TimerTimerCreatePolizaDocumentRelation>());
                timers.Add("9e11d749-7552-4163-a7ba-2fe6c5008099", provider.GetService<TimerTimerSendNotificationTreasury>());
                timers.Add("b535a064-9310-46bd-945d-671fd8bd6abc", provider.GetService<TimerTimerOrdersDistribution_SendEmails>());
                timers.Add("b953d068-6f7b-4d22-8a54-51c795f41068", provider.GetService<TimerTimerPurgeAccountingLogs>());

                return new TimerService(timers);
            });

            return services;
        }

        private IServiceCollection ConfigureSemanticSearchExecutors(IServiceCollection services) {
            
            return services;
        }
    }
}