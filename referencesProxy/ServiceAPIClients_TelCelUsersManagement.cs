using System.Collections.ObjectModel;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions;

using ssConectaProveedores.ReferencesProxy;

namespace ssConectaProveedores {
    public partial class RsseSpaceTelCelUsersManagement {
        public class TelCelUsersManagementServiceAPIClients : AbstractServiceApiClient {
            private static readonly TelCelUsersManagementServiceAPIClients Instance = new();
            private TelCelUsersManagementServiceAPIClients() : base(
                ObjectKey.Parse("abbc6e11-902c-4319-878b-9d0fec641e61"),
                "TelCelUsersManagement",
                "ssConectaProveedores.TelCelUsersManagementServiceAPIClients",
                ExceptionsMapping.GeneratedExceptionsClientMapping
            ) { }

            public class S4PIServiceUserManagementLogsCreateInput {
[JsonProperty("UserId")]
public string inParamUserId;
[JsonProperty("Message")]
public string inParamMessage;
[JsonProperty("IpAddress")]
public string inParamIpAddress;
[JsonProperty("Screen")]
public string inParamScreen;
public S4PIServiceUserManagementLogsCreateInput(string inParamUserId, string inParamMessage, string inParamIpAddress, string inParamScreen) {
this.inParamUserId = inParamUserId;
this.inParamMessage = inParamMessage;
this.inParamIpAddress = inParamIpAddress;
this.inParamScreen = inParamScreen;
}

}

public class S4PIServiceUserManagementLogsCreateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceUserManagementLogsCreateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceUserManagementLogsCreate
/// </summary>
public static async Task<long> ServiceUserManagementLogsCreate(IRequestContext requestContext,string inParamUserId,string inParamMessage,string inParamIpAddress,string inParamScreen,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceUserManagementLogsCreate";
var serviceActionKey = "11f988d3-a8aa-41fc-a1dc-b402d6efe38a";
var inputs = new S4PIServiceUserManagementLogsCreateInput(inParamUserId, inParamMessage, inParamIpAddress, inParamScreen);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceUserManagementLogsCreateInput, S4PIServiceUserManagementLogsCreateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceApplicationRoles_GetLst_WrapperInput {
[JsonProperty("Key")]
public string inParamKey;
[JsonProperty("AssetKey")]
public string inParamAssetKey;
[JsonProperty("StageKey")]
public string inParamStageKey;
[JsonProperty("SearchText")]
public string inParamSearchText;
[JsonProperty("Sort")]
public string inParamSort;
[JsonProperty("MaxRecords")]
public int? inParamMaxRecords;
[JsonProperty("StartIndex")]
public int? inParamStartIndex;
public S4PIServiceApplicationRoles_GetLst_WrapperInput(string inParamKey, string inParamAssetKey, string inParamStageKey, string inParamSearchText, string inParamSort, int? inParamMaxRecords, int? inParamStartIndex) {
this.inParamKey = inParamKey;
this.inParamAssetKey = inParamAssetKey;
this.inParamStageKey = inParamStageKey;
this.inParamSearchText = inParamSearchText;
this.inParamSort = inParamSort;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamStartIndex = inParamStartIndex;
}

}

public class S4PIServiceApplicationRoles_GetLst_WrapperOutput {
[JsonProperty("RoleslList")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure[] outParamRoleslList;
[JsonProperty("TotalRoles")]
public int outParamTotalRoles;
public S4PIServiceApplicationRoles_GetLst_WrapperOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure[] outParamRoleslList, int outParamTotalRoles) {
this.outParamRoleslList = outParamRoleslList;
this.outParamTotalRoles = outParamTotalRoles;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceApplicationRoles_GetLst_Wrapper
/// </summary>
public static async Task<(RL_c31de23e3d152f2b2321aea18f795545,int)> ServiceApplicationRoles_GetLst_Wrapper(IRequestContext requestContext,string inParamKey,string inParamAssetKey,string inParamStageKey,string inParamSearchText,string inParamSort,int? inParamMaxRecords,int? inParamStartIndex,CancellationToken cancellationToken) {
RL_c31de23e3d152f2b2321aea18f795545 outParamRoleslList = default;
int outParamTotalRoles = default;
outParamRoleslList = new RL_c31de23e3d152f2b2321aea18f795545();

outParamTotalRoles = 0;

var serviceActionName = "ServiceApplicationRoles_GetLst_Wrapper";
var serviceActionKey = "3ed7d8d2-29e6-48de-b7dc-f0804072912b";
var inputs = new S4PIServiceApplicationRoles_GetLst_WrapperInput(inParamKey, inParamAssetKey, inParamStageKey, inParamSearchText, inParamSort, inParamMaxRecords, inParamStartIndex);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceApplicationRoles_GetLst_WrapperInput, S4PIServiceApplicationRoles_GetLst_WrapperOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamRoleslList = RL_c31de23e3d152f2b2321aea18f795545.ToList(outputs.outParamRoleslList, (str) => ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_5728db9d26b9364eef512c59f8517473Structure.ToStructure(str, ServiceConfiguration));
outParamTotalRoles = outputs.outParamTotalRoles;
await Task.Yield();

return (outParamRoleslList,outParamTotalRoles);
}
public class S4PIServiceApplicationRoles_GetUsers_WrapperInput {
[JsonProperty("Key")]
public string inParamKey;
[JsonProperty("Limit")]
public int? inParamLimit;
[JsonProperty("Offset")]
public int? inParamOffset;
public S4PIServiceApplicationRoles_GetUsers_WrapperInput(string inParamKey, int? inParamLimit, int? inParamOffset) {
this.inParamKey = inParamKey;
this.inParamLimit = inParamLimit;
this.inParamOffset = inParamOffset;
}

}

public class S4PIServiceApplicationRoles_GetUsers_WrapperOutput {
[JsonProperty("UsersList")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure[] outParamUsersList;
public S4PIServiceApplicationRoles_GetUsers_WrapperOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure[] outParamUsersList) {
this.outParamUsersList = outParamUsersList;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceApplicationRoles_GetUsers_Wrapper
/// </summary>
public static async Task<RL_c22ca0e0dff4c8c0d1575277d6d892be> ServiceApplicationRoles_GetUsers_Wrapper(IRequestContext requestContext,string inParamKey,int? inParamLimit,int? inParamOffset,CancellationToken cancellationToken) {
RL_c22ca0e0dff4c8c0d1575277d6d892be outParamUsersList = default;
outParamUsersList = new RL_c22ca0e0dff4c8c0d1575277d6d892be();

var serviceActionName = "ServiceApplicationRoles_GetUsers_Wrapper";
var serviceActionKey = "73a3d8bb-ed53-4afc-ae38-251828016470";
var inputs = new S4PIServiceApplicationRoles_GetUsers_WrapperInput(inParamKey, inParamLimit, inParamOffset);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceApplicationRoles_GetUsers_WrapperInput, S4PIServiceApplicationRoles_GetUsers_WrapperOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamUsersList = RL_c22ca0e0dff4c8c0d1575277d6d892be.ToList(outputs.outParamUsersList, (str) => ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3d98fcbf952bf72084dad4104cc8c43fStructure.ToStructure(str, ServiceConfiguration));
await Task.Yield();

return outParamUsersList;
}
public class S4PIServiceGetUserExtensionExternalEmailInput {
[JsonProperty("i_UserEmail")]
public string inParami_UserEmail;
public S4PIServiceGetUserExtensionExternalEmailInput(string inParami_UserEmail) {
this.inParami_UserEmail = inParami_UserEmail;
}

}

public class S4PIServiceGetUserExtensionExternalEmailOutput {
[JsonProperty("o_ExternalEmail")]
public string outParamo_ExternalEmail;
[JsonProperty("o_RegionToBeAssigned")]
public string outParamo_RegionToBeAssigned;
public S4PIServiceGetUserExtensionExternalEmailOutput(string outParamo_ExternalEmail, string outParamo_RegionToBeAssigned) {
this.outParamo_ExternalEmail = outParamo_ExternalEmail;
this.outParamo_RegionToBeAssigned = outParamo_RegionToBeAssigned;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGetUserExtensionExternalEmail
/// </summary>
public static async Task<(string,string)> ServiceGetUserExtensionExternalEmail(IRequestContext requestContext,string inParami_UserEmail,CancellationToken cancellationToken) {
string outParamo_ExternalEmail = default;
string outParamo_RegionToBeAssigned = default;
outParamo_ExternalEmail = "";

outParamo_RegionToBeAssigned = "";

var serviceActionName = "ServiceGetUserExtensionExternalEmail";
var serviceActionKey = "8938515f-888a-4029-88ac-ce4011122f6b";
var inputs = new S4PIServiceGetUserExtensionExternalEmailInput(inParami_UserEmail);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGetUserExtensionExternalEmailInput, S4PIServiceGetUserExtensionExternalEmailOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_ExternalEmail = outputs.outParamo_ExternalEmail;
outParamo_RegionToBeAssigned = outputs.outParamo_RegionToBeAssigned;
await Task.Yield();

return (outParamo_ExternalEmail,outParamo_RegionToBeAssigned);
}

        }
    }
}
