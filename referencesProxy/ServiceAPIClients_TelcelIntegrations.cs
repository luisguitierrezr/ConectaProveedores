using System.Collections.ObjectModel;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions;

using ssConectaProveedores.ReferencesProxy;

namespace ssConectaProveedores {
    public partial class RsseSpaceTelcelIntegrations {
        public class TelcelIntegrationsServiceAPIClients : AbstractServiceApiClient {
            private static readonly TelcelIntegrationsServiceAPIClients Instance = new();
            private TelcelIntegrationsServiceAPIClients() : base(
                ObjectKey.Parse("bc36685b-619d-4cb6-8167-fa43e0baacab"),
                "TelcelIntegrations",
                "ssConectaProveedores.TelcelIntegrationsServiceAPIClients",
                ReadOnlyDictionary<string, Func<string, Exception>>.Empty
            ) { }

            public class S4PICall_ZTC_GENERA_POLIZA_GRALInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9ca3de97b3b074755ccb195cd9efb0Structure inParamRequest;
public S4PICall_ZTC_GENERA_POLIZA_GRALInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9ca3de97b3b074755ccb195cd9efb0Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZTC_GENERA_POLIZA_GRALOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure outParamResponse;
public S4PICall_ZTC_GENERA_POLIZA_GRALOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZTC_GENERA_POLIZA_GRAL
/// </summary>
public static async Task<ST_35778da666b987b02b8cb887e66647a4Structure> Call_ZTC_GENERA_POLIZA_GRAL(IRequestContext requestContext,ST_7d9ca3de97b3b074755ccb195cd9efb0Structure inParamRequest,CancellationToken cancellationToken) {
ST_35778da666b987b02b8cb887e66647a4Structure outParamResponse = default;
outParamResponse = new ST_35778da666b987b02b8cb887e66647a4Structure();

var serviceActionName = "Call_ZTC_GENERA_POLIZA_GRAL";
var serviceActionKey = "110f04e1-735f-431f-9071-872d816d43f7";
var inputs = new S4PICall_ZTC_GENERA_POLIZA_GRALInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7d9ca3de97b3b074755ccb195cd9efb0Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZTC_GENERA_POLIZA_GRALInput, S4PICall_ZTC_GENERA_POLIZA_GRALOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_35778da666b987b02b8cb887e66647a4Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PIServicePostCarganovimInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure inParamRequest;
public S4PIServicePostCarganovimInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PIServicePostCarganovimOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure outParamResponse;
public S4PIServicePostCarganovimOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServicePostCarganovim
/// </summary>
public static async Task<ST_6636acdf9f49922edfd43b4865475460Structure> ServicePostCarganovim(IRequestContext requestContext,ST_9b7f85dc32c7c81ceef0a0963388237dStructure inParamRequest,CancellationToken cancellationToken) {
ST_6636acdf9f49922edfd43b4865475460Structure outParamResponse = default;
outParamResponse = new ST_6636acdf9f49922edfd43b4865475460Structure();

var serviceActionName = "ServicePostCarganovim";
var serviceActionKey = "2501d5ee-4f23-4a92-9bc2-b0a8c0ed0d19";
var inputs = new S4PIServicePostCarganovimInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9b7f85dc32c7c81ceef0a0963388237dStructure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServicePostCarganovimInput, S4PIServicePostCarganovimOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6636acdf9f49922edfd43b4865475460Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXMIMMF_VISUALIZAR_SAL_ANTInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure inParamRequest;
public S4PICall_ZMXMIMMF_VISUALIZAR_SAL_ANTInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXMIMMF_VISUALIZAR_SAL_ANTOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cbb2055cf19f871ed882642269bd43ceStructure outParamResponse;
public S4PICall_ZMXMIMMF_VISUALIZAR_SAL_ANTOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cbb2055cf19f871ed882642269bd43ceStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXMIMMF_VISUALIZAR_SAL_ANT
/// </summary>
public static async Task<ST_cbb2055cf19f871ed882642269bd43ceStructure> Call_ZMXMIMMF_VISUALIZAR_SAL_ANT(IRequestContext requestContext,ST_f68ab54e767928bb7cc21e9801e8642bStructure inParamRequest,CancellationToken cancellationToken) {
ST_cbb2055cf19f871ed882642269bd43ceStructure outParamResponse = default;
outParamResponse = new ST_cbb2055cf19f871ed882642269bd43ceStructure();

var serviceActionName = "Call_ZMXMIMMF_VISUALIZAR_SAL_ANT";
var serviceActionKey = "3ddfdea5-768c-486e-a98b-cbbf222cff8a";
var inputs = new S4PICall_ZMXMIMMF_VISUALIZAR_SAL_ANTInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f68ab54e767928bb7cc21e9801e8642bStructure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXMIMMF_VISUALIZAR_SAL_ANTInput, S4PICall_ZMXMIMMF_VISUALIZAR_SAL_ANTOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cbb2055cf19f871ed882642269bd43ceStructure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXMIMMF_ESTD_CUENTA_COSMOZInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure inParamRequest;
public S4PICall_ZMXMIMMF_ESTD_CUENTA_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXMIMMF_ESTD_CUENTA_COSMOZOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure outParamResponse;
public S4PICall_ZMXMIMMF_ESTD_CUENTA_COSMOZOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ
/// </summary>
public static async Task<ST_382afa1d8361f400b6ea03403d75e294Structure> Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ(IRequestContext requestContext,ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure inParamRequest,CancellationToken cancellationToken) {
ST_382afa1d8361f400b6ea03403d75e294Structure outParamResponse = default;
outParamResponse = new ST_382afa1d8361f400b6ea03403d75e294Structure();

var serviceActionName = "Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ";
var serviceActionKey = "46b9bbbc-a2f0-46ab-b74c-dd4334c67a32";
var inputs = new S4PICall_ZMXMIMMF_ESTD_CUENTA_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXMIMMF_ESTD_CUENTA_COSMOZInput, S4PICall_ZMXMIMMF_ESTD_CUENTA_COSMOZOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_382afa1d8361f400b6ea03403d75e294Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXFFIMF_INSERT_UPDROVInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure inParamRequest;
public S4PICall_ZMXFFIMF_INSERT_UPDROVInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXFFIMF_INSERT_UPDROVOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b29967856499aeaa8c796dc87fe4c6e8Structure outParamResponse;
public S4PICall_ZMXFFIMF_INSERT_UPDROVOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b29967856499aeaa8c796dc87fe4c6e8Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXFFIMF_INSERT_UPDROV
/// </summary>
public static async Task<ST_b29967856499aeaa8c796dc87fe4c6e8Structure> Call_ZMXFFIMF_INSERT_UPDROV(IRequestContext requestContext,ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure inParamRequest,CancellationToken cancellationToken) {
ST_b29967856499aeaa8c796dc87fe4c6e8Structure outParamResponse = default;
outParamResponse = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();

var serviceActionName = "Call_ZMXFFIMF_INSERT_UPDROV";
var serviceActionKey = "5048470a-85ad-4ff2-90df-e1ceda941f75";
var inputs = new S4PICall_ZMXFFIMF_INSERT_UPDROVInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_90ad61a7b6c3b8dc6db7b1d64798236bStructure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXFFIMF_INSERT_UPDROVInput, S4PICall_ZMXFFIMF_INSERT_UPDROVOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b29967856499aeaa8c796dc87fe4c6e8Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXFFIMF_OBT_TIP_CAMInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_694abc44952847f050feca404fbee9c5Structure inParamRequest;
public S4PICall_ZMXFFIMF_OBT_TIP_CAMInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_694abc44952847f050feca404fbee9c5Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXFFIMF_OBT_TIP_CAMOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure outParamResponse;
public S4PICall_ZMXFFIMF_OBT_TIP_CAMOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXFFIMF_OBT_TIP_CAM
/// </summary>
public static async Task<ST_72813e0dac5e52c872182de62adb7f2bStructure> Call_ZMXFFIMF_OBT_TIP_CAM(IRequestContext requestContext,ST_694abc44952847f050feca404fbee9c5Structure inParamRequest,CancellationToken cancellationToken) {
ST_72813e0dac5e52c872182de62adb7f2bStructure outParamResponse = default;
outParamResponse = new ST_72813e0dac5e52c872182de62adb7f2bStructure();

var serviceActionName = "Call_ZMXFFIMF_OBT_TIP_CAM";
var serviceActionKey = "550f0963-98bd-441d-9b2f-fcbb53a41858";
var inputs = new S4PICall_ZMXFFIMF_OBT_TIP_CAMInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_694abc44952847f050feca404fbee9c5Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXFFIMF_OBT_TIP_CAMInput, S4PICall_ZMXFFIMF_OBT_TIP_CAMOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXMIMMF_EM_COSMOZInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure inParamRequest;
public S4PICall_ZMXMIMMF_EM_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXMIMMF_EM_COSMOZOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure outParamResponse;
public S4PICall_ZMXMIMMF_EM_COSMOZOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXMIMMF_EM_COSMOZ
/// </summary>
public static async Task<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure> Call_ZMXMIMMF_EM_COSMOZ(IRequestContext requestContext,ST_6c39e0afc2ffdcac366ab8f57e83669cStructure inParamRequest,CancellationToken cancellationToken) {
ST_9142fa8204e8ba0b33acb137d6acbbd3Structure outParamResponse = default;
outParamResponse = new ST_9142fa8204e8ba0b33acb137d6acbbd3Structure();

var serviceActionName = "Call_ZMXMIMMF_EM_COSMOZ";
var serviceActionKey = "57b370ab-caee-4468-95ed-c02c695b107d";
var inputs = new S4PICall_ZMXMIMMF_EM_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXMIMMF_EM_COSMOZInput, S4PICall_ZMXMIMMF_EM_COSMOZOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9142fa8204e8ba0b33acb137d6acbbd3Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXMIMMF_EM_SM_CECO_COSMOZInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure inParamRequest;
public S4PICall_ZMXMIMMF_EM_SM_CECO_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXMIMMF_EM_SM_CECO_COSMOZOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure outParamResponse;
public S4PICall_ZMXMIMMF_EM_SM_CECO_COSMOZOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXMIMMF_EM_SM_CECO_COSMOZ
/// </summary>
public static async Task<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> Call_ZMXMIMMF_EM_SM_CECO_COSMOZ(IRequestContext requestContext,ST_f9c1c13a018839a3b7bd285f1331e967Structure inParamRequest,CancellationToken cancellationToken) {
ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure outParamResponse = default;
outParamResponse = new ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure();

var serviceActionName = "Call_ZMXMIMMF_EM_SM_CECO_COSMOZ";
var serviceActionKey = "5b6c972f-a603-44b7-80de-72d7d96e7370";
var inputs = new S4PICall_ZMXMIMMF_EM_SM_CECO_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXMIMMF_EM_SM_CECO_COSMOZInput, S4PICall_ZMXMIMMF_EM_SM_CECO_COSMOZOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ecd8bf4dc0f110548ef2317e70fd4c61Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXFFIMF_ACC_DOC_CHANGEInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure inParamRequest;
public S4PICall_ZMXFFIMF_ACC_DOC_CHANGEInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXFFIMF_ACC_DOC_CHANGEOutput {
[JsonProperty("Response")]
public string outParamResponse;
public S4PICall_ZMXFFIMF_ACC_DOC_CHANGEOutput(string outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXFFIMF_ACC_DOC_CHANGE
/// </summary>
public static async Task<string> Call_ZMXFFIMF_ACC_DOC_CHANGE(IRequestContext requestContext,ST_0cb1a5ee06af693baf5508d00a19d139Structure inParamRequest,CancellationToken cancellationToken) {
string outParamResponse = default;
outParamResponse = "";

var serviceActionName = "Call_ZMXFFIMF_ACC_DOC_CHANGE";
var serviceActionKey = "64e86eb1-b3bf-4772-b036-ad489e0a2afa";
var inputs = new S4PICall_ZMXFFIMF_ACC_DOC_CHANGEInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0cb1a5ee06af693baf5508d00a19d139Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXFFIMF_ACC_DOC_CHANGEInput, S4PICall_ZMXFFIMF_ACC_DOC_CHANGEOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = outputs.outParamResponse;
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXMIMMF_EM_SM_MO_COSMOZInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure inParamRequest;
public S4PICall_ZMXMIMMF_EM_SM_MO_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXMIMMF_EM_SM_MO_COSMOZOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure outParamResponse;
public S4PICall_ZMXMIMMF_EM_SM_MO_COSMOZOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXMIMMF_EM_SM_MO_COSMOZ
/// </summary>
public static async Task<ST_39fca1fbc45889b86a3f10d9a278767bStructure> Call_ZMXMIMMF_EM_SM_MO_COSMOZ(IRequestContext requestContext,ST_0d774220c0b1db165444568fabc9b253Structure inParamRequest,CancellationToken cancellationToken) {
ST_39fca1fbc45889b86a3f10d9a278767bStructure outParamResponse = default;
outParamResponse = new ST_39fca1fbc45889b86a3f10d9a278767bStructure();

var serviceActionName = "Call_ZMXMIMMF_EM_SM_MO_COSMOZ";
var serviceActionKey = "85420ff2-3edb-4a18-baf9-e77f372cc0f3";
var inputs = new S4PICall_ZMXMIMMF_EM_SM_MO_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXMIMMF_EM_SM_MO_COSMOZInput, S4PICall_ZMXMIMMF_EM_SM_MO_COSMOZOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_39fca1fbc45889b86a3f10d9a278767bStructure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PIService_EMInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure inParamRequest;
public S4PIService_EMInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PIService_EMOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ff65d449d860eb4ed98725735a32f4f3Structure outParamResponse;
public S4PIService_EMOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ff65d449d860eb4ed98725735a32f4f3Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Service_EM
/// </summary>
public static async Task<ST_ff65d449d860eb4ed98725735a32f4f3Structure> Service_EM(IRequestContext requestContext,ST_471afc38d91cd307b39846c7ca5ddb86Structure inParamRequest,CancellationToken cancellationToken) {
ST_ff65d449d860eb4ed98725735a32f4f3Structure outParamResponse = default;
outParamResponse = new ST_ff65d449d860eb4ed98725735a32f4f3Structure();

var serviceActionName = "Service_EM";
var serviceActionKey = "86bcc8b7-1853-4c22-a214-c1943ead71c9";
var inputs = new S4PIService_EMInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_471afc38d91cd307b39846c7ca5ddb86Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIService_EMInput, S4PIService_EMOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ff65d449d860eb4ed98725735a32f4f3Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXMIMMF_EM_SM_RM_COSMOZInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure inParamRequest;
public S4PICall_ZMXMIMMF_EM_SM_RM_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXMIMMF_EM_SM_RM_COSMOZOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure outParamResponse;
public S4PICall_ZMXMIMMF_EM_SM_RM_COSMOZOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXMIMMF_EM_SM_RM_COSMOZ
/// </summary>
public static async Task<ST_b413183d4662c427b8a9318270b9732cStructure> Call_ZMXMIMMF_EM_SM_RM_COSMOZ(IRequestContext requestContext,ST_e629b825a45e94758f239d11120cb772Structure inParamRequest,CancellationToken cancellationToken) {
ST_b413183d4662c427b8a9318270b9732cStructure outParamResponse = default;
outParamResponse = new ST_b413183d4662c427b8a9318270b9732cStructure();

var serviceActionName = "Call_ZMXMIMMF_EM_SM_RM_COSMOZ";
var serviceActionKey = "898082a8-1e49-4a00-ba92-7a69a96fd414";
var inputs = new S4PICall_ZMXMIMMF_EM_SM_RM_COSMOZInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e629b825a45e94758f239d11120cb772Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXMIMMF_EM_SM_RM_COSMOZInput, S4PICall_ZMXMIMMF_EM_SM_RM_COSMOZOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b413183d4662c427b8a9318270b9732cStructure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXFFIMF_0250_FI_CREATE_RELATInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b9515582922fdbd4d217706a5c5c0f3fStructure inParamRequest;
public S4PICall_ZMXFFIMF_0250_FI_CREATE_RELATInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b9515582922fdbd4d217706a5c5c0f3fStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXFFIMF_0250_FI_CREATE_RELATOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure outParamResponse;
public S4PICall_ZMXFFIMF_0250_FI_CREATE_RELATOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXFFIMF_0250_FI_CREATE_RELAT
/// </summary>
public static async Task<ST_31a464e509d55210f80b735594283423Structure> Call_ZMXFFIMF_0250_FI_CREATE_RELAT(IRequestContext requestContext,ST_b9515582922fdbd4d217706a5c5c0f3fStructure inParamRequest,CancellationToken cancellationToken) {
ST_31a464e509d55210f80b735594283423Structure outParamResponse = default;
outParamResponse = new ST_31a464e509d55210f80b735594283423Structure();

var serviceActionName = "Call_ZMXFFIMF_0250_FI_CREATE_RELAT";
var serviceActionKey = "8cdf6ba2-03bc-4078-ac4f-48e1df7b4cc9";
var inputs = new S4PICall_ZMXFFIMF_0250_FI_CREATE_RELATInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b9515582922fdbd4d217706a5c5c0f3fStructure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXFFIMF_0250_FI_CREATE_RELATInput, S4PICall_ZMXFFIMF_0250_FI_CREATE_RELATOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_31a464e509d55210f80b735594283423Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PIService_EM_SM_CECOInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure inParamRequest;
public S4PIService_EM_SM_CECOInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PIService_EM_SM_CECOOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure outParamResponse;
public S4PIService_EM_SM_CECOOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Service_EM_SM_CECO
/// </summary>
public static async Task<ST_92e975006ec90075480e9af34dc228e3Structure> Service_EM_SM_CECO(IRequestContext requestContext,ST_abeb699a3b96359819e408d199643162Structure inParamRequest,CancellationToken cancellationToken) {
ST_92e975006ec90075480e9af34dc228e3Structure outParamResponse = default;
outParamResponse = new ST_92e975006ec90075480e9af34dc228e3Structure();

var serviceActionName = "Service_EM_SM_CECO";
var serviceActionKey = "93e1083c-7fa0-4375-8339-98191759b14a";
var inputs = new S4PIService_EM_SM_CECOInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_abeb699a3b96359819e408d199643162Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIService_EM_SM_CECOInput, S4PIService_EM_SM_CECOOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_92e975006ec90075480e9af34dc228e3Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXMIMMF_GENERA_PEDIDO_PDFInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7ddccdeb65a44283541a52358876da04Structure inParamRequest;
public S4PICall_ZMXMIMMF_GENERA_PEDIDO_PDFInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7ddccdeb65a44283541a52358876da04Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXMIMMF_GENERA_PEDIDO_PDFOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure outParamResponse;
public S4PICall_ZMXMIMMF_GENERA_PEDIDO_PDFOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXMIMMF_GENERA_PEDIDO_PDF
/// </summary>
public static async Task<ST_bc70ab3695876bb4315a9088f41998b7Structure> Call_ZMXMIMMF_GENERA_PEDIDO_PDF(IRequestContext requestContext,ST_7ddccdeb65a44283541a52358876da04Structure inParamRequest,CancellationToken cancellationToken) {
ST_bc70ab3695876bb4315a9088f41998b7Structure outParamResponse = default;
outParamResponse = new ST_bc70ab3695876bb4315a9088f41998b7Structure();

var serviceActionName = "Call_ZMXMIMMF_GENERA_PEDIDO_PDF";
var serviceActionKey = "94b05a9e-f2d7-410b-8332-a35ccc121e83";
var inputs = new S4PICall_ZMXMIMMF_GENERA_PEDIDO_PDFInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_7ddccdeb65a44283541a52358876da04Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXMIMMF_GENERA_PEDIDO_PDFInput, S4PICall_ZMXMIMMF_GENERA_PEDIDO_PDFOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PIService_EM_SM_RMInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure inParamRequest;
public S4PIService_EM_SM_RMInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PIService_EM_SM_RMOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure outParamResponse;
public S4PIService_EM_SM_RMOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Service_EM_SM_RM
/// </summary>
public static async Task<ST_b3b2573902c6e22d9647e405d3baf728Structure> Service_EM_SM_RM(IRequestContext requestContext,ST_c338780fd6468541199340ed93f1aecdStructure inParamRequest,CancellationToken cancellationToken) {
ST_b3b2573902c6e22d9647e405d3baf728Structure outParamResponse = default;
outParamResponse = new ST_b3b2573902c6e22d9647e405d3baf728Structure();

var serviceActionName = "Service_EM_SM_RM";
var serviceActionKey = "9e557fde-798f-4c11-a4de-92c8973b3e58";
var inputs = new S4PIService_EM_SM_RMInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c338780fd6468541199340ed93f1aecdStructure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIService_EM_SM_RMInput, S4PIService_EM_SM_RMOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b3b2573902c6e22d9647e405d3baf728Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXFFIMF_CONTA_FACTURASInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure inParamRequest;
public S4PICall_ZMXFFIMF_CONTA_FACTURASInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXFFIMF_CONTA_FACTURASOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_926df962559a6c34055113c885aa4885Structure outParamResponse;
public S4PICall_ZMXFFIMF_CONTA_FACTURASOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_926df962559a6c34055113c885aa4885Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXFFIMF_CONTA_FACTURAS
/// </summary>
public static async Task<ST_926df962559a6c34055113c885aa4885Structure> Call_ZMXFFIMF_CONTA_FACTURAS(IRequestContext requestContext,ST_012aef00497ef6b298e25799608b1289Structure inParamRequest,CancellationToken cancellationToken) {
ST_926df962559a6c34055113c885aa4885Structure outParamResponse = default;
outParamResponse = new ST_926df962559a6c34055113c885aa4885Structure();

var serviceActionName = "Call_ZMXFFIMF_CONTA_FACTURAS";
var serviceActionKey = "b4df216d-9b7b-459f-8913-2117dac0c30e";
var inputs = new S4PICall_ZMXFFIMF_CONTA_FACTURASInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXFFIMF_CONTA_FACTURASInput, S4PICall_ZMXFFIMF_CONTA_FACTURASOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_926df962559a6c34055113c885aa4885Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_Z01_READ_TEXTInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c4a97e6963b2cd0d749b56dde8d26a02Structure inParamRequest;
public S4PICall_Z01_READ_TEXTInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c4a97e6963b2cd0d749b56dde8d26a02Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_Z01_READ_TEXTOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure outParamResponse;
public S4PICall_Z01_READ_TEXTOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_Z01_READ_TEXT
/// </summary>
public static async Task<ST_cc99e347274d861473c4d7d08b6332b6Structure> Call_Z01_READ_TEXT(IRequestContext requestContext,ST_c4a97e6963b2cd0d749b56dde8d26a02Structure inParamRequest,CancellationToken cancellationToken) {
ST_cc99e347274d861473c4d7d08b6332b6Structure outParamResponse = default;
outParamResponse = new ST_cc99e347274d861473c4d7d08b6332b6Structure();

var serviceActionName = "Call_Z01_READ_TEXT";
var serviceActionKey = "b53c0211-1986-4e6f-8304-7dd64636a95a";
var inputs = new S4PICall_Z01_READ_TEXTInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_c4a97e6963b2cd0d749b56dde8d26a02Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_Z01_READ_TEXTInput, S4PICall_Z01_READ_TEXTOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cc99e347274d861473c4d7d08b6332b6Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_ZMXFAPMF_CONSUL_RETENPROVInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure inParamRequest;
public S4PICall_ZMXFAPMF_CONSUL_RETENPROVInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_ZMXFAPMF_CONSUL_RETENPROVOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure outParamResponse;
public S4PICall_ZMXFAPMF_CONSUL_RETENPROVOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_ZMXFAPMF_CONSUL_RETENPROV
/// </summary>
public static async Task<ST_24353ddcec93ac51b13ce9ab94fe4001Structure> Call_ZMXFAPMF_CONSUL_RETENPROV(IRequestContext requestContext,ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure inParamRequest,CancellationToken cancellationToken) {
ST_24353ddcec93ac51b13ce9ab94fe4001Structure outParamResponse = default;
outParamResponse = new ST_24353ddcec93ac51b13ce9ab94fe4001Structure();

var serviceActionName = "Call_ZMXFAPMF_CONSUL_RETENPROV";
var serviceActionKey = "bca1f997-cf61-4144-8968-6d72806a0a31";
var inputs = new S4PICall_ZMXFAPMF_CONSUL_RETENPROVInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_ZMXFAPMF_CONSUL_RETENPROVInput, S4PICall_ZMXFAPMF_CONSUL_RETENPROVOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_24353ddcec93ac51b13ce9ab94fe4001Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PICall_BAPI_GL_ACC_GETDETAILInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure inParamRequest;
public S4PICall_BAPI_GL_ACC_GETDETAILInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PICall_BAPI_GL_ACC_GETDETAILOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure outParamResponse;
public S4PICall_BAPI_GL_ACC_GETDETAILOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Call_BAPI_GL_ACC_GETDETAIL
/// </summary>
public static async Task<ST_0f0d90fe4adeeddf082edffc80174eb8Structure> Call_BAPI_GL_ACC_GETDETAIL(IRequestContext requestContext,ST_442654d6c8649545cfc0a9d6bfc9f12cStructure inParamRequest,CancellationToken cancellationToken) {
ST_0f0d90fe4adeeddf082edffc80174eb8Structure outParamResponse = default;
outParamResponse = new ST_0f0d90fe4adeeddf082edffc80174eb8Structure();

var serviceActionName = "Call_BAPI_GL_ACC_GETDETAIL";
var serviceActionKey = "e9c35e51-74e2-4db7-b902-3fef7a4d33e3";
var inputs = new S4PICall_BAPI_GL_ACC_GETDETAILInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_442654d6c8649545cfc0a9d6bfc9f12cStructure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PICall_BAPI_GL_ACC_GETDETAILInput, S4PICall_BAPI_GL_ACC_GETDETAILOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0f0d90fe4adeeddf082edffc80174eb8Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PIServicePostValidacfdiprovInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure inParamRequest;
public S4PIServicePostValidacfdiprovInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PIServicePostValidacfdiprovOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure outParamResponse;
public S4PIServicePostValidacfdiprovOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServicePostValidacfdiprov
/// </summary>
public static async Task<ST_13caff817360521524d01995a65282cdStructure> ServicePostValidacfdiprov(IRequestContext requestContext,ST_1e5384bdcb5c8be6badd45c0e821aec6Structure inParamRequest,CancellationToken cancellationToken) {
ST_13caff817360521524d01995a65282cdStructure outParamResponse = default;
outParamResponse = new ST_13caff817360521524d01995a65282cdStructure();

var serviceActionName = "ServicePostValidacfdiprov";
var serviceActionKey = "ec3342a8-ecef-42ff-9879-541a65a1a756";
var inputs = new S4PIServicePostValidacfdiprovInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e5384bdcb5c8be6badd45c0e821aec6Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServicePostValidacfdiprovInput, S4PIServicePostValidacfdiprovOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_13caff817360521524d01995a65282cdStructure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}
public class S4PIService_EM_SM_MOInput {
[JsonProperty("Request")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure inParamRequest;
public S4PIService_EM_SM_MOInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure inParamRequest) {
this.inParamRequest = inParamRequest;
}

}

public class S4PIService_EM_SM_MOOutput {
[JsonProperty("Response")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure outParamResponse;
public S4PIService_EM_SM_MOOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure outParamResponse) {
this.outParamResponse = outParamResponse;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: Service_EM_SM_MO
/// </summary>
public static async Task<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> Service_EM_SM_MO(IRequestContext requestContext,ST_f61ad0d448ed247a1bde22a5051a7d04Structure inParamRequest,CancellationToken cancellationToken) {
ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure outParamResponse = default;
outParamResponse = new ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure();

var serviceActionName = "Service_EM_SM_MO";
var serviceActionKey = "ffdd2ff6-cd35-4af5-94e4-8118bd9ab080";
var inputs = new S4PIService_EM_SM_MOInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_f61ad0d448ed247a1bde22a5051a7d04Structure.FromStructure(inParamRequest, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIService_EM_SM_MOInput, S4PIService_EM_SM_MOOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamResponse = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5a2f27e86c3f9cff3d6a27ca1772d236Structure.ToStructure(outputs.outParamResponse, ServiceConfiguration);
await Task.Yield();

return outParamResponse;
}

        }
    }
}
