// Proxy for reference eSpace with name Organization and key NR9oSS2Ryka0XPKg82V5qQ
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceOrganization
/// </summary>
public partial class RsseSpaceOrganization {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceOrganization");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
       }
   }
public static async Task<long> ServiceSupplierCreateOrUpdate(IRequestContext requestContext,IRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
outParamId = await OrganizationServiceAPIClients.ServiceSupplierCreateOrUpdate(requestContext,_proxyinParamSource,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task<long> ServiceCompanyCreateOrUpdate(IRequestContext requestContext,IRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
outParamId = await OrganizationServiceAPIClients.ServiceCompanyCreateOrUpdate(requestContext,_proxyinParamSource,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task<int> GetUserPreferences(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
int outParamo_TableLinesCount = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
outParamo_TableLinesCount = await OrganizationServiceAPIClients.GetUserPreferences(requestContext,inParami_UserId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamo_TableLinesCount;
}


public static async Task<(bool,bool,bool)> ServiceCheckSupplierUserEmail(IRequestContext requestContext,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_NotExists = default;
bool outParamo_NotActive = default;
bool outParamo_IsDeleted = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
(outParamo_NotExists,outParamo_NotActive,outParamo_IsDeleted) = await OrganizationServiceAPIClients.ServiceCheckSupplierUserEmail(requestContext,inParami_Email,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return (outParamo_NotExists,outParamo_NotActive,outParamo_IsDeleted);
}


public static async Task<(IRecord,bool)> ServiceSetUserData<ToutParamo_Return>(IRequestContext requestContext,string inParami_Email,string inParami_RegionToBeassigned,CancellationToken cancellationToken) where ToutParamo_Return : IRecord,new() {
IRecord outParamo_Return = default;
bool outParamo_HasChangedJobTitle = default;
outParamo_Return = new ToutParamo_Return();;
ST_b1b6df219277397c7c2be747d587880aStructure _proxyoutParamo_Return = new ST_b1b6df219277397c7c2be747d587880aStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
(_proxyoutParamo_Return,outParamo_HasChangedJobTitle) = await OrganizationServiceAPIClients.ServiceSetUserData(requestContext,inParami_Email,inParami_RegionToBeassigned,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamo_Return.FillFromOther(_proxyoutParamo_Return);await Task.Yield();
return (outParamo_Return,outParamo_HasChangedJobTitle);
}


public static async Task<long> ServiceApplicantCreateOrUpdate(IRequestContext requestContext,IRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
outParamId = await OrganizationServiceAPIClients.ServiceApplicantCreateOrUpdate(requestContext,_proxyinParamSource,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task ServiceProject_Asset_ServiceDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
await OrganizationServiceAPIClients.ServiceProject_Asset_ServiceDelete(requestContext,inParamId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<IRecord> ServiceUserProviderSetLastLoginDate<ToutParamo_Return>(IRequestContext requestContext,string inParami_userId,CancellationToken cancellationToken) where ToutParamo_Return : IRecord,new() {
IRecord outParamo_Return = default;
outParamo_Return = new ToutParamo_Return();;
ST_b1b6df219277397c7c2be747d587880aStructure _proxyoutParamo_Return = new ST_b1b6df219277397c7c2be747d587880aStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
_proxyoutParamo_Return = await OrganizationServiceAPIClients.ServiceUserProviderSetLastLoginDate(requestContext,inParami_userId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamo_Return.FillFromOther(_proxyoutParamo_Return);await Task.Yield();
return outParamo_Return;
}


public static async Task<IRecord> ServiceSetUserPreferences<ToutParamo_Return>(IRequestContext requestContext,IRecord inParami_Preferences,CancellationToken cancellationToken) where ToutParamo_Return : IRecord,new() {
IRecord outParamo_Return = default;
var _proxyinParami_Preferences = new EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord();
outParamo_Return = new ToutParamo_Return();;
ST_b1b6df219277397c7c2be747d587880aStructure _proxyoutParamo_Return = new ST_b1b6df219277397c7c2be747d587880aStructure();
_proxyinParami_Preferences.FillFromOther(inParami_Preferences);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
_proxyoutParamo_Return = await OrganizationServiceAPIClients.ServiceSetUserPreferences(requestContext,_proxyinParami_Preferences,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamo_Return.FillFromOther(_proxyoutParamo_Return);await Task.Yield();
return outParamo_Return;
}


public static async Task<long> ServiceDocumentTypeCreateOrUpdate(IRequestContext requestContext,IRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_a70d553ce1458b3952d039852f258a76EntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
outParamId = await OrganizationServiceAPIClients.ServiceDocumentTypeCreateOrUpdate(requestContext,_proxyinParamSource,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task<long> ServiceAccountingAccounts_ServiceTypeCreateOrUpdat(IRequestContext requestContext,IRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
outParamId = await OrganizationServiceAPIClients.ServiceAccountingAccounts_ServiceTypeCreateOrUpdat(requestContext,_proxyinParamSource,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task<long> ServiceTelcelDirectionCreate(IRequestContext requestContext,IRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
outParamId = await OrganizationServiceAPIClients.ServiceTelcelDirectionCreate(requestContext,_proxyinParamSource,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task ServiceUser_Extended_InternalDelete(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
await OrganizationServiceAPIClients.ServiceUser_Extended_InternalDelete(requestContext,inParamId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public sealed partial class ENAccountingAccounts_ServiceTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingAccounts_ServiceType, "accou_ok7ot05vqroxotoyq_0vh7y6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAccountingAccounts_ServiceTypeEntity
public sealed partial class ENDepositTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@DepositType, "depos_ok7ot05vqroxkq8ky0yfj1a7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENDepositTypeEntity
public sealed partial class ENAccountingDataTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountingDataType, "estim_ok7ot05vqrot1x9s0vlynxf1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAccountingDataTypeEntity
public sealed partial class ENInsuranceTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InsuranceType, "insur_ok7ot05vqroqdx4ubmeo4eo7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENInsuranceTypeEntity
public sealed partial class ENManualsEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Manuals, "manua_ok7ot05vqrokvkybece8dud3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENManualsEntity
public sealed partial class ENPaymentOptionsEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentOptions, "payme_ok7ot05vqroy32rocyelm4l5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPaymentOptionsEntity
public sealed partial class ENManualFileEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualFile, "manua_ok7ot05vqrotq1d12muzip05"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENManualFileEntity
public sealed partial class ENCustomSettingsEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettings, "custo_ok7ot05vqror0uz5g4jbzyl2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCustomSettingsEntity
public sealed partial class ENServiceFormatEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ServiceFormat, "servi_ok7ot05vqrovxh9ytayefl24"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENServiceFormatEntity
public sealed partial class ENInvoiceUsageEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoiceUsage, "invoi_ok7ot05vqromhvlvqj0m7w62"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENInvoiceUsageEntity
public sealed partial class ENSubdirectionEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Subdirection, "subdi_ok7ot05vqrouuprvhsxi5qr4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSubdirectionEntity
public sealed partial class ENApplicantTelcelDirectionEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApplicantTelcelDirection, "appli_ok7ot05vqrojtxizj3uetwx1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENApplicantTelcelDirectionEntity
public sealed partial class ENCFDITypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CFDIType, "cfdit_ok7ot05vqromgb0f3bt2wec6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCFDITypeEntity
public sealed partial class ENPurchasingGroupEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PurchasingGroup, "purch_ok7ot05vqrom9et5kg5qcs95"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPurchasingGroupEntity
public sealed partial class ENTaxIndicatorEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@TaxIndicator, "taxin_ok7ot05vqrosjjh8q5ded0o1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENTaxIndicatorEntity
public sealed partial class ENDistributionEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Distribution, "distr_ok7ot05vqrojz1odl8j3wxi1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENDistributionEntity
public sealed partial class ENRetentionTypesEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@RetentionTypes, "reten_ok7ot05vqrojblgam1a5eet6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENRetentionTypesEntity
public sealed partial class ENUser_Extended_InternalEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Extended_Internal, "user__ok7ot05vqrokko456jh6e415"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENUser_Extended_InternalEntity
public sealed partial class ENIVAExceptionM9SuppliersEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@IVAExceptionM9Suppliers, "ivaex_ok7ot05vqrom4wox8wwlezx1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENIVAExceptionM9SuppliersEntity
public sealed partial class ENUser_PreferencesEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@User_Preferences, "user__ok7ot05vqroujzi5wf_ij983"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENUser_PreferencesEntity
public sealed partial class ENDocumentTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@DocumentType, "docum_ok7ot05vqrolcemnuk1sd7v3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENDocumentTypeEntity
public sealed partial class ENSupplierUserEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierUser, "suppl_ok7ot05vqropo2c8wsb8pk14"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSupplierUserEntity
public sealed partial class ENCompanyEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Company, "compa_ok7ot05vqromd0dqd58fg5v3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCompanyEntity
public sealed partial class ENDepartmentEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Department, "depar_ok7ot05vqrosfo7zkuiha1m6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENDepartmentEntity
public sealed partial class ENApplicantEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Applicant, "appli_ok7ot05vqromep4kmlwcc2a2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENApplicantEntity
public sealed partial class ENApprovalProcessTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ApprovalProcessType, "appro_ok7ot05vqroqd6np8hzb3z75"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENApprovalProcessTypeEntity
public sealed partial class ENSupplierEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Supplier, "suppl_ok7ot05vqromvlyop842lwg2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSupplierEntity
public sealed partial class ENCostCenterSAPEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CostCenterSAP, "costc_ok7ot05vqror6mk6om5dtb20"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCostCenterSAPEntity
public sealed partial class ENAccountableGuideEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AccountableGuide, "accou_ok7ot05vqropcp3e02z0hg94"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAccountableGuideEntity
public sealed partial class ENSpecialPostDeliveryAuthorizationEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SpecialPostDeliveryAuthorization, "speci_ok7ot05vqros5tbmhixsa2x2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSpecialPostDeliveryAuthorizationEntity
public sealed partial class ENTelcelDirectionEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@TelcelDirection, "direc_ok7ot05vqroyq620yvgk58h6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENTelcelDirectionEntity
public sealed partial class ENFrequencyEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Frequency, "frequ_ok7ot05vqropp6evudul9mf4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENFrequencyEntity
public sealed partial class ENManagementEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Management, "manag_ok7ot05vqrokixk036l04p61"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENManagementEntity
public sealed partial class ENSegmentAccGroupEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SegmentAccGroup, "segme_ok7ot05vqror7il63fpy6id0"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSegmentAccGroupEntity
public sealed partial class ENAppConceptEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AppConcept, "appco_ok7ot05vqrox9u04cv0z6k97"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAppConceptEntity
public sealed partial class ENInvoicesUsageAccountsEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@InvoicesUsageAccounts, "invoi_ok7ot05vqropalnwj_whax81"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENInvoicesUsageAccountsEntity
public sealed partial class ENCustomSettingValueEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@CustomSettingValue, "custo_ok7ot05vqrovql84b0bputv2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENCustomSettingValueEntity
public sealed partial class ENEntryBlockDatesEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@EntryBlockDates, "entry_ok7ot05vqrothxf6rdxb7mr3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENEntryBlockDatesEntity
public sealed partial class ENProject_Asset_ServiceEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Project_Asset_Service, "proje_ok7ot05vqrox82hxrqwia8s7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENProject_Asset_ServiceEntity
public sealed partial class ENManualUserAreaEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ManualUserArea, "manua_ok7ot05vqropmqkg11a0gej6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENManualUserAreaEntity
public sealed partial class ENPaymentTermsEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentTerms, "payme_ok7ot05vqroy8ekgimbvgzw4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPaymentTermsEntity
public sealed partial class ENPaymentWaysEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentWays, "payme_ok7ot05vqrorjpap1y2ji4x2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPaymentWaysEntity
public sealed partial class ENUserAreaEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@UserArea, "usera_ok7ot05vqroxrhvmkdsh5v91"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENUserAreaEntity
public sealed partial class ENAdvancePaymentTypeEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@AdvancePaymentType, "advan_ok7ot05vqrojc6gpla2r27i5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENAdvancePaymentTypeEntity
public sealed partial class ENPaymentMethodsEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@PaymentMethods, "payme_ok7ot05vqrothiz6ffuaevt3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENPaymentMethodsEntity
public sealed partial class ENSegmentAccGroupTelcelDirEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SegmentAccGroupTelcelDir, "segme_ok7ot05vqroo4hjks8ryp4y5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSegmentAccGroupTelcelDirEntity
public sealed partial class ENSupplierDetailEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@SupplierDetail, "suppl_ok7ot05vqrojq50ug2o0ro04"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSupplierDetailEntity
public sealed partial class ENFiscalYearExceptionsEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@FiscalYearExceptions, "fisca_ok7ot05vqroys7uc_ouozdn4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENFiscalYearExceptionsEntity
public sealed partial class ENBusinessValueCategoryEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@BusinessValueCategory, "busin_ok7ot05vqrouq8swe5gtdk06"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENBusinessValueCategoryEntity
public sealed partial class ENSustainabilityEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Sustainability, "susta_ok7ot05vqroyvqqwznlheem6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENSustainabilityEntity
public sealed partial class ENVirtualStoreEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@VirtualStore, "virtu_ok7ot05vqroub4my4fjrziw5"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENVirtualStoreEntity
public sealed partial class ENRegionEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@Region, "regio_ok7ot05vqroorg1hcklnjep3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENRegionEntity
public sealed partial class ENProcessTypeDatesAllowedEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@ProcessTypeDatesAllowed, "proce_ok7ot05vqroli49onpjdisl4"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENProcessTypeDatesAllowedEntity
public sealed partial class ENBusinessValueSubcategoryEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@Organization, _EntityKeyConstants._OrganizationEntityKeys.@BusinessValueSubcategory, "busin_ok7ot05vqrotfumdfdpnl340"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("deebe1cf-a029-4ef6-9cff-f0e01fed8e07");
} // ENBusinessValueSubcategoryEntity

public class DefaultValues {
}
}
}
