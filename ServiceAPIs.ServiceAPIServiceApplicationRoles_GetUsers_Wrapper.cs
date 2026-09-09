namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceApplicationRoles_GetUsers_Wrapper</code> that represents a client
///  request call <code>ServiceApplicationRoles_GetUsers_Wrapper</code> <p> Description: </p>
/// </summary>
public static async Task<RL_c22ca0e0dff4c8c0d1575277d6d892be> ServiceAPIServiceApplicationRoles_GetUsers_Wrapper(IRequestContext requestContext,string inParamKey,int inParamLimit,int inParamOffset,CancellationToken cancellationToken) {
RL_c22ca0e0dff4c8c0d1575277d6d892be outParamUsersList = default;
RecordList proxy_UsersList;
proxy_UsersList = await RsseSpaceTelCelUsersManagement.ServiceApplicationRoles_GetUsers_Wrapper<RL_c22ca0e0dff4c8c0d1575277d6d892be>(requestContext,inParamKey,inParamLimit,inParamOffset,cancellationToken);
outParamUsersList = (RL_c22ca0e0dff4c8c0d1575277d6d892be) proxy_UsersList;
return outParamUsersList;
}

}
