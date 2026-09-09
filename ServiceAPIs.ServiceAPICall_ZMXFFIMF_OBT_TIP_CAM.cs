namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXFFIMF_OBT_TIP_CAM</code> that represents a client request call
///  <code>Call_ZMXFFIMF_OBT_TIP_CAM</code> <p> Description: ZMXFFIMF_OBT_TIP_CAM</p>
/// </summary>
public static async Task<ST_72813e0dac5e52c872182de62adb7f2bStructure> ServiceAPICall_ZMXFFIMF_OBT_TIP_CAM(IRequestContext requestContext,ST_694abc44952847f050feca404fbee9c5Structure inParamRequest,CancellationToken cancellationToken) {
ST_72813e0dac5e52c872182de62adb7f2bStructure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXFFIMF_OBT_TIP_CAM<ST_72813e0dac5e52c872182de62adb7f2bStructure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_72813e0dac5e52c872182de62adb7f2bStructure) proxy_Response;
return outParamResponse;
}

}
