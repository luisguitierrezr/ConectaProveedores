using System.Diagnostics;
using Pair = OutSystems.RuntimeCommon.Pair;

namespace ssConectaProveedores;
public partial class ExtendedActions {
private static readonly ActivitySource activitySource = new(typeof(ExtendedActions).Namespace);
public static readonly ObjectKey rConectaProveedoresKey = ObjectKey.Parse("OWsqqzAfIE+gac9dGLB29A");
public static readonly ObjectKey roConectaProveedoresOwnerEspaceKey = ObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA");
public static readonly ObjectKey rHistoricoKey = ObjectKey.Parse("OWsqqzAfIE+gac9dGLB29A");
public static readonly ObjectKey roHistoricoOwnerEspaceKey = ObjectKey.Parse("oxbwFgWKyEm0ZmBOS0n8mw");
public static readonly ObjectKey rComissionesArrendamientosViewerKey = ObjectKey.Parse("q6pVGbi6VkKCcfamUuFgog");
public static readonly ObjectKey roComissionesArrendamientosViewerOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rConectaProveedoresAdminKey = ObjectKey.Parse("Nbg3RSyv2ESMgQc2bcoXCw");
public static readonly ObjectKey roConectaProveedoresAdminOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rComissionesArrendamientosKey = ObjectKey.Parse("PdLMTKKyjEWrQRcaDEsRwQ");
public static readonly ObjectKey roComissionesArrendamientosOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rFoliosKey = ObjectKey.Parse("sxmAThyhq0ychNVzTM_xtw");
public static readonly ObjectKey roFoliosOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rComissionesArrendamientosAdminKey = ObjectKey.Parse("n7coXb9SqEy0IwZjoyR8wA");
public static readonly ObjectKey roComissionesArrendamientosAdminOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rAlmacenKey = ObjectKey.Parse("PWbtePdyQkWC4NkFuv+rKA");
public static readonly ObjectKey roAlmacenOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rReportesKey = ObjectKey.Parse("lCRAgOD9z0SOU2y+BJgVCA");
public static readonly ObjectKey roReportesOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rConectaProveedoresAdminViewerKey = ObjectKey.Parse("4z2CgPUnZ0G8hLg9TPlodQ");
public static readonly ObjectKey roConectaProveedoresAdminViewerOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rPedidosKey = ObjectKey.Parse("p5+7gSMHiUeidNannmb40w");
public static readonly ObjectKey roPedidosOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rTesoreriaKey = ObjectKey.Parse("2o9RlpI77kuCRGhbgqQYdg");
public static readonly ObjectKey roTesoreriaOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rDesviacionesKey = ObjectKey.Parse("x5zAsscRm0CIK85rL12Jzw");
public static readonly ObjectKey roDesviacionesOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rProveedorKey = ObjectKey.Parse("ZrcHulAUKke4n1NzMyqOcA");
public static readonly ObjectKey roProveedorOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rSAPImportOrdersKey = ObjectKey.Parse("OnNk3yV_60+syLVeEV+A1A");
public static readonly ObjectKey roSAPImportOrdersOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rRequisicionesKey = ObjectKey.Parse("3ZQi_D69+EOETRGJ2tV5Uw");
public static readonly ObjectKey roRequisicionesOwnerEspaceKey = ObjectKey.Parse("eiqzl1RRZEO7QhTR8NH5Yg");
public static readonly ObjectKey rTelcelUserAuditorKey = ObjectKey.Parse("nN6ggy3p1kC+PgZOqCKyVw");
public static readonly ObjectKey roTelcelUserAuditorOwnerEspaceKey = ObjectKey.Parse("EW68qyyQGUOHi50P7GQeYQ");
/// <summary>
/// Action: CheckConectaProveedoresRole
/// </summary>

public static async Task<bool> CheckConectaProveedoresRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rConectaProveedoresKey.AsGuid, roConectaProveedoresOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rConectaProveedoresKey.AsGuid, roConectaProveedoresOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: GrantConectaProveedoresRole
/// </summary>

public static async Task GrantConectaProveedoresRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
if (string.IsNullOrEmpty(inParamUserId)){
await GenericExtendedActions.GrantAsync(requestContext, rConectaProveedoresKey.AsGuid, roConectaProveedoresOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
await GenericExtendedActions.GrantAsync(requestContext, rConectaProveedoresKey.AsGuid, roConectaProveedoresOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return;
}

/// <summary>
/// Action: RevokeConectaProveedoresRole
/// </summary>

public static async Task RevokeConectaProveedoresRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
if (string.IsNullOrEmpty(inParamUserId)){
await GenericExtendedActions.RevokeAsync(requestContext, rConectaProveedoresKey.AsGuid, roConectaProveedoresOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
await GenericExtendedActions.RevokeAsync(requestContext, rConectaProveedoresKey.AsGuid, roConectaProveedoresOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return;
}

/// <summary>
/// Action: CheckHistoricoRole
/// </summary>

public static async Task<bool> CheckHistoricoRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rHistoricoKey.AsGuid, roHistoricoOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rHistoricoKey.AsGuid, roHistoricoOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckComissionesArrendamientosViewerRole
/// </summary>

public static async Task<bool> CheckComissionesArrendamientosViewerRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rComissionesArrendamientosViewerKey.AsGuid, roComissionesArrendamientosViewerOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rComissionesArrendamientosViewerKey.AsGuid, roComissionesArrendamientosViewerOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckConectaProveedoresAdminRole
/// </summary>

public static async Task<bool> CheckConectaProveedoresAdminRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rConectaProveedoresAdminKey.AsGuid, roConectaProveedoresAdminOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rConectaProveedoresAdminKey.AsGuid, roConectaProveedoresAdminOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckComissionesArrendamientosRole
/// </summary>

public static async Task<bool> CheckComissionesArrendamientosRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rComissionesArrendamientosKey.AsGuid, roComissionesArrendamientosOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rComissionesArrendamientosKey.AsGuid, roComissionesArrendamientosOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckFoliosRole
/// </summary>

public static async Task<bool> CheckFoliosRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rFoliosKey.AsGuid, roFoliosOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rFoliosKey.AsGuid, roFoliosOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckComissionesArrendamientosAdminRole
/// </summary>

public static async Task<bool> CheckComissionesArrendamientosAdminRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rComissionesArrendamientosAdminKey.AsGuid, roComissionesArrendamientosAdminOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rComissionesArrendamientosAdminKey.AsGuid, roComissionesArrendamientosAdminOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckAlmacenRole
/// </summary>

public static async Task<bool> CheckAlmacenRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rAlmacenKey.AsGuid, roAlmacenOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rAlmacenKey.AsGuid, roAlmacenOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckReportesRole
/// </summary>

public static async Task<bool> CheckReportesRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rReportesKey.AsGuid, roReportesOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rReportesKey.AsGuid, roReportesOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckConectaProveedoresAdminViewerRole
/// </summary>

public static async Task<bool> CheckConectaProveedoresAdminViewerRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rConectaProveedoresAdminViewerKey.AsGuid, roConectaProveedoresAdminViewerOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rConectaProveedoresAdminViewerKey.AsGuid, roConectaProveedoresAdminViewerOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckPedidosRole
/// </summary>

public static async Task<bool> CheckPedidosRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rPedidosKey.AsGuid, roPedidosOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rPedidosKey.AsGuid, roPedidosOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckTesoreriaRole
/// </summary>

public static async Task<bool> CheckTesoreriaRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rTesoreriaKey.AsGuid, roTesoreriaOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rTesoreriaKey.AsGuid, roTesoreriaOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckDesviacionesRole
/// </summary>

public static async Task<bool> CheckDesviacionesRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rDesviacionesKey.AsGuid, roDesviacionesOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rDesviacionesKey.AsGuid, roDesviacionesOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckProveedorRole
/// </summary>

public static async Task<bool> CheckProveedorRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rProveedorKey.AsGuid, roProveedorOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rProveedorKey.AsGuid, roProveedorOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckSAPImportOrdersRole
/// </summary>

public static async Task<bool> CheckSAPImportOrdersRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rSAPImportOrdersKey.AsGuid, roSAPImportOrdersOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rSAPImportOrdersKey.AsGuid, roSAPImportOrdersOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckRequisicionesRole
/// </summary>

public static async Task<bool> CheckRequisicionesRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rRequisicionesKey.AsGuid, roRequisicionesOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rRequisicionesKey.AsGuid, roRequisicionesOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: CheckTelcelUserAuditorRole
/// </summary>

public static async Task<bool> CheckTelcelUserAuditorRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole = default;
outParamHasRole = false;

if (string.IsNullOrEmpty(inParamUserId)){
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rTelcelUserAuditorKey.AsGuid, roTelcelUserAuditorOwnerEspaceKey.AsGuid, cancellationToken: cancellationToken);
} else {
outParamHasRole = await GenericExtendedActions.CheckAsync(requestContext, rTelcelUserAuditorKey.AsGuid, roTelcelUserAuditorOwnerEspaceKey.AsGuid,Guid.Parse(inParamUserId), cancellationToken);
}
return outParamHasRole;
}

/// <summary>
/// Action: LogMessage
/// </summary>

public static async Task LogMessage(IRequestContext requestContext,string inParamMessage,string inParamCategory,CancellationToken cancellationToken) {
GenericExtendedActions.LogMessage(requestContext, inParamMessage, inParamCategory);
return;
}

/// <summary>
/// Action: StartUpdateEmail
/// </summary>

public static async Task<ST_f4b6c6eeb122dfa3165aeece838fd077Structure> StartUpdateEmail(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
ST_f4b6c6eeb122dfa3165aeece838fd077Structure outParamStartUpdateEmailResult = default;
outParamStartUpdateEmailResult = new ST_f4b6c6eeb122dfa3165aeece838fd077Structure();

(outParamStartUpdateEmailResult.ssSuccess, outParamStartUpdateEmailResult.ssVerificationCode, outParamStartUpdateEmailResult.ssStartUpdateEmailFailureReason.ssInvalidEmail) = await GenericExtendedActions.StartUpdateEmailAsync(requestContext, inParamEmail, cancellationToken);
return outParamStartUpdateEmailResult;
}

/// <summary>
/// Action: ListIndexOf
/// </summary>

public static async Task<int> ListIndexOf<T>(IRequestContext requestContext,OSList<T> inParamList,Func<T, CancellationToken, ValueTask<bool>> inParamCondition,CancellationToken cancellationToken) {
int outParamPosition = default;
outParamPosition = 0;

outParamPosition = await inParamList.IndexOfAsync(inParamCondition, cancellationToken);return outParamPosition;
}

/// <summary>
/// Action: ListSort
/// </summary>

public static async Task ListSort<T,T2>(IRequestContext requestContext,OSList<T> inParamList,Func<T, CancellationToken, ValueTask<T2>> inParamBy,bool inParamAscending,CancellationToken cancellationToken) {
await inParamList.SortAsync(inParamBy, inParamAscending, cancellationToken);return;
}

/// <summary>
/// Action: StartResetPassword
/// </summary>

public static async Task<ST_7df0b593cd1052614bf3d2f66d1ab2efStructure> StartResetPassword(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
ST_7df0b593cd1052614bf3d2f66d1ab2efStructure outParamStartResetPasswordResult = default;
outParamStartResetPasswordResult = new ST_7df0b593cd1052614bf3d2f66d1ab2efStructure();

(outParamStartResetPasswordResult.ssSuccess, outParamStartResetPasswordResult.ssVerificationCode) = await GenericExtendedActions.StartResetPasswordAsync(requestContext, inParamEmail, cancellationToken);
return outParamStartResetPasswordResult;
}


/// <summary>
/// Action: SetCurrentLocale
/// </summary>

public static async Task SetCurrentLocale(IRequestContext requestContext,string inParamLocale,CancellationToken cancellationToken) {
GenericExtendedActions.SetCurrentLocale( requestContext, inParamLocale);
return;
}

/// <summary>
/// Action: CommitTransaction
/// </summary>

public static async Task CommitTransaction(IRequestContext requestContext,CancellationToken cancellationToken) {
await DatabaseAccess.CommitAllTransactionsAsync(cancellationToken);
return;
}


/// <summary>
/// Action: ListAppend
/// </summary>

public static async Task ListAppend<T>(IRequestContext requestContext,OSList<T> inParamList,T inParamElement,CancellationToken cancellationToken) {
inParamList.Append(inParamElement);return;
}

/// <summary>
/// Action: ListAny
/// </summary>

public static async Task<bool> ListAny<T>(IRequestContext requestContext,OSList<T> inParamList,Func<T, CancellationToken, ValueTask<bool>> inParamCondition,CancellationToken cancellationToken) {
bool outParamResult = default;
outParamResult = false;

outParamResult = await inParamList.AnyAsync(inParamCondition, cancellationToken);return outParamResult;
}

/// <summary>
/// Action: ListClear
/// </summary>

public static async Task ListClear<T>(IRequestContext requestContext,OSList<T> inParamList,CancellationToken cancellationToken) {
inParamList.Clear();return;
}

/// <summary>
/// Action: ListAppendAll
/// </summary>

public static async Task ListAppendAll<T>(IRequestContext requestContext,OSList<T> inParamList,OSList<T> inParamSourceList,CancellationToken cancellationToken) {
inParamList.AppendAll(inParamSourceList);return;
}


/// <summary>
/// Action: UpdateUserProfile
/// </summary>

public static async Task<ST_c57cc6bedbdc9e62046393fa735672cfStructure> UpdateUserProfile(IRequestContext requestContext,ST_da83da85e5348cd2800e701fda6288aaStructure inParamUserUpdateInfo,CancellationToken cancellationToken) {
ST_c57cc6bedbdc9e62046393fa735672cfStructure outParamUpdateUserResult = default;
outParamUpdateUserResult = new ST_c57cc6bedbdc9e62046393fa735672cfStructure();

var updateUserProfileAsyncResult = await GenericExtendedActions.UpdateUserProfileAsync(requestContext, inParamUserUpdateInfo.ssName, inParamUserUpdateInfo.ssPhotoURL, cancellationToken);
outParamUpdateUserResult.ssSuccess = updateUserProfileAsyncResult.Success;
outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidCredentials = updateUserProfileAsyncResult.InvalidCredentials;
outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidName = updateUserProfileAsyncResult.InvalidName;
outParamUpdateUserResult.ssUpdateUserFailureReason.ssInvalidPhotoURL = updateUserProfileAsyncResult.InvalidPhotoUrl;
return outParamUpdateUserResult;
}

}
