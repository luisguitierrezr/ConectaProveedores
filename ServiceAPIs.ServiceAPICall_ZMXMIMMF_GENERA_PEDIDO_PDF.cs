namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXMIMMF_GENERA_PEDIDO_PDF</code> that represents a client request
///  call <code>Call_ZMXMIMMF_GENERA_PEDIDO_PDF</code> <p> Description: Generación del documento de
/// l pedido en PDF</p>
/// </summary>
public static async Task<ST_bc70ab3695876bb4315a9088f41998b7Structure> ServiceAPICall_ZMXMIMMF_GENERA_PEDIDO_PDF(IRequestContext requestContext,ST_7ddccdeb65a44283541a52358876da04Structure inParamRequest,CancellationToken cancellationToken) {
ST_bc70ab3695876bb4315a9088f41998b7Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXMIMMF_GENERA_PEDIDO_PDF<ST_bc70ab3695876bb4315a9088f41998b7Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_bc70ab3695876bb4315a9088f41998b7Structure) proxy_Response;
return outParamResponse;
}

}
