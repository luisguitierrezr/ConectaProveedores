namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceGetAuditsByOrigin4List</code> that represents a client request
///  call <code>ServiceGetAuditsByOrigin4List</code> <p> Description: Service Get Audits By Origin 
/// 4 List</p>
/// </summary>
public static async Task<(RL_d271bd6e591b75c186c4ae8d222dee55,long)> ServiceAPIServiceGetAuditsByOrigin4List(IRequestContext requestContext,int inParamOriginId,DateTime inParamPeriodInit,DateTime inParamPeriodEnd,bool inParamShowErrors,int inParamStartIndex,int inParamMaxRecords,string inParamTableSort,CancellationToken cancellationToken) {
RL_d271bd6e591b75c186c4ae8d222dee55 outParamAuditList = default;
long outParamTotalCount = default;
RecordList proxy_AuditList;
(proxy_AuditList,outParamTotalCount) = await RsseSpaceAuditEngine.ServiceGetAuditsByOrigin4List<RL_d271bd6e591b75c186c4ae8d222dee55>(requestContext,inParamOriginId,inParamPeriodInit,inParamPeriodEnd,inParamShowErrors,inParamStartIndex,inParamMaxRecords,inParamTableSort,cancellationToken);
outParamAuditList = (RL_d271bd6e591b75c186c4ae8d222dee55) proxy_AuditList;
return (outParamAuditList,outParamTotalCount);
}

}
