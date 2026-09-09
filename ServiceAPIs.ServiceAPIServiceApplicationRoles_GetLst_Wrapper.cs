namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceApplicationRoles_GetLst_Wrapper</code> that represents a client
///  request call <code>ServiceApplicationRoles_GetLst_Wrapper</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_c31de23e3d152f2b2321aea18f795545,int)> ServiceAPIServiceApplicationRoles_GetLst_Wrapper(IRequestContext requestContext,string inParamKey,string inParamAssetKey,string inParamStageKey,string inParamSearchText,string inParamSort,int inParamMaxRecords,int inParamStartIndex,CancellationToken cancellationToken) {
RL_c31de23e3d152f2b2321aea18f795545 outParamRoleslList = default;
int outParamTotalRoles = default;
RecordList proxy_RoleslList;
(proxy_RoleslList,outParamTotalRoles) = await RsseSpaceTelCelUsersManagement.ServiceApplicationRoles_GetLst_Wrapper<RL_c31de23e3d152f2b2321aea18f795545>(requestContext,inParamKey,inParamAssetKey,inParamStageKey,inParamSearchText,inParamSort,inParamMaxRecords,inParamStartIndex,cancellationToken);
outParamRoleslList = (RL_c31de23e3d152f2b2321aea18f795545) proxy_RoleslList;
return (outParamRoleslList,outParamTotalRoles);
}

}
