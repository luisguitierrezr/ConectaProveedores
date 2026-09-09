using System.Collections.ObjectModel;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions;

using ssConectaProveedores.ReferencesProxy;

namespace ssConectaProveedores {
    public partial class RsseSpaceOrganization {
        public class OrganizationServiceAPIClients : AbstractServiceApiClient {
            private static readonly OrganizationServiceAPIClients Instance = new();
            private OrganizationServiceAPIClients() : base(
                ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07"),
                "Organization",
                "ssConectaProveedores.OrganizationServiceAPIClients",
                ReadOnlyDictionary<string, Func<string, Exception>>.Empty
            ) { }

            public class S4PIServiceSupplierCreateOrUpdateInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParamSource;
public S4PIServiceSupplierCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceSupplierCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceSupplierCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceSupplierCreateOrUpdate
/// </summary>
public static async Task<long> ServiceSupplierCreateOrUpdate(IRequestContext requestContext,EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceSupplierCreateOrUpdate";
var serviceActionKey = "00e39871-384d-417b-abc4-466e648edbc3";
var inputs = new S4PIServiceSupplierCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(inParamSource, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceSupplierCreateOrUpdateInput, S4PIServiceSupplierCreateOrUpdateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceCompanyCreateOrUpdateInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord inParamSource;
public S4PIServiceCompanyCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceCompanyCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceCompanyCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceCompanyCreateOrUpdate
/// </summary>
public static async Task<long> ServiceCompanyCreateOrUpdate(IRequestContext requestContext,EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceCompanyCreateOrUpdate";
var serviceActionKey = "2c9dbc2e-3daa-4113-b9b5-415b25d283eb";
var inputs = new S4PIServiceCompanyCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord.FromStructure(inParamSource, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceCompanyCreateOrUpdateInput, S4PIServiceCompanyCreateOrUpdateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIGetUserPreferencesInput {
[JsonProperty("i_UserId")]
public string inParami_UserId;
public S4PIGetUserPreferencesInput(string inParami_UserId) {
this.inParami_UserId = inParami_UserId;
}

}

public class S4PIGetUserPreferencesOutput {
[JsonProperty("o_TableLinesCount")]
public int outParamo_TableLinesCount;
public S4PIGetUserPreferencesOutput(int outParamo_TableLinesCount) {
this.outParamo_TableLinesCount = outParamo_TableLinesCount;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: GetUserPreferences
/// </summary>
public static async Task<int> GetUserPreferences(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
int outParamo_TableLinesCount = default;
outParamo_TableLinesCount = 0;

var serviceActionName = "ServiceGetUserPreferences";
var serviceActionKey = "43b96afc-c61b-4fce-bcfd-1c2ad1ac0178";
var inputs = new S4PIGetUserPreferencesInput(inParami_UserId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIGetUserPreferencesInput, S4PIGetUserPreferencesOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_TableLinesCount = outputs.outParamo_TableLinesCount;
await Task.Yield();

return outParamo_TableLinesCount;
}
public class S4PIServiceCheckSupplierUserEmailInput {
[JsonProperty("i_Email")]
public string inParami_Email;
public S4PIServiceCheckSupplierUserEmailInput(string inParami_Email) {
this.inParami_Email = inParami_Email;
}

}

public class S4PIServiceCheckSupplierUserEmailOutput {
[JsonProperty("o_NotExists")]
public bool outParamo_NotExists;
[JsonProperty("o_NotActive")]
public bool outParamo_NotActive;
[JsonProperty("o_IsDeleted")]
public bool outParamo_IsDeleted;
public S4PIServiceCheckSupplierUserEmailOutput(bool outParamo_NotExists, bool outParamo_NotActive, bool outParamo_IsDeleted) {
this.outParamo_NotExists = outParamo_NotExists;
this.outParamo_NotActive = outParamo_NotActive;
this.outParamo_IsDeleted = outParamo_IsDeleted;
}

public S4PIServiceCheckSupplierUserEmailOutput() {
this.outParamo_IsDeleted = false;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceCheckSupplierUserEmail
/// </summary>
public static async Task<(bool,bool,bool)> ServiceCheckSupplierUserEmail(IRequestContext requestContext,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_NotExists = default;
bool outParamo_NotActive = default;
bool outParamo_IsDeleted = default;
outParamo_NotExists = false;

outParamo_NotActive = false;

outParamo_IsDeleted = false;

var serviceActionName = "ServiceCheckSupplierUserEmail";
var serviceActionKey = "559a85ee-7045-403f-a067-0ee195f9edfd";
var inputs = new S4PIServiceCheckSupplierUserEmailInput(inParami_Email);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceCheckSupplierUserEmailInput, S4PIServiceCheckSupplierUserEmailOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_NotExists = outputs.outParamo_NotExists;
outParamo_NotActive = outputs.outParamo_NotActive;
outParamo_IsDeleted = outputs.outParamo_IsDeleted;
await Task.Yield();

return (outParamo_NotExists,outParamo_NotActive,outParamo_IsDeleted);
}
public class S4PIServiceSetUserDataInput {
[JsonProperty("i_Email")]
public string inParami_Email;
[JsonProperty("i_RegionToBeassigned")]
public string inParami_RegionToBeassigned;
public S4PIServiceSetUserDataInput(string inParami_Email, string inParami_RegionToBeassigned) {
this.inParami_Email = inParami_Email;
this.inParami_RegionToBeassigned = inParami_RegionToBeassigned;
}

}

public class S4PIServiceSetUserDataOutput {
[JsonProperty("o_Return")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return;
[JsonProperty("o_HasChangedJobTitle")]
public bool outParamo_HasChangedJobTitle;
public S4PIServiceSetUserDataOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return, bool outParamo_HasChangedJobTitle) {
this.outParamo_Return = outParamo_Return;
this.outParamo_HasChangedJobTitle = outParamo_HasChangedJobTitle;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceSetUserData
/// </summary>
public static async Task<(ST_b1b6df219277397c7c2be747d587880aStructure,bool)> ServiceSetUserData(IRequestContext requestContext,string inParami_Email,string inParami_RegionToBeassigned,CancellationToken cancellationToken) {
ST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return = default;
bool outParamo_HasChangedJobTitle = default;
outParamo_Return = new ST_b1b6df219277397c7c2be747d587880aStructure();

outParamo_HasChangedJobTitle = false;

var serviceActionName = "ServiceSetUserData";
var serviceActionKey = "68c02eb0-6d21-4f33-9317-32afe3ed7d05";
var inputs = new S4PIServiceSetUserDataInput(inParami_Email, inParami_RegionToBeassigned);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceSetUserDataInput, S4PIServiceSetUserDataOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_Return = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure.ToStructure(outputs.outParamo_Return, ServiceConfiguration);
outParamo_HasChangedJobTitle = outputs.outParamo_HasChangedJobTitle;
await Task.Yield();

return (outParamo_Return,outParamo_HasChangedJobTitle);
}
public class S4PIServiceApplicantCreateOrUpdateInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord inParamSource;
public S4PIServiceApplicantCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceApplicantCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceApplicantCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceApplicantCreateOrUpdate
/// </summary>
public static async Task<long> ServiceApplicantCreateOrUpdate(IRequestContext requestContext,EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceApplicantCreateOrUpdate";
var serviceActionKey = "7488a9b3-1515-41b1-9ae7-60d16b296b62";
var inputs = new S4PIServiceApplicantCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord.FromStructure(inParamSource, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceApplicantCreateOrUpdateInput, S4PIServiceApplicantCreateOrUpdateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceProject_Asset_ServiceDeleteInput {
[JsonProperty("Id")]
public long? inParamId;
public S4PIServiceProject_Asset_ServiceDeleteInput(long? inParamId) {
this.inParamId = inParamId;
}

}

public class S4PIServiceProject_Asset_ServiceDeleteOutput {
public S4PIServiceProject_Asset_ServiceDeleteOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceProject_Asset_ServiceDelete
/// </summary>
public static async Task ServiceProject_Asset_ServiceDelete(IRequestContext requestContext,long? inParamId,CancellationToken cancellationToken) {
var serviceActionName = "ServiceProject_Asset_ServiceDelete";
var serviceActionKey = "8094abcc-c324-42f7-a3db-c653fbf3b1b6";
var inputs = new S4PIServiceProject_Asset_ServiceDeleteInput(inParamId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceProject_Asset_ServiceDeleteInput, S4PIServiceProject_Asset_ServiceDeleteOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}
public class S4PIServiceUserProviderSetLastLoginDateInput {
[JsonProperty("i_userId")]
public string inParami_userId;
public S4PIServiceUserProviderSetLastLoginDateInput(string inParami_userId) {
this.inParami_userId = inParami_userId;
}

}

public class S4PIServiceUserProviderSetLastLoginDateOutput {
[JsonProperty("o_Return")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return;
public S4PIServiceUserProviderSetLastLoginDateOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return) {
this.outParamo_Return = outParamo_Return;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceUserProviderSetLastLoginDate
/// </summary>
public static async Task<ST_b1b6df219277397c7c2be747d587880aStructure> ServiceUserProviderSetLastLoginDate(IRequestContext requestContext,string inParami_userId,CancellationToken cancellationToken) {
ST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return = default;
outParamo_Return = new ST_b1b6df219277397c7c2be747d587880aStructure();

var serviceActionName = "ServiceUserProviderSetLastLoginDate";
var serviceActionKey = "b148ecc9-35f7-40c9-bae6-acf9d3eab96b";
var inputs = new S4PIServiceUserProviderSetLastLoginDateInput(inParami_userId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceUserProviderSetLastLoginDateInput, S4PIServiceUserProviderSetLastLoginDateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_Return = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure.ToStructure(outputs.outParamo_Return, ServiceConfiguration);
await Task.Yield();

return outParamo_Return;
}
public class S4PIServiceSetUserPreferencesInput {
[JsonProperty("i_Preferences")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord inParami_Preferences;
public S4PIServiceSetUserPreferencesInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord inParami_Preferences) {
this.inParami_Preferences = inParami_Preferences;
}

}

public class S4PIServiceSetUserPreferencesOutput {
[JsonProperty("o_Return")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return;
public S4PIServiceSetUserPreferencesOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return) {
this.outParamo_Return = outParamo_Return;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceSetUserPreferences
/// </summary>
public static async Task<ST_b1b6df219277397c7c2be747d587880aStructure> ServiceSetUserPreferences(IRequestContext requestContext,EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord inParami_Preferences,CancellationToken cancellationToken) {
ST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return = default;
outParamo_Return = new ST_b1b6df219277397c7c2be747d587880aStructure();

var serviceActionName = "ServiceSetUserPreferences";
var serviceActionKey = "bc34e063-a515-4b40-beb4-a43799f966b5";
var inputs = new S4PIServiceSetUserPreferencesInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord.FromStructure(inParami_Preferences, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceSetUserPreferencesInput, S4PIServiceSetUserPreferencesOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_Return = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1b6df219277397c7c2be747d587880aStructure.ToStructure(outputs.outParamo_Return, ServiceConfiguration);
await Task.Yield();

return outParamo_Return;
}
public class S4PIServiceDocumentTypeCreateOrUpdateInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord inParamSource;
public S4PIServiceDocumentTypeCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceDocumentTypeCreateOrUpdateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceDocumentTypeCreateOrUpdateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceDocumentTypeCreateOrUpdate
/// </summary>
public static async Task<long> ServiceDocumentTypeCreateOrUpdate(IRequestContext requestContext,EN_a70d553ce1458b3952d039852f258a76EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceDocumentTypeCreateOrUpdate";
var serviceActionKey = "c32de4f0-6a17-4eaf-8bad-cdc17a3a17c4";
var inputs = new S4PIServiceDocumentTypeCreateOrUpdateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_a70d553ce1458b3952d039852f258a76EntityRecord.FromStructure(inParamSource, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceDocumentTypeCreateOrUpdateInput, S4PIServiceDocumentTypeCreateOrUpdateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceAccountingAccounts_ServiceTypeCreateOrUpdatInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord inParamSource;
public S4PIServiceAccountingAccounts_ServiceTypeCreateOrUpdatInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceAccountingAccounts_ServiceTypeCreateOrUpdatOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceAccountingAccounts_ServiceTypeCreateOrUpdatOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceAccountingAccounts_ServiceTypeCreateOrUpdat
/// </summary>
public static async Task<long> ServiceAccountingAccounts_ServiceTypeCreateOrUpdat(IRequestContext requestContext,EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceAccountingAccounts_ServiceTypeCreateOrUpdat";
var serviceActionKey = "d0b12a26-0bc3-4717-b1de-0280e3e0c9c0";
var inputs = new S4PIServiceAccountingAccounts_ServiceTypeCreateOrUpdatInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord.FromStructure(inParamSource, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceAccountingAccounts_ServiceTypeCreateOrUpdatInput, S4PIServiceAccountingAccounts_ServiceTypeCreateOrUpdatOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceTelcelDirectionCreateInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord inParamSource;
public S4PIServiceTelcelDirectionCreateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceTelcelDirectionCreateOutput {
[JsonProperty("Id")]
public long outParamId;
public S4PIServiceTelcelDirectionCreateOutput(long outParamId) {
this.outParamId = outParamId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceTelcelDirectionCreate
/// </summary>
public static async Task<long> ServiceTelcelDirectionCreate(IRequestContext requestContext,EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = 0L;

var serviceActionName = "ServiceTelcelDirectionCreate";
var serviceActionKey = "d6a4dc92-670b-4a27-9b61-a3bbec8f2937";
var inputs = new S4PIServiceTelcelDirectionCreateInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord.FromStructure(inParamSource, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceTelcelDirectionCreateInput, S4PIServiceTelcelDirectionCreateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
await Task.Yield();

return outParamId;
}
public class S4PIServiceUser_Extended_InternalDeleteInput {
[JsonProperty("Id")]
public string inParamId;
public S4PIServiceUser_Extended_InternalDeleteInput(string inParamId) {
this.inParamId = inParamId;
}

}

public class S4PIServiceUser_Extended_InternalDeleteOutput {
public S4PIServiceUser_Extended_InternalDeleteOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceUser_Extended_InternalDelete
/// </summary>
public static async Task ServiceUser_Extended_InternalDelete(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
var serviceActionName = "ServiceUser_Extended_InternalDelete";
var serviceActionKey = "fafe5807-bb05-4a87-b22c-565aa856ea8e";
var inputs = new S4PIServiceUser_Extended_InternalDeleteInput(inParamId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceUser_Extended_InternalDeleteInput, S4PIServiceUser_Extended_InternalDeleteOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}

        }
    }
}
