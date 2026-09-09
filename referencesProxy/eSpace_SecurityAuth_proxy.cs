// Proxy for reference eSpace with name SecurityAuth and key EZykd7pUa0egEVqARoayeg
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceSecurityAuth
/// </summary>
public partial class RsseSpaceSecurityAuth {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceSecurityAuth");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
       }
   }
public static async Task<int> GetMaxSavedOldPasswords(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamValue = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
outParamValue = await SecurityAuthServiceAPIClients.GetMaxSavedOldPasswords(requestContext,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamValue;
}


public static async Task<bool> CheckOldPassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_IsOld = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
outParamo_IsOld = await SecurityAuthServiceAPIClients.CheckOldPassword(requestContext,inParami_Password,inParami_Email,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamo_IsOld;
}


public static async Task<(long,IRecord)> ServiceUserApplicationRoleTempRevoke<ToutParamOutput>(IRequestContext requestContext,IRecord inParamSource,CancellationToken cancellationToken) where ToutParamOutput : IRecord,new() {
long outParamId = default;
IRecord outParamOutput = default;
var _proxyinParamSource = new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
outParamOutput = new ToutParamOutput();;
ST_346a76e47f982dbf41625f8a893affccStructure _proxyoutParamOutput = new ST_346a76e47f982dbf41625f8a893affccStructure();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
(outParamId,_proxyoutParamOutput) = await SecurityAuthServiceAPIClients.ServiceUserApplicationRoleTempRevoke(requestContext,_proxyinParamSource,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamOutput.FillFromOther(_proxyoutParamOutput);await Task.Yield();
return (outParamId,outParamOutput);
}


public static async Task ServiceGrantFolios(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
await SecurityAuthServiceAPIClients.ServiceGrantFolios(requestContext,inParamUserid,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<(long,IRecord)> ServiceUserApplicationRoleTempAssign<ToutParamOutput>(IRequestContext requestContext,IRecord inParamSource,string inParamUserId,CancellationToken cancellationToken) where ToutParamOutput : IRecord,new() {
long outParamId = default;
IRecord outParamOutput = default;
var _proxyinParamSource = new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
outParamOutput = new ToutParamOutput();;
ST_346a76e47f982dbf41625f8a893affccStructure _proxyoutParamOutput = new ST_346a76e47f982dbf41625f8a893affccStructure();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
(outParamId,_proxyoutParamOutput) = await SecurityAuthServiceAPIClients.ServiceUserApplicationRoleTempAssign(requestContext,_proxyinParamSource,inParamUserId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamOutput.FillFromOther(_proxyoutParamOutput);await Task.Yield();
return (outParamId,outParamOutput);
}


public static async Task ServiceRevokeProveedores(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
await SecurityAuthServiceAPIClients.ServiceRevokeProveedores(requestContext,inParamUserid,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<bool> CheckLastPassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_IsCorrect = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
outParamo_IsCorrect = await SecurityAuthServiceAPIClients.CheckLastPassword(requestContext,inParami_Password,inParami_Email,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamo_IsCorrect;
}


public static async Task ServiceGrantRequisiciones(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
await SecurityAuthServiceAPIClients.ServiceGrantRequisiciones(requestContext,inParamUserid,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<bool> ServiceSupplierCodeValidate(IRequestContext requestContext,string inParamUserEmail,string inParamCode,CancellationToken cancellationToken) {
bool outParamIsValid = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
outParamIsValid = await SecurityAuthServiceAPIClients.ServiceSupplierCodeValidate(requestContext,inParamUserEmail,inParamCode,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamIsValid;
}


public static async Task<string> ServiceSetSupplierLoginCode(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
string outParamCode = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
outParamCode = await SecurityAuthServiceAPIClients.ServiceSetSupplierLoginCode(requestContext,inParamEmail,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamCode;
}


public static async Task SavePassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
await SecurityAuthServiceAPIClients.SavePassword(requestContext,inParami_Password,inParami_Email,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task<(IRecord,bool,long)> ServiceEntraRoleCreate<ToutParamo_output>(IRequestContext requestContext,string inParami_RoleName,CancellationToken cancellationToken) where ToutParamo_output : IRecord,new() {
IRecord outParamo_output = default;
bool outParamHasBeenCreated = default;
long outParamEntraRoleId = default;
outParamo_output = new ToutParamo_output();;
ST_346a76e47f982dbf41625f8a893affccStructure _proxyoutParamo_output = new ST_346a76e47f982dbf41625f8a893affccStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
(_proxyoutParamo_output,outParamHasBeenCreated,outParamEntraRoleId) = await SecurityAuthServiceAPIClients.ServiceEntraRoleCreate(requestContext,inParami_RoleName,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamo_output.FillFromOther(_proxyoutParamo_output);await Task.Yield();
return (outParamo_output,outParamHasBeenCreated,outParamEntraRoleId);
}


public static async Task ServiceGrantProveedores(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
await SecurityAuthServiceAPIClients.ServiceGrantProveedores(requestContext,inParamUserid,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public static async Task ServiceGrantPedidos(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
await SecurityAuthServiceAPIClients.ServiceGrantPedidos(requestContext,inParamUserid,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return;
}


public sealed partial class ENRoleConceptEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleConcept, "rolec_e_ge42by2w4b5wnxcw0jt1k3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENRoleConceptEntity
public sealed partial class ENUserApplicationRoleEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRole, "usera_e_ge42by2w4fyxanldizlvd2"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENUserApplicationRoleEntity
public sealed partial class ENConceptEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@Concept, "conce_e_ge42by2w4fd0xqvresv_p7"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENConceptEntity
public sealed partial class ENApplicationRoleEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@ApplicationRole, "appli_e_ge42by2w4lfrzu7izq3q41"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENApplicationRoleEntity
public sealed partial class ENUserApplicationRoleTempByConceptEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTempByConcept, "usera_e_ge42by2w4js5d0k_bvxd_1"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENUserApplicationRoleTempByConceptEntity
public sealed partial class ENEntraRoleEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@EntraRole, "entra_e_ge42by2w4e8ha9xvwdiqa3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENEntraRoleEntity
public sealed partial class ENUserApplicationRoleTempEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@UserApplicationRoleTemp, "usera_e_ge42by2w4dlamvmgvh87u6"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENUserApplicationRoleTempEntity
public sealed partial class ENRoleStatusEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@SecurityAuth, _EntityKeyConstants._SecurityAuthEntityKeys.@RoleStatus, "roles_e_ge42by2w4abk5tg49v3231"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962");
} // ENRoleStatusEntity

public class DefaultValues {
}
}
}
