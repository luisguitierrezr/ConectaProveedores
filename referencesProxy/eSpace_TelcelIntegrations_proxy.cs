// Proxy for reference eSpace with name TelcelIntegrations and key +ta9dx0o+ESMvGH6G_RLNQ
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceTelcelIntegrations
/// </summary>
public partial class RsseSpaceTelcelIntegrations {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceTelcelIntegrations");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
       }
   }
public static async Task<IRecord> Call_ZTC_GENERA_POLIZA_GRAL<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_7d9ca3de97b3b074755ccb195cd9efb0Structure();
outParamResponse = new ToutParamResponse();;
ST_35778da666b987b02b8cb887e66647a4Structure _proxyoutParamResponse = new ST_35778da666b987b02b8cb887e66647a4Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZTC_GENERA_POLIZA_GRAL(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> ServicePostCarganovim<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_9b7f85dc32c7c81ceef0a0963388237dStructure();
outParamResponse = new ToutParamResponse();;
ST_6636acdf9f49922edfd43b4865475460Structure _proxyoutParamResponse = new ST_6636acdf9f49922edfd43b4865475460Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.ServicePostCarganovim(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXMIMMF_VISUALIZAR_SAL_ANT<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_f68ab54e767928bb7cc21e9801e8642bStructure();
outParamResponse = new ToutParamResponse();;
ST_cbb2055cf19f871ed882642269bd43ceStructure _proxyoutParamResponse = new ST_cbb2055cf19f871ed882642269bd43ceStructure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXMIMMF_VISUALIZAR_SAL_ANT(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure();
outParamResponse = new ToutParamResponse();;
ST_382afa1d8361f400b6ea03403d75e294Structure _proxyoutParamResponse = new ST_382afa1d8361f400b6ea03403d75e294Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXFFIMF_INSERT_UPDROV<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure();
outParamResponse = new ToutParamResponse();;
ST_b29967856499aeaa8c796dc87fe4c6e8Structure _proxyoutParamResponse = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXFFIMF_INSERT_UPDROV(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXFFIMF_OBT_TIP_CAM<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_694abc44952847f050feca404fbee9c5Structure();
outParamResponse = new ToutParamResponse();;
ST_72813e0dac5e52c872182de62adb7f2bStructure _proxyoutParamResponse = new ST_72813e0dac5e52c872182de62adb7f2bStructure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXFFIMF_OBT_TIP_CAM(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXMIMMF_EM_COSMOZ<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_6c39e0afc2ffdcac366ab8f57e83669cStructure();
outParamResponse = new ToutParamResponse();;
ST_9142fa8204e8ba0b33acb137d6acbbd3Structure _proxyoutParamResponse = new ST_9142fa8204e8ba0b33acb137d6acbbd3Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXMIMMF_EM_COSMOZ(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXMIMMF_EM_SM_CECO_COSMOZ<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_f9c1c13a018839a3b7bd285f1331e967Structure();
outParamResponse = new ToutParamResponse();;
ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure _proxyoutParamResponse = new ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXMIMMF_EM_SM_CECO_COSMOZ(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<string> Call_ZMXFFIMF_ACC_DOC_CHANGE(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) {
string outParamResponse = default;
var _proxyinParamRequest = new ST_0cb1a5ee06af693baf5508d00a19d139Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
outParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXFFIMF_ACC_DOC_CHANGE(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXMIMMF_EM_SM_MO_COSMOZ<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_0d774220c0b1db165444568fabc9b253Structure();
outParamResponse = new ToutParamResponse();;
ST_39fca1fbc45889b86a3f10d9a278767bStructure _proxyoutParamResponse = new ST_39fca1fbc45889b86a3f10d9a278767bStructure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXMIMMF_EM_SM_MO_COSMOZ(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Service_EM<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_471afc38d91cd307b39846c7ca5ddb86Structure();
outParamResponse = new ToutParamResponse();;
ST_ff65d449d860eb4ed98725735a32f4f3Structure _proxyoutParamResponse = new ST_ff65d449d860eb4ed98725735a32f4f3Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Service_EM(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXMIMMF_EM_SM_RM_COSMOZ<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_e629b825a45e94758f239d11120cb772Structure();
outParamResponse = new ToutParamResponse();;
ST_b413183d4662c427b8a9318270b9732cStructure _proxyoutParamResponse = new ST_b413183d4662c427b8a9318270b9732cStructure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXMIMMF_EM_SM_RM_COSMOZ(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXFFIMF_0250_FI_CREATE_RELAT<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_b9515582922fdbd4d217706a5c5c0f3fStructure();
outParamResponse = new ToutParamResponse();;
ST_31a464e509d55210f80b735594283423Structure _proxyoutParamResponse = new ST_31a464e509d55210f80b735594283423Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXFFIMF_0250_FI_CREATE_RELAT(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Service_EM_SM_CECO<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_abeb699a3b96359819e408d199643162Structure();
outParamResponse = new ToutParamResponse();;
ST_92e975006ec90075480e9af34dc228e3Structure _proxyoutParamResponse = new ST_92e975006ec90075480e9af34dc228e3Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Service_EM_SM_CECO(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXMIMMF_GENERA_PEDIDO_PDF<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_7ddccdeb65a44283541a52358876da04Structure();
outParamResponse = new ToutParamResponse();;
ST_bc70ab3695876bb4315a9088f41998b7Structure _proxyoutParamResponse = new ST_bc70ab3695876bb4315a9088f41998b7Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXMIMMF_GENERA_PEDIDO_PDF(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Service_EM_SM_RM<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_c338780fd6468541199340ed93f1aecdStructure();
outParamResponse = new ToutParamResponse();;
ST_b3b2573902c6e22d9647e405d3baf728Structure _proxyoutParamResponse = new ST_b3b2573902c6e22d9647e405d3baf728Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Service_EM_SM_RM(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXFFIMF_CONTA_FACTURAS<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_012aef00497ef6b298e25799608b1289Structure();
outParamResponse = new ToutParamResponse();;
ST_926df962559a6c34055113c885aa4885Structure _proxyoutParamResponse = new ST_926df962559a6c34055113c885aa4885Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXFFIMF_CONTA_FACTURAS(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_Z01_READ_TEXT<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_c4a97e6963b2cd0d749b56dde8d26a02Structure();
outParamResponse = new ToutParamResponse();;
ST_cc99e347274d861473c4d7d08b6332b6Structure _proxyoutParamResponse = new ST_cc99e347274d861473c4d7d08b6332b6Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_Z01_READ_TEXT(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_ZMXFAPMF_CONSUL_RETENPROV<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure();
outParamResponse = new ToutParamResponse();;
ST_24353ddcec93ac51b13ce9ab94fe4001Structure _proxyoutParamResponse = new ST_24353ddcec93ac51b13ce9ab94fe4001Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_ZMXFAPMF_CONSUL_RETENPROV(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Call_BAPI_GL_ACC_GETDETAIL<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_442654d6c8649545cfc0a9d6bfc9f12cStructure();
outParamResponse = new ToutParamResponse();;
ST_0f0d90fe4adeeddf082edffc80174eb8Structure _proxyoutParamResponse = new ST_0f0d90fe4adeeddf082edffc80174eb8Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Call_BAPI_GL_ACC_GETDETAIL(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> ServicePostValidacfdiprov<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_1e5384bdcb5c8be6badd45c0e821aec6Structure();
outParamResponse = new ToutParamResponse();;
ST_13caff817360521524d01995a65282cdStructure _proxyoutParamResponse = new ST_13caff817360521524d01995a65282cdStructure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.ServicePostValidacfdiprov(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}


public static async Task<IRecord> Service_EM_SM_MO<ToutParamResponse>(IRequestContext requestContext,IRecord inParamRequest,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() {
IRecord outParamResponse = default;
var _proxyinParamRequest = new ST_f61ad0d448ed247a1bde22a5051a7d04Structure();
outParamResponse = new ToutParamResponse();;
ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure _proxyoutParamResponse = new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure();
_proxyinParamRequest.FillFromOther(inParamRequest);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab");
_proxyoutParamResponse = await TelcelIntegrationsServiceAPIClients.Service_EM_SM_MO(requestContext,_proxyinParamRequest,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return outParamResponse;
}



public class DefaultValues {
}
}
}
