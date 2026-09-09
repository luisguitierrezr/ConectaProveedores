namespace ssConectaProveedores;
public class Functions {
/// <summary>
/// Function <code>GetIsCorporativoCxPFromUAR</code> that represents the Service Studio function
///  <code>GetIsCorporativoCxPFromUAR</code> <p> Description: From UserApplicationRole</p>
/// </summary>

public static async Task<bool> ActionGetIsCorporativoCxPFromUAR(IRequestContext requestContext,int inParami_ConceptId,string inParami_GetUserId,CancellationToken cancellationToken) {
bool outParamo_IsFromCorporativo;
outParamo_IsFromCorporativo = await Actions.ActionGetIsCorporativoCxPFromUAR(requestContext,inParami_ConceptId,inParami_GetUserId,cancellationToken);

return outParamo_IsFromCorporativo;
}

/// <summary>
/// Function <code>GetUserRegionId</code> that represents the Service Studio function
///  <code>GetUserRegionId</code> <p> Description: Get logged User Region id</p>
/// </summary>

public static async Task<long> ActionGetUserRegionId(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_RegionId;
outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,inParami_GetUserId,cancellationToken);

return outParamo_RegionId;
}

/// <summary>
/// Function <code>GetUserDepartmentName</code> that represents the Service Studio function
///  <code>GetUserDepartmentName</code> <p> Description: Get logged User Department name</p>
/// </summary>

public static async Task<string> ActionGetUserDepartmentName(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
string outParamo_Department;
outParamo_Department = await Actions.ActionGetUserDepartmentName(requestContext,inParami_GetUserId,cancellationToken);

return outParamo_Department;
}

/// <summary>
/// Function <code>EncodeSortForSQL</code> that represents the Service Studio function
///  <code>EncodeSortForSQL</code> <p> Description: Encode Sort For SQL.</p>
/// </summary>

public static async Task<string> ActionEncodeSortForSQL(IRequestContext requestContext,string inParamSortForAggregate,CancellationToken cancellationToken) {
string outParamSortForSQL;
outParamSortForSQL = await Actions.ActionEncodeSortForSQL(requestContext,inParamSortForAggregate,cancellationToken);

return outParamSortForSQL;
}

/// <summary>
/// Function <code>GetCanUploadInvoicesByRequisitionId</code> that represents the Service Studio
///  function <code>GetCanUploadInvoicesByRequisitionId</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ActionGetCanUploadInvoicesByRequisitionId(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
bool outParami_CanUpload;
outParami_CanUpload = await Actions.ActionGetCanUploadInvoicesByRequisitionId(requestContext,inParami_RequisitionId,cancellationToken);

return outParami_CanUpload;
}

/// <summary>
/// Function <code>ReadOrderNotes</code> that represents the Service Studio function
///  <code>ReadOrderNotes</code> <p> Description: </p>
/// </summary>

public static async Task<string> ActionReadOrderNotes(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
string outParamNotes;
outParamNotes = await Actions.ActionReadOrderNotes(requestContext,inParamOrderNumber,cancellationToken);

return outParamNotes;
}

/// <summary>
/// Function <code>GetRegionCodeById</code> that represents the Service Studio function
///  <code>GetRegionCodeById</code> <p> Description: </p>
/// </summary>

public static async Task<string> ActionGetRegionCodeById(IRequestContext requestContext,long inParamRegionId,CancellationToken cancellationToken) {
string outParamCode;
outParamCode = await Actions.ActionGetRegionCodeById(requestContext,inParamRegionId,cancellationToken);

return outParamCode;
}

/// <summary>
/// Function <code>GetUserApplicationRoleCyA</code> that represents the Service Studio function
///  <code>GetUserApplicationRoleCyA</code> <p> Description: Action to get ApplicationRoleId from logge
/// d user</p>
/// </summary>

public static async Task<long> ActionGetUserApplicationRoleCyA(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamo_ApplicationRoleId;
outParamo_ApplicationRoleId = await Actions.ActionGetUserApplicationRoleCyA(requestContext,cancellationToken);

return outParamo_ApplicationRoleId;
}

/// <summary>
/// Function <code>GetUserTelcelDirectionId</code> that represents the Service Studio function
///  <code>GetUserTelcelDirectionId</code> <p> Description: Action to get Telcel Direccion Id fro
/// m logged user</p>
/// </summary>

public static async Task<long> ActionGetUserTelcelDirectionId(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_TelcelDirectionId;
outParamo_TelcelDirectionId = await Actions.ActionGetUserTelcelDirectionId(requestContext,inParami_GetUserId,cancellationToken);

return outParamo_TelcelDirectionId;
}

/// <summary>
/// Function <code>GetUserEntraRoleName</code> that represents the Service Studio function
///  <code>GetUserEntraRoleName</code> <p> Description: Get Entra Role name from user.</p>
/// </summary>

public static async Task<string> ActionGetUserEntraRoleName(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
string outParamo_EntraRoleName;
outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,inParami_GetUserId,cancellationToken);

return outParamo_EntraRoleName;
}

/// <summary>
/// Function <code>GetUserDepartmentId</code> that represents the Service Studio function
///  <code>GetUserDepartmentId</code> <p> Description: Get logged User Department id</p>
/// </summary>

public static async Task<long> ActionGetUserDepartmentId(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_DepartmentId;
outParamo_DepartmentId = await Actions.ActionGetUserDepartmentId(requestContext,inParami_GetUserId,cancellationToken);

return outParamo_DepartmentId;
}

/// <summary>
/// Function <code>GetUserEntraRoleNameById</code> that represents the Service Studio function
///  <code>GetUserEntraRoleNameById</code> <p> Description: Get Entra Role name from user.</p>
/// </summary>

public static async Task<string> ActionGetUserEntraRoleNameById(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
string outParamo_EntraRoleName;
outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleNameById(requestContext,inParami_UserId,cancellationToken);

return outParamo_EntraRoleName;
}

/// <summary>
/// Function <code>GetRegionIdByCode</code> that represents the Service Studio function
///  <code>GetRegionIdByCode</code> <p> Description: </p>
/// </summary>

public static async Task<long> ActionGetRegionIdByCode(IRequestContext requestContext,string inParamRegionCode,CancellationToken cancellationToken) {
long outParamId;
outParamId = await Actions.ActionGetRegionIdByCode(requestContext,inParamRegionCode,cancellationToken);

return outParamId;
}

/// <summary>
/// Function <code>GetCanUploadInvoices</code> that represents the Service Studio function
///  <code>GetCanUploadInvoices</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ActionGetCanUploadInvoices(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParami_CanUpload;
outParami_CanUpload = await Actions.ActionGetCanUploadInvoices(requestContext,cancellationToken);

return outParami_CanUpload;
}

/// <summary>
/// Function <code>GetIsCorporativo</code> that represents the Service Studio function
///  <code>GetIsCorporativo</code> <p> Description: From Generic</p>
/// </summary>

public static async Task<bool> ActionGetIsCorporativo(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsFromCorporativo;
outParamo_IsFromCorporativo = await Actions.ActionGetIsCorporativo(requestContext,cancellationToken);

return outParamo_IsFromCorporativo;
}

/// <summary>
/// Function <code>GetIsForSpecialWorkflow</code> that represents the Service Studio function
///  <code>GetIsForSpecialWorkflow</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ActionGetIsForSpecialWorkflow(IRequestContext requestContext,string inParamUserId,bool inParamIsDonation,string inParamProcessTypeCode,CancellationToken cancellationToken) {
bool outParamIsForSpecialWorkflow;
outParamIsForSpecialWorkflow = await Actions.ActionGetIsForSpecialWorkflow(requestContext,inParamUserId,inParamIsDonation,inParamProcessTypeCode,cancellationToken);

return outParamIsForSpecialWorkflow;
}

/// <summary>
/// Function <code>GetIsUserCxP</code> that represents the Service Studio function
///  <code>GetIsUserCxP</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ActionGetIsUserCxP(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_Value;
outParamo_Value = await Actions.ActionGetIsUserCxP(requestContext,cancellationToken);

return outParamo_Value;
}

/// <summary>
/// Function <code>CheckUserSession</code> that represents the Service Studio function
///  <code>CheckUserSession</code> <p> Description: Use for validate Guid Sessions.</p>
/// </summary>

public static async Task<bool> ActionCheckUserSession(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsValidSession;
outParamIsValidSession = await Actions.ActionCheckUserSession(requestContext,cancellationToken);

return outParamIsValidSession;
}

/// <summary>
/// Function <code>GetPaymentTermSpecial</code> that represents the Service Studio function
///  <code>GetPaymentTermSpecial</code> <p> Description: </p>
/// </summary>

public static async Task<long> ActionGetPaymentTermSpecial(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamId;
outParamId = await Actions.ActionGetPaymentTermSpecial(requestContext,cancellationToken);

return outParamId;
}

/// <summary>
/// Function <code>DateValidate</code> that represents the Service Studio function
///  <code>DateValidate</code> <p> Description: </p>
/// </summary>

public static async Task<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure> ActionDateValidate(IRequestContext requestContext,string inParamInputText,string inParamExpectedFormat,bool inParamIsMandatory,CancellationToken cancellationToken) {
ST_360c3a66fc9951d9de7870c1f87f9bf6Structure outParamResult;
outParamResult = await Actions.ActionDateValidate(requestContext,inParamInputText,inParamExpectedFormat,inParamIsMandatory,cancellationToken);

return outParamResult;
}

/// <summary>
/// Function <code>GetUserRole</code> that represents the Service Studio function
///  <code>GetUserRole</code> <p> Description: </p>
/// </summary>

public static async Task<long> ActionGetUserRole(IRequestContext requestContext,string inParami_UserId,int inParami_ConceptId,bool inParami_AreaUsuaria,bool inParami_AreaCxP,CancellationToken cancellationToken) {
long outParamo_ApplicationRoleId;
outParamo_ApplicationRoleId = await Actions.ActionGetUserRole(requestContext,inParami_UserId,inParami_ConceptId,inParami_AreaUsuaria,inParami_AreaCxP,cancellationToken);

return outParamo_ApplicationRoleId;
}

/// <summary>
/// Function <code>GetIsShowAssignFirstApproverPopup</code> that represents the Service Studio function
///  <code>GetIsShowAssignFirstApproverPopup</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ActionGetIsShowAssignFirstApproverPopup(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamIsShow;
outParamIsShow = await Actions.ActionGetIsShowAssignFirstApproverPopup(requestContext,inParamUserId,cancellationToken);

return outParamIsShow;
}

/// <summary>
/// Function <code>ShowIsDonationSwitch</code> that represents the Service Studio function
///  <code>ShowIsDonationSwitch</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ActionShowIsDonationSwitch(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_ShowSwitch;
outParamo_ShowSwitch = await Actions.ActionShowIsDonationSwitch(requestContext,cancellationToken);

return outParamo_ShowSwitch;
}

/// <summary>
/// Function <code>NotificationCategory</code> that represents the Service Studio function
///  <code>NotificationCategory</code> <p> Description: </p>
/// </summary>

public static async Task<string> ActionNotificationCategory(IRequestContext requestContext,int inParamCategory,CancellationToken cancellationToken) {
string outParamOutput;
outParamOutput = await Actions.ActionNotificationCategory(requestContext,inParamCategory,cancellationToken);

return outParamOutput;
}

/// <summary>
/// Function <code>UTCToLocalTime</code> that represents the Service Studio function
///  <code>UTCToLocalTime</code> <p> Description: </p>
/// </summary>

public static async Task<DateTime> ActionUTCToLocalTime(IRequestContext requestContext,DateTime inParamDateTimeUTC,int inParamOffset,CancellationToken cancellationToken) {
DateTime outParamDateTimeLocal;
outParamDateTimeLocal = await Actions.ActionUTCToLocalTime(requestContext,inParamDateTimeUTC,inParamOffset,cancellationToken);

return outParamDateTimeLocal;
}

/// <summary>
/// Function <code>GetNextMonday</code> that represents the Service Studio function
///  <code>GetNextMonday</code> <p> Description: </p>
/// </summary>

public static async Task<int> ActionGetNextMonday(IRequestContext requestContext,DateTime inParamBaseDateTime,CancellationToken cancellationToken) {
int outParamDays;
outParamDays = await Actions.ActionGetNextMonday(requestContext,inParamBaseDateTime,cancellationToken);

return outParamDays;
}

/// <summary>
/// Function <code>GetUserSupplier</code> that represents the Service Studio function
///  <code>GetUserSupplier</code> <p> Description: Action to get SupplierId from current user</p>
/// </summary>

public static async Task<long> ActionGetUserSupplier(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_SupplierId;
outParamo_SupplierId = await Actions.ActionGetUserSupplier(requestContext,inParami_GetUserId,cancellationToken);

return outParamo_SupplierId;
}

/// <summary>
/// Function <code>GetIsCxP_RequestErrorDistribution</code> that represents the Service Studio function
///  <code>GetIsCxP_RequestErrorDistribution</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ActionGetIsCxP_RequestErrorDistribution(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsAllowed;
outParamo_IsAllowed = await Actions.ActionGetIsCxP_RequestErrorDistribution(requestContext,cancellationToken);

return outParamo_IsAllowed;
}

/// <summary>
/// Function <code>GetMR09RegionId</code> that represents the Service Studio function
///  <code>GetMR09RegionId</code> <p> Description: </p>
/// </summary>

public static async Task<long> ActionGetMR09RegionId(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamRegionId;
outParamRegionId = await Actions.ActionGetMR09RegionId(requestContext,cancellationToken);

return outParamRegionId;
}

/// <summary>
/// Function <code>OrderNotes_Append</code> that represents the Service Studio function
///  <code>OrderNotes_Append</code> <p> Description: </p>
/// </summary>

public static async Task<string> ActionOrderNotes_Append(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
string outParamNotes;
outParamNotes = await Actions.ActionOrderNotes_Append(requestContext,inParamOrderNumber,cancellationToken);

return outParamNotes;
}

/// <summary>
/// Function <code>GetUserEntraRoleId</code> that represents the Service Studio function
///  <code>GetUserEntraRoleId</code> <p> Description: Get Entra Role id from user.</p>
/// </summary>

public static async Task<long> ActionGetUserEntraRoleId(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
long outParamo_EntraRoleId;
outParamo_EntraRoleId = await Actions.ActionGetUserEntraRoleId(requestContext,inParami_UserId,cancellationToken);

return outParamo_EntraRoleId;
}

/// <summary>
/// Function <code>GetMR00RegionId</code> that represents the Service Studio function
///  <code>GetMR00RegionId</code> <p> Description: </p>
/// </summary>

public static async Task<long> ActionGetMR00RegionId(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamRegionId;
outParamRegionId = await Actions.ActionGetMR00RegionId(requestContext,cancellationToken);

return outParamRegionId;
}

/// <summary>
/// Function <code>BinaryToBase64</code> that represents the Service Studio function
///  <code>BinaryToBase64</code> <p> Description: Converts binary data to Base64 text.</p>
/// </summary>

public static async Task<string> ActionBinaryToBase64(IRequestContext requestContext,byte[] inParamBinaryData,CancellationToken cancellationToken) {
string outParamBase64;
outParamBase64 = await Actions.ActionBinaryToBase64(requestContext,inParamBinaryData,cancellationToken);

return outParamBase64;
}

/// <summary>
/// Function <code>BinaryDataSize</code> that represents the Service Studio function
///  <code>BinaryDataSize</code> <p> Description: Returns the size in bytes of binary data content.</p>
/// </summary>

public static async Task<int> ActionBinaryDataSize(IRequestContext requestContext,byte[] inParamBinaryData,CancellationToken cancellationToken) {
int outParamSize;
outParamSize = await Actions.ActionBinaryDataSize(requestContext,inParamBinaryData,cancellationToken);

return outParamSize;
}

/// <summary>
/// Function <code>Base64ToBinary</code> that represents the Service Studio function
///  <code>Base64ToBinary</code> <p> Description: Converts Base64 text into binary data.</p>
/// </summary>

public static async Task<byte[]> ActionBase64ToBinary(IRequestContext requestContext,string inParamBase64,CancellationToken cancellationToken) {
byte[] outParamBinary;
outParamBinary = await Actions.ActionBase64ToBinary(requestContext,inParamBase64,cancellationToken);

return outParamBinary;
}

/// <summary>
/// Function <code>TextToBinaryData</code> that represents the Service Studio function
///  <code>TextToBinaryData</code> <p> Description: Converts a text to binary data.</p>
/// </summary>

public static async Task<byte[]> ActionTextToBinaryData(IRequestContext requestContext,string inParamText,string inParamEncoding,CancellationToken cancellationToken) {
byte[] outParamBinaryData;
outParamBinaryData = await Actions.ActionTextToBinaryData(requestContext,inParamText,inParamEncoding,cancellationToken);

return outParamBinaryData;
}

/// <summary>
/// Function <code>BinaryDataToText</code> that represents the Service Studio function
///  <code>BinaryDataToText</code> <p> Description: Converts the given binary data to text using th
/// e given encoding.</p>
/// </summary>

public static async Task<string> ActionBinaryDataToText(IRequestContext requestContext,byte[] inParamBinaryData,string inParamEncoding,CancellationToken cancellationToken) {
string outParamText;
outParamText = await Actions.ActionBinaryDataToText(requestContext,inParamBinaryData,inParamEncoding,cancellationToken);

return outParamText;
}

/// <summary>
/// Function <code>CheckUserSessionDONOTUSE</code> that represents the Service Studio function
///  <code>CheckUserSessionDONOTUSE</code> <p> Description: CheckUserSession</p>
/// </summary>

public static async Task<bool> ActionCheckUserSessionDONOTUSE(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsValidSession;
outParamIsValidSession = await Actions.ActionCheckUserSessionDONOTUSE(requestContext,cancellationToken);

return outParamIsValidSession;
}

/// <summary>
/// Function <code>Regex_Replace</code> that represents the Service Studio function
///  <code>Regex_Replace</code> <p> Description: Replaces all occurrences of a specified regula
/// r expression pattern with a new string.</p>
/// </summary>

public static async Task<string> ActionRegex_Replace(IRequestContext requestContext,string inParamText,string inParamRegexPattern,string inParamNewString,bool inParamIgnoreCase,bool inParamMultiLine,bool inParamSingleLine,CancellationToken cancellationToken) {
string outParamResult;
outParamResult = await Actions.ActionRegex_Replace(requestContext,inParamText,inParamRegexPattern,inParamNewString,inParamIgnoreCase,inParamMultiLine,inParamSingleLine,cancellationToken);

return outParamResult;
}

/// <summary>
/// Function <code>String_Split</code> that represents the Service Studio function
///  <code>String_Split</code> <p> Description: Splits a string into individual elements delimited b
/// y any of the characters specified.</p>
/// </summary>

public static async Task<RLTextRecordList> ActionString_Split(IRequestContext requestContext,string inParamText,string inParamDelimiters,CancellationToken cancellationToken) {
RLTextRecordList outParamList;
outParamList = await Actions.ActionString_Split(requestContext,inParamText,inParamDelimiters,cancellationToken);

return outParamList;
}

/// <summary>
/// Function <code>String_Join</code> that represents the Service Studio function
///  <code>String_Join</code> <p> Description: Concatenates all the strings in a list into a singl
/// e string. In the resulting string, the individual elements are separated by the defined
///  separator.</p>
/// </summary>

public static async Task<string> ActionString_Join(IRequestContext requestContext,RLTextRecordList inParamList,string inParamSeparator,CancellationToken cancellationToken) {
string outParamText;
outParamText = await Actions.ActionString_Join(requestContext,inParamList,inParamSeparator,cancellationToken);

return outParamText;
}

/// <summary>
/// Function <code>GetOrderDistributionConfig</code> that represents the Service Studio function
///  <code>GetOrderDistributionConfig</code> <p> Description: </p>
/// </summary>

public static async Task<RC_9fc59bda41db740ae87f91f135d24811> ssGetOrderDistributionConfig(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_9fc59bda41db740ae87f91f135d24811 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderDistributionConfig(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioSAPData</code> that represents the Service Studio function
///  <code>GetFolioSAPData</code> <p> Description: </p>
/// </summary>

public static async Task<RC_7fd286c48691331601c5027580ae5af5> ssGetFolioSAPData(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7fd286c48691331601c5027580ae5af5 outParamRecord;
outParamRecord = await ExtendedActions.GetFolioSAPData(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderStatus</code> that represents the Service Studio function
///  <code>GetOrderStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_919d72dc5292e812597af4fac0a808e4> ssGetOrderStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_919d72dc5292e812597af4fac0a808e4 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalApprovalLevel</code> that represents the Service Studio function
///  <code>GetProposalApprovalLevel</code> <p> Description: </p>
/// </summary>

public static async Task<RC_55929a788bcf79c72354fc49160acc0c> ssGetProposalApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_55929a788bcf79c72354fc49160acc0c outParamRecord;
outParamRecord = await ExtendedActions.GetProposalApprovalLevel(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioStatus</code> that represents the Service Studio function
///  <code>GetFolioStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c75df7b2e7c6e74a3a45dda7bd7b93e2> ssGetFolioStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_c75df7b2e7c6e74a3a45dda7bd7b93e2 outParamRecord;
outParamRecord = await ExtendedActions.GetFolioStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderItemEntries</code> that represents the Service Studio function
///  <code>GetOrderItemEntries</code> <p> Description: </p>
/// </summary>

public static async Task<RC_27f9dcc2de814d2d04d4d18f5b8c424b> ssGetOrderItemEntries(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_27f9dcc2de814d2d04d4d18f5b8c424b outParamRecord;
outParamRecord = await ExtendedActions.GetOrderItemEntries(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioApproval</code> that represents the Service Studio function
///  <code>GetFolioApproval</code> <p> Description: </p>
/// </summary>

public static async Task<RC_8f1c2b4902cba2d0c0cbb5fb1e978b50> ssGetFolioApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8f1c2b4902cba2d0c0cbb5fb1e978b50 outParamRecord;
outParamRecord = await ExtendedActions.GetFolioApproval(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetColumnSettings</code> that represents the Service Studio function
///  <code>GetColumnSettings</code> <p> Description: </p>
/// </summary>

public static async Task<RC_25c6d4ad26c50e9400baa0d709166594> ssGetColumnSettings(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_25c6d4ad26c50e9400baa0d709166594 outParamRecord;
outParamRecord = await ExtendedActions.GetColumnSettings(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoice</code> that represents the Service Studio function
///  <code>GetInvoice</code> <p> Description: </p>
/// </summary>

public static async Task<RC_04c5986b32c7822f033c933cf71b96bd> ssGetInvoice(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_04c5986b32c7822f033c933cf71b96bd outParamRecord;
outParamRecord = await ExtendedActions.GetInvoice(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderMainItem</code> that represents the Service Studio function
///  <code>GetOrderMainItem</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c4cc207f9017de4e013fabcf1e8ebeaf> ssGetOrderMainItem(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c4cc207f9017de4e013fabcf1e8ebeaf outParamRecord;
outParamRecord = await ExtendedActions.GetOrderMainItem(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedRelations</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedRelations</code> <p> Description: </p>
/// </summary>

public static async Task<RC_759c053ad9cffaec26c59da8e40042d4> ssGetInvoiceExtendedRelations(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_759c053ad9cffaec26c59da8e40042d4 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedRelations(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalLogs</code> that represents the Service Studio function
///  <code>GetProposalLogs</code> <p> Description: </p>
/// </summary>

public static async Task<RC_42d297db5356ec5acb8465e0977849c0> ssGetProposalLogs(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_42d297db5356ec5acb8465e0977849c0 outParamRecord;
outParamRecord = await ExtendedActions.GetProposalLogs(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderRetentionType</code> that represents the Service Studio function
///  <code>GetOrderRetentionType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_59361fc2fe27e83d1af47e8e07392a42> ssGetOrderRetentionType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_59361fc2fe27e83d1af47e8e07392a42 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderRetentionType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceApproval</code> that represents the Service Studio function
///  <code>GetInvoiceApproval</code> <p> Description: </p>
/// </summary>

public static async Task<RC_8ecd20e9afb5cd14c3f1aea1a6262374> ssGetInvoiceApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8ecd20e9afb5cd14c3f1aea1a6262374 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceApproval(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedTax</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedTax</code> <p> Description: </p>
/// </summary>

public static async Task<RC_965912af30c7fbb7316f17bf8e331782> ssGetInvoiceExtendedTax(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_965912af30c7fbb7316f17bf8e331782 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedTax(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionContractFile</code> that represents the Service Studio function
///  <code>GetRequisitionContractFile</code> <p> Description: </p>
/// </summary>

public static async Task<RC_471ec64149613ec0a9f3525fc2d9e11c> ssGetRequisitionContractFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_471ec64149613ec0a9f3525fc2d9e11c outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionContractFile(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderRequestFileApproval</code> that represents the Service Studio function
///  <code>GetOrderRequestFileApproval</code> <p> Description: </p>
/// </summary>

public static async Task<RC_64c70b8a3f72d1283f18a3da8f8eb3d5> ssGetOrderRequestFileApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_64c70b8a3f72d1283f18a3da8f8eb3d5 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderRequestFileApproval(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposal</code> that represents the Service Studio function
///  <code>GetProposal</code> <p> Description: </p>
/// </summary>

public static async Task<RC_91adc4f46f8a0f51cacc4bc718d2ea35> ssGetProposal(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_91adc4f46f8a0f51cacc4bc718d2ea35 outParamRecord;
outParamRecord = await ExtendedActions.GetProposal(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrdersImportRequest</code> that represents the Service Studio function
///  <code>GetOrdersImportRequest</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2407b5abb2cbfeaeaa8da6cdea4ccf12> ssGetOrdersImportRequest(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2407b5abb2cbfeaeaa8da6cdea4ccf12 outParamRecord;
outParamRecord = await ExtendedActions.GetOrdersImportRequest(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderRequestFileApprovalLevel</code> that represents the Service Studio function
///  <code>GetOrderRequestFileApprovalLevel</code> <p> Description: </p>
/// </summary>

public static async Task<RC_daa6040aa65b55c2574e6a4e976766ce> ssGetOrderRequestFileApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_daa6040aa65b55c2574e6a4e976766ce outParamRecord;
outParamRecord = await ExtendedActions.GetOrderRequestFileApprovalLevel(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetContractFileType</code> that represents the Service Studio function
///  <code>GetContractFileType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_6d6e93fa5edbd2aad29e8f15b3f71aeb> ssGetContractFileType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_6d6e93fa5edbd2aad29e8f15b3f71aeb outParamRecord;
outParamRecord = await ExtendedActions.GetContractFileType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFileExtended</code> that represents the Service Studio function
///  <code>GetFileExtended</code> <p> Description: </p>
/// </summary>

public static async Task<RC_6e3ea28d2c552bc2cc129f42297e5982> ssGetFileExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_6e3ea28d2c552bc2cc129f42297e5982 outParamRecord;
outParamRecord = await ExtendedActions.GetFileExtended(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceStatus</code> that represents the Service Studio function
///  <code>GetInvoiceStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_6edb17c5bf63452ff4ac24d41991a940> ssGetInvoiceStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_6edb17c5bf63452ff4ac24d41991a940 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolio</code> that represents the Service Studio function <code>GetFolio</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_cfeb2cf80ab683e7d9a9b5d02d9c9526> ssGetFolio(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cfeb2cf80ab683e7d9a9b5d02d9c9526 outParamRecord;
outParamRecord = await ExtendedActions.GetFolio(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionLogs</code> that represents the Service Studio function
///  <code>GetRequisitionLogs</code> <p> Description: </p>
/// </summary>

public static async Task<RC_da02352775767d2a57ea4cd35cd18496> ssGetRequisitionLogs(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_da02352775767d2a57ea4cd35cd18496 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionLogs(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceFile</code> that represents the Service Studio function
///  <code>GetInvoiceFile</code> <p> Description: </p>
/// </summary>

public static async Task<RC_18990af86f7169e92b712b468e13b947> ssGetInvoiceFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_18990af86f7169e92b712b468e13b947 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceFile(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionStatusHistory</code> that represents the Service Studio function
///  <code>GetRequisitionStatusHistory</code> <p> Description: </p>
/// </summary>

public static async Task<RC_aa9fab59faf7c7de355dae43478ba7e5> ssGetRequisitionStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aa9fab59faf7c7de355dae43478ba7e5 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionStatusHistory(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetReassignments</code> that represents the Service Studio function
///  <code>GetReassignments</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c9394e1c31772209550f46c7f600d6ee> ssGetReassignments(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c9394e1c31772209550f46c7f600d6ee outParamRecord;
outParamRecord = await ExtendedActions.GetReassignments(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetLogsAccounting</code> that represents the Service Studio function
///  <code>GetLogsAccounting</code> <p> Description: </p>
/// </summary>

public static async Task<RC_404aa878a81887880a35de683904d643> ssGetLogsAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_404aa878a81887880a35de683904d643 outParamRecord;
outParamRecord = await ExtendedActions.GetLogsAccounting(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedForeigner</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedForeigner</code> <p> Description: </p>
/// </summary>

public static async Task<RC_decbed55750bb4030b04e46c0306e56b> ssGetInvoiceExtendedForeigner(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_decbed55750bb4030b04e46c0306e56b outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedForeigner(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioExtended</code> that represents the Service Studio function
///  <code>GetFolioExtended</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ad92b2c217228db10c71baf90a615ea5> ssGetFolioExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ad92b2c217228db10c71baf90a615ea5 outParamRecord;
outParamRecord = await ExtendedActions.GetFolioExtended(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioRegionSeq</code> that represents the Service Studio function
///  <code>GetFolioRegionSeq</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ba02c963eabdf75d57d498152c3db2fa> ssGetFolioRegionSeq(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ba02c963eabdf75d57d498152c3db2fa outParamRecord;
outParamRecord = await ExtendedActions.GetFolioRegionSeq(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalStatusHistory</code> that represents the Service Studio function
///  <code>GetProposalStatusHistory</code> <p> Description: </p>
/// </summary>

public static async Task<RC_e6d370b8387bb43d90dc90a766ecdf20> ssGetProposalStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e6d370b8387bb43d90dc90a766ecdf20 outParamRecord;
outParamRecord = await ExtendedActions.GetProposalStatusHistory(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionAccConcepts</code> that represents the Service Studio function
///  <code>GetRequisitionAccConcepts</code> <p> Description: </p>
/// </summary>

public static async Task<RC_e33b49261cecfe02249fd0f5f57f5dbc> ssGetRequisitionAccConcepts(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e33b49261cecfe02249fd0f5f57f5dbc outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionAccConcepts(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceComment</code> that represents the Service Studio function
///  <code>GetInvoiceComment</code> <p> Description: </p>
/// </summary>

public static async Task<RC_85ff0b93155717e6346b97d39d3b0222> ssGetInvoiceComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_85ff0b93155717e6346b97d39d3b0222 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceComment(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalType</code> that represents the Service Studio function
///  <code>GetProposalType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d6a77c530b0e1f2687ee6b3214e237ef> ssGetProposalType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_d6a77c530b0e1f2687ee6b3214e237ef outParamRecord;
outParamRecord = await ExtendedActions.GetProposalType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderApproval</code> that represents the Service Studio function
///  <code>GetOrderApproval</code> <p> Description: </p>
/// </summary>

public static async Task<RC_51831f8bbf408689b196be5dba3a91ea> ssGetOrderApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_51831f8bbf408689b196be5dba3a91ea outParamRecord;
outParamRecord = await ExtendedActions.GetOrderApproval(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderMainItemStatus</code> that represents the Service Studio function
///  <code>GetOrderMainItemStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_eadaf2f9446fb019e39088d303bee2ef> ssGetOrderMainItemStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_eadaf2f9446fb019e39088d303bee2ef outParamRecord;
outParamRecord = await ExtendedActions.GetOrderMainItemStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderComment</code> that represents the Service Studio function
///  <code>GetOrderComment</code> <p> Description: </p>
/// </summary>

public static async Task<RC_cd61721ee82121e78e4055ba4deb1fa6> ssGetOrderComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cd61721ee82121e78e4055ba4deb1fa6 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderComment(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioApprovalLevel</code> that represents the Service Studio function
///  <code>GetFolioApprovalLevel</code> <p> Description: </p>
/// </summary>

public static async Task<RC_0be8bae4cc285c0288822b663818cb6c> ssGetFolioApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_0be8bae4cc285c0288822b663818cb6c outParamRecord;
outParamRecord = await ExtendedActions.GetFolioApprovalLevel(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceAccountingProcessResponse</code> that represents the Service Studio
///  function <code>GetInvoiceAccountingProcessResponse</code> <p> Description: </p>
/// </summary>

public static async Task<RC_8d2c7f494e763d54feb138104c341adb> ssGetInvoiceAccountingProcessResponse(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_8d2c7f494e763d54feb138104c341adb outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceAccountingProcessResponse(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderCostCenter</code> that represents the Service Studio function
///  <code>GetOrderCostCenter</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5460c4bf9b3f96576a08e29ae969cbe7> ssGetOrderCostCenter(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5460c4bf9b3f96576a08e29ae969cbe7 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderCostCenter(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetCommentType</code> that represents the Service Studio function
///  <code>GetCommentType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2c1b3c205a8ef6cb9caa168a859ca828> ssGetCommentType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_2c1b3c205a8ef6cb9caa168a859ca828 outParamRecord;
outParamRecord = await ExtendedActions.GetCommentType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderAccConcepts</code> that represents the Service Studio function
///  <code>GetOrderAccConcepts</code> <p> Description: </p>
/// </summary>

public static async Task<RC_dc9a6819825fee88eba01192ae9b1890> ssGetOrderAccConcepts(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_dc9a6819825fee88eba01192ae9b1890 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderAccConcepts(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApprovalStatus</code> that represents the Service Studio function
///  <code>GetApprovalStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5e94710ba0de64845af2f9d1cc088302> ssGetApprovalStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_5e94710ba0de64845af2f9d1cc088302 outParamRecord;
outParamRecord = await ExtendedActions.GetApprovalStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedReceiver</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedReceiver</code> <p> Description: </p>
/// </summary>

public static async Task<RC_466f18b870f78193989904128fc2d15c> ssGetInvoiceExtendedReceiver(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_466f18b870f78193989904128fc2d15c outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedReceiver(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceTaxType</code> that represents the Service Studio function
///  <code>GetInvoiceTaxType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_68f99e3ed8896e3b241abe92cbb6c9b0> ssGetInvoiceTaxType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_68f99e3ed8896e3b241abe92cbb6c9b0 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceTaxType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceLog</code> that represents the Service Studio function
///  <code>GetInvoiceLog</code> <p> Description: </p>
/// </summary>

public static async Task<RC_deaf8695933be1bd95c8a487c5df0dc4> ssGetInvoiceLog(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_deaf8695933be1bd95c8a487c5df0dc4 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceLog(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioLog</code> that represents the Service Studio function
///  <code>GetFolioLog</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d1c5afe2a83250ad8e254ef5d2a29b01> ssGetFolioLog(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d1c5afe2a83250ad8e254ef5d2a29b01 outParamRecord;
outParamRecord = await ExtendedActions.GetFolioLog(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioComment</code> that represents the Service Studio function
///  <code>GetFolioComment</code> <p> Description: </p>
/// </summary>

public static async Task<RC_bd4c69fd286a3fa1bae388a3d68ac007> ssGetFolioComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bd4c69fd286a3fa1bae388a3d68ac007 outParamRecord;
outParamRecord = await ExtendedActions.GetFolioComment(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetContractStatus</code> that represents the Service Studio function
///  <code>GetContractStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_64894cdb6c46279b2d012a58a7771333> ssGetContractStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_64894cdb6c46279b2d012a58a7771333 outParamRecord;
outParamRecord = await ExtendedActions.GetContractStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetLogsAccountingSubject</code> that represents the Service Studio function
///  <code>GetLogsAccountingSubject</code> <p> Description: </p>
/// </summary>

public static async Task<RC_780ecab424bd911724518df74dd2298a> ssGetLogsAccountingSubject(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_780ecab424bd911724518df74dd2298a outParamRecord;
outParamRecord = await ExtendedActions.GetLogsAccountingSubject(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalStatus</code> that represents the Service Studio function
///  <code>GetProposalStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5627f7a3ec063e602863ee6b4dd816a2> ssGetProposalStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_5627f7a3ec063e602863ee6b4dd816a2 outParamRecord;
outParamRecord = await ExtendedActions.GetProposalStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderRequestFile</code> that represents the Service Studio function
///  <code>GetOrderRequestFile</code> <p> Description: </p>
/// </summary>

public static async Task<RC_73d8126c722e2b4dd662dab2bf1a72d1> ssGetOrderRequestFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_73d8126c722e2b4dd662dab2bf1a72d1 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderRequestFile(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedCartaPorte</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedCartaPorte</code> <p> Description: </p>
/// </summary>

public static async Task<RC_79b8311427bcbe4ce4ecbe042bf03773> ssGetInvoiceExtendedCartaPorte(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_79b8311427bcbe4ce4ecbe042bf03773 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedCartaPorte(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioFiles</code> that represents the Service Studio function
///  <code>GetFolioFiles</code> <p> Description: </p>
/// </summary>

public static async Task<RC_28fdb7a8aef891dc921c5fe34393a569> ssGetFolioFiles(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_28fdb7a8aef891dc921c5fe34393a569 outParamRecord;
outParamRecord = await ExtendedActions.GetFolioFiles(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceStatusHistory</code> that represents the Service Studio function
///  <code>GetInvoiceStatusHistory</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a2551032116fa7acb5fb1896fd9acdf2> ssGetInvoiceStatusHistory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a2551032116fa7acb5fb1896fd9acdf2 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceStatusHistory(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisition</code> that represents the Service Studio function
///  <code>GetRequisition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_bb81744faa58ae73e7cd8db74cb32155> ssGetRequisition(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bb81744faa58ae73e7cd8db74cb32155 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionVersion</code> that represents the Service Studio function
///  <code>GetRequisitionVersion</code> <p> Description: </p>
/// </summary>

public static async Task<RC_47cc380fa539ce90830b02515458ecd2> ssGetRequisitionVersion(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_47cc380fa539ce90830b02515458ecd2 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionVersion(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionApprovalLevel</code> that represents the Service Studio function
///  <code>GetRequisitionApprovalLevel</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5404698ef74632f0bc59763509d95177> ssGetRequisitionApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5404698ef74632f0bc59763509d95177 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionApprovalLevel(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioItems</code> that represents the Service Studio function
///  <code>GetFolioItems</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f861f2b559524d098e0981156af9b7ab> ssGetFolioItems(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f861f2b559524d098e0981156af9b7ab outParamRecord;
outParamRecord = await ExtendedActions.GetFolioItems(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderContractFile</code> that represents the Service Studio function
///  <code>GetOrderContractFile</code> <p> Description: </p>
/// </summary>

public static async Task<RC_bdb8cd2e0da3eae2f170942895f2a3ac> ssGetOrderContractFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bdb8cd2e0da3eae2f170942895f2a3ac outParamRecord;
outParamRecord = await ExtendedActions.GetOrderContractFile(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderAccounting</code> that represents the Service Studio function
///  <code>GetOrderAccounting</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2dc2cf38bcc16a8b338dc5ea9a5c6446> ssGetOrderAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2dc2cf38bcc16a8b338dc5ea9a5c6446 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderAccounting(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderMain</code> that represents the Service Studio function
///  <code>GetOrderMain</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1583d548420c231ffb93458312800446> ssGetOrderMain(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1583d548420c231ffb93458312800446 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderMain(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderLogs</code> that represents the Service Studio function
///  <code>GetOrderLogs</code> <p> Description: </p>
/// </summary>

public static async Task<RC_aa950ad3dd0235488db9d65307673199> ssGetOrderLogs(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aa950ad3dd0235488db9d65307673199 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderLogs(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceApprovalLevel</code> that represents the Service Studio function
///  <code>GetInvoiceApprovalLevel</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a542803a75b19356be8279fb269e55fb> ssGetInvoiceApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a542803a75b19356be8279fb269e55fb outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceApprovalLevel(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFileImportLog</code> that represents the Service Studio function
///  <code>GetFileImportLog</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1d614602032ba1d6426327cab15c1a37> ssGetFileImportLog(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1d614602032ba1d6426327cab15c1a37 outParamRecord;
outParamRecord = await ExtendedActions.GetFileImportLog(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedItem</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedItem</code> <p> Description: </p>
/// </summary>

public static async Task<RC_7f2610cf0c5fadd86ba78c902c31effa> ssGetInvoiceExtendedItem(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7f2610cf0c5fadd86ba78c902c31effa outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedItem(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceAccountingServices</code> that represents the Service Studio function
///  <code>GetInvoiceAccountingServices</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5a609a7b7b622cde2859ca506690f8db> ssGetInvoiceAccountingServices(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5a609a7b7b622cde2859ca506690f8db outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceAccountingServices(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionService</code> that represents the Service Studio function
///  <code>GetRequisitionService</code> <p> Description: </p>
/// </summary>

public static async Task<RC_04e7247757060d4016b43102119b0dd6> ssGetRequisitionService(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_04e7247757060d4016b43102119b0dd6 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionService(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceAccountingProcessStatus</code> that represents the Service Studio function
///  <code>GetInvoiceAccountingProcessStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_88759af0096e690bb0b27652d93642e4> ssGetInvoiceAccountingProcessStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_88759af0096e690bb0b27652d93642e4 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceAccountingProcessStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoicePolizaStorage</code> that represents the Service Studio function
///  <code>GetInvoicePolizaStorage</code> <p> Description: </p>
/// </summary>

public static async Task<RC_285d5103004edd69f9105c056eb9d2a6> ssGetInvoicePolizaStorage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_285d5103004edd69f9105c056eb9d2a6 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoicePolizaStorage(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderService</code> that represents the Service Studio function
///  <code>GetOrderService</code> <p> Description: </p>
/// </summary>

public static async Task<RC_aaba1a35921d1afc1af21b1865cba418> ssGetOrderService(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_aaba1a35921d1afc1af21b1865cba418 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderService(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionApproval</code> that represents the Service Studio function
///  <code>GetRequisitionApproval</code> <p> Description: </p>
/// </summary>

public static async Task<RC_6d2bef4b7e32de4c7c78886eeff75224> ssGetRequisitionApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_6d2bef4b7e32de4c7c78886eeff75224 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionApproval(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderDetail</code> that represents the Service Studio function
///  <code>GetOrderDetail</code> <p> Description: </p>
/// </summary>

public static async Task<RC_7f0ffeffec7d0864eb8855fe8e873743> ssGetOrderDetail(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7f0ffeffec7d0864eb8855fe8e873743 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderDetail(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionStatus</code> that represents the Service Studio function
///  <code>GetRequisitionStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_b0a85cd983a4f43fec20a9e94774104b> ssGetRequisitionStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_b0a85cd983a4f43fec20a9e94774104b outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalComment</code> that represents the Service Studio function
///  <code>GetProposalComment</code> <p> Description: </p>
/// </summary>

public static async Task<RC_cd5101cd31ffd8dc09aecaca6d77004a> ssGetProposalComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cd5101cd31ffd8dc09aecaca6d77004a outParamRecord;
outParamRecord = await ExtendedActions.GetProposalComment(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceAccountingEntries</code> that represents the Service Studio function
///  <code>GetInvoiceAccountingEntries</code> <p> Description: </p>
/// </summary>

public static async Task<RC_85ff79276420f97ef98dc48e2b262e60> ssGetInvoiceAccountingEntries(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_85ff79276420f97ef98dc48e2b262e60 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceAccountingEntries(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalLineApprovalLevel</code> that represents the Service Studio function
///  <code>GetProposalLineApprovalLevel</code> <p> Description: </p>
/// </summary>

public static async Task<RC_875fb45d4123a91fce83831f0f554d8e> ssGetProposalLineApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_875fb45d4123a91fce83831f0f554d8e outParamRecord;
outParamRecord = await ExtendedActions.GetProposalLineApprovalLevel(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedIssuer</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedIssuer</code> <p> Description: </p>
/// </summary>

public static async Task<RC_bceddfb85670aa95e44aa049194f2b7c> ssGetInvoiceExtendedIssuer(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_bceddfb85670aa95e44aa049194f2b7c outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedIssuer(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFile3</code> that represents the Service Studio function <code>GetFile3</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_e5232dda8695a6b53d7aafcc3b6d847f> ssGetFile3(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e5232dda8695a6b53d7aafcc3b6d847f outParamRecord;
outParamRecord = await ExtendedActions.GetFile3(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalApproval</code> that represents the Service Studio function
///  <code>GetProposalApproval</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1e5bc1d6d010761f865e3a0774f1c819> ssGetProposalApproval(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1e5bc1d6d010761f865e3a0774f1c819 outParamRecord;
outParamRecord = await ExtendedActions.GetProposalApproval(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceAccountingProcessLines_F43</code> that represents the Service Studio
///  function <code>GetInvoiceAccountingProcessLines_F43</code> <p> Description: </p>
/// </summary>

public static async Task<RC_56dd61ddd73c9e3bf07414aa1c617494> ssGetInvoiceAccountingProcessLines_F43(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_56dd61ddd73c9e3bf07414aa1c617494 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceAccountingProcessLines_F43(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderFile</code> that represents the Service Studio function
///  <code>GetOrderFile</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a7394a353dc1b7f636aaced209e66116> ssGetOrderFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a7394a353dc1b7f636aaced209e66116 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderFile(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceAccountingProcess</code> that represents the Service Studio function
///  <code>GetInvoiceAccountingProcess</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d01c9a070ebc097e32a128e1b4125cc2> ssGetInvoiceAccountingProcess(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d01c9a070ebc097e32a128e1b4125cc2 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceAccountingProcess(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderApprovalLevel</code> that represents the Service Studio function
///  <code>GetOrderApprovalLevel</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ff8382bb6fb6cc7d57ecda7bb499922f> ssGetOrderApprovalLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ff8382bb6fb6cc7d57ecda7bb499922f outParamRecord;
outParamRecord = await ExtendedActions.GetOrderApprovalLevel(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalCommentFile</code> that represents the Service Studio function
///  <code>GetProposalCommentFile</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1fc482b76911051ba177b5ef645edd69> ssGetProposalCommentFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1fc482b76911051ba177b5ef645edd69 outParamRecord;
outParamRecord = await ExtendedActions.GetProposalCommentFile(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActionTimestamps</code> that represents the Service Studio function
///  <code>GetActionTimestamps</code> <p> Description: </p>
/// </summary>

public static async Task<RC_00310a262abd8758c59d6849f2a2be40> ssGetActionTimestamps(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_00310a262abd8758c59d6849f2a2be40 outParamRecord;
outParamRecord = await ExtendedActions.GetActionTimestamps(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionAccounting</code> that represents the Service Studio function
///  <code>GetRequisitionAccounting</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5860726e4142bb2973b9ba88d317465f> ssGetRequisitionAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5860726e4142bb2973b9ba88d317465f outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionAccounting(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoicePoliza</code> that represents the Service Studio function
///  <code>GetInvoicePoliza</code> <p> Description: </p>
/// </summary>

public static async Task<RC_14fd6714905cc16780383cc2da86ee0d> ssGetInvoicePoliza(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_14fd6714905cc16780383cc2da86ee0d outParamRecord;
outParamRecord = await ExtendedActions.GetInvoicePoliza(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedMoreCharges</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedMoreCharges</code> <p> Description: </p>
/// </summary>

public static async Task<RC_152a5bcdbf970bfba2a0da40766a2168> ssGetInvoiceExtendedMoreCharges(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_152a5bcdbf970bfba2a0da40766a2168 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedMoreCharges(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSpecialApproval</code> that represents the Service Studio function
///  <code>GetSpecialApproval</code> <p> Description: </p>
/// </summary>

public static async Task<RC_34acf11553964937c377a82c97a2edf5> ssGetSpecialApproval(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_34acf11553964937c377a82c97a2edf5 outParamRecord;
outParamRecord = await ExtendedActions.GetSpecialApproval(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionCostCenter</code> that represents the Service Studio function
///  <code>GetRequisitionCostCenter</code> <p> Description: </p>
/// </summary>

public static async Task<RC_508355980a3676af946819914b6b1546> ssGetRequisitionCostCenter(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_508355980a3676af946819914b6b1546 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionCostCenter(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceAccountingProcessRetentions</code> that represents the Service Studio
///  function <code>GetInvoiceAccountingProcessRetentions</code> <p> Description: </p>
/// </summary>

public static async Task<RC_572bb5931fdd9ca097b2d3800101c49b> ssGetInvoiceAccountingProcessRetentions(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_572bb5931fdd9ca097b2d3800101c49b outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceAccountingProcessRetentions(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedItemTax</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedItemTax</code> <p> Description: </p>
/// </summary>

public static async Task<RC_e7b4e13946d568a48ef39b6a3bfce595> ssGetInvoiceExtendedItemTax(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_e7b4e13946d568a48ef39b6a3bfce595 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedItemTax(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFolioObservations</code> that represents the Service Studio function
///  <code>GetFolioObservations</code> <p> Description: </p>
/// </summary>

public static async Task<RC_017cba02e4fd7f684606081b7269a26b> ssGetFolioObservations(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_017cba02e4fd7f684606081b7269a26b outParamRecord;
outParamRecord = await ExtendedActions.GetFolioObservations(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionFile2</code> that represents the Service Studio function
///  <code>GetRequisitionFile2</code> <p> Description: </p>
/// </summary>

public static async Task<RC_3e0fb635eefe948054fa75421546a901> ssGetRequisitionFile2(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_3e0fb635eefe948054fa75421546a901 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionFile2(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtendedSelloDigital</code> that represents the Service Studio function
///  <code>GetInvoiceExtendedSelloDigital</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d5bae0a1e64415dc86dedbeae539158c> ssGetInvoiceExtendedSelloDigital(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d5bae0a1e64415dc86dedbeae539158c outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtendedSelloDigital(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRequisitionComment</code> that represents the Service Studio function
///  <code>GetRequisitionComment</code> <p> Description: </p>
/// </summary>

public static async Task<RC_08daffa670c72e7502779e59a7b292d3> ssGetRequisitionComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_08daffa670c72e7502779e59a7b292d3 outParamRecord;
outParamRecord = await ExtendedActions.GetRequisitionComment(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetImportStatus</code> that represents the Service Studio function
///  <code>GetImportStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_73cba58e096fd5aef16244a229132919> ssGetImportStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_73cba58e096fd5aef16244a229132919 outParamRecord;
outParamRecord = await ExtendedActions.GetImportStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProposalLine</code> that represents the Service Studio function
///  <code>GetProposalLine</code> <p> Description: </p>
/// </summary>

public static async Task<RC_cbff39127609a0f830b2d34948d1c019> ssGetProposalLine(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_cbff39127609a0f830b2d34948d1c019 outParamRecord;
outParamRecord = await ExtendedActions.GetProposalLine(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceAccounting</code> that represents the Service Studio function
///  <code>GetInvoiceAccounting</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c398a83ea7d109886e6be693f6d07867> ssGetInvoiceAccounting(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c398a83ea7d109886e6be693f6d07867 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceAccounting(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrderRequestFileComment</code> that represents the Service Studio function
///  <code>GetOrderRequestFileComment</code> <p> Description: </p>
/// </summary>

public static async Task<RC_003b51eef272cce91f55924f504b1b11> ssGetOrderRequestFileComment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_003b51eef272cce91f55924f504b1b11 outParamRecord;
outParamRecord = await ExtendedActions.GetOrderRequestFileComment(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceExtended</code> that represents the Service Studio function
///  <code>GetInvoiceExtended</code> <p> Description: </p>
/// </summary>

public static async Task<RC_fbe3f1050ad4f34fa0e0a15f88a56873> ssGetInvoiceExtended(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_fbe3f1050ad4f34fa0e0a15f88a56873 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceExtended(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApprovalProcessLevel</code> that represents the Service Studio function
///  <code>GetApprovalProcessLevel</code> <p> Description: </p>
/// </summary>

public static async Task<RC_7ec02fc4f43bb6e10050644c8c1ae31b> ssGetApprovalProcessLevel(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7ec02fc4f43bb6e10050644c8c1ae31b outParamRecord;
outParamRecord = await ExtendedActions.GetApprovalProcessLevel(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApprovalProcess</code> that represents the Service Studio function
///  <code>GetApprovalProcess</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f2bd78b86ae9bba0b46cc5d8814834af> ssGetApprovalProcess(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f2bd78b86ae9bba0b46cc5d8814834af outParamRecord;
outParamRecord = await ExtendedActions.GetApprovalProcess(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSpecialWorkflowUploadPuestos</code> that represents the Service Studio function
///  <code>GetSpecialWorkflowUploadPuestos</code> <p> Description: </p>
/// </summary>

public static async Task<RC_46f699009338b3c2298787ee4b6262ec> ssGetSpecialWorkflowUploadPuestos(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_46f699009338b3c2298787ee4b6262ec outParamRecord;
outParamRecord = await ExtendedActions.GetSpecialWorkflowUploadPuestos(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessType</code> that represents the Service Studio function
///  <code>GetProcessType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_efc73b4c3b9559691917e7c2536af227> ssGetProcessType(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_efc73b4c3b9559691917e7c2536af227 outParamRecord;
outParamRecord = await ExtendedActions.GetProcessType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSpecialWorkflows</code> that represents the Service Studio function
///  <code>GetSpecialWorkflows</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ca50fec91350241da30b622279065c6e> ssGetSpecialWorkflows(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ca50fec91350241da30b622279065c6e outParamRecord;
outParamRecord = await ExtendedActions.GetSpecialWorkflows(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApprovalProcessMatrix</code> that represents the Service Studio function
///  <code>GetApprovalProcessMatrix</code> <p> Description: </p>
/// </summary>

public static async Task<RC_40e7a439bb45c9955de25b1debc0650f> ssGetApprovalProcessMatrix(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_40e7a439bb45c9955de25b1debc0650f outParamRecord;
outParamRecord = await ExtendedActions.GetApprovalProcessMatrix(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSeriesType</code> that represents the Service Studio function
///  <code>GetSeriesType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_8bfcc1d381d104953fbf01fd54a56e45> ssGetSeriesType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8bfcc1d381d104953fbf01fd54a56e45 outParamRecord;
outParamRecord = await ExtendedActions.GetSeriesType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetLegendPosition</code> that represents the Service Studio function
///  <code>GetLegendPosition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_054139ee1b4e118a0de0bda9edde9b3e> ssGetLegendPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_054139ee1b4e118a0de0bda9edde9b3e outParamRecord;
outParamRecord = await ExtendedActions.GetLegendPosition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetLegendLayout</code> that represents the Service Studio function
///  <code>GetLegendLayout</code> <p> Description: </p>
/// </summary>

public static async Task<RC_250abb7806127d6d6c565bcd6bd8fd6f> ssGetLegendLayout(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_250abb7806127d6d6c565bcd6bd8fd6f outParamRecord;
outParamRecord = await ExtendedActions.GetLegendLayout(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOperator</code> that represents the Service Studio function
///  <code>GetOperator</code> <p> Description: </p>
/// </summary>

public static async Task<RC_21f3e2fd18d91908a16d2c0ca969f965> ssGetOperator(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_21f3e2fd18d91908a16d2c0ca969f965 outParamRecord;
outParamRecord = await ExtendedActions.GetOperator(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetCurrency</code> that represents the Service Studio function
///  <code>GetCurrency</code> <p> Description: </p>
/// </summary>

public static async Task<RC_0468f02f35e6ccd6a092f321c5d8a88e> ssGetCurrency(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0468f02f35e6ccd6a092f321c5d8a88e outParamRecord;
outParamRecord = await ExtendedActions.GetCurrency(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDayOfWeek</code> that represents the Service Studio function
///  <code>GetDayOfWeek</code> <p> Description: </p>
/// </summary>

public static async Task<RC_b80982ac17cf476fb15d90ab7992f505> ssGetDayOfWeek(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_b80982ac17cf476fb15d90ab7992f505 outParamRecord;
outParamRecord = await ExtendedActions.GetDayOfWeek(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetBank</code> that represents the Service Studio function <code>GetBank</code> <p>
///  Description: </p>
/// </summary>

public static async Task<RC_df806ed45594b8c12dc41d845973c44a> ssGetBank(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_df806ed45594b8c12dc41d845973c44a outParamRecord;
outParamRecord = await ExtendedActions.GetBank(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessStatus</code> that represents the Service Studio function
///  <code>GetProcessStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a7be5795c4af08fa8098110e55d36aff> ssGetProcessStatus(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a7be5795c4af08fa8098110e55d36aff outParamRecord;
outParamRecord = await ExtendedActions.GetProcessStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityStatus</code> that represents the Service Studio function
///  <code>GetActivityStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_36a7d48575a55c39ace8b7f6b0cd3ac4> ssGetActivityStatus(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_36a7d48575a55c39ace8b7f6b0cd3ac4 outParamRecord;
outParamRecord = await ExtendedActions.GetActivityStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUser</code> that represents the Service Studio function <code>GetUser</code> <p>
///  Description: </p>
/// </summary>

public static async Task<RC_ced013358a82a813f1d9a5108f17ce79> ssGetUser(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ced013358a82a813f1d9a5108f17ce79 outParamRecord;
outParamRecord = await ExtendedActions.GetUser(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetActivityKind</code> that represents the Service Studio function
///  <code>GetActivityKind</code> <p> Description: </p>
/// </summary>

public static async Task<RC_99e7afb0bae555fcf70d1cd06f23ae14> ssGetActivityKind(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_99e7afb0bae555fcf70d1cd06f23ae14 outParamRecord;
outParamRecord = await ExtendedActions.GetActivityKind(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetMarginSize</code> that represents the Service Studio function
///  <code>GetMarginSize</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1fb80539f98a7ca912363f5e5c822271> ssGetMarginSize(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_1fb80539f98a7ca912363f5e5c822271 outParamRecord;
outParamRecord = await ExtendedActions.GetMarginSize(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetPaperSize</code> that represents the Service Studio function
///  <code>GetPaperSize</code> <p> Description: </p>
/// </summary>

public static async Task<RC_6748c146370600806f2500c8b8a2cb25> ssGetPaperSize(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_6748c146370600806f2500c8b8a2cb25 outParamRecord;
outParamRecord = await ExtendedActions.GetPaperSize(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetAudit</code> that represents the Service Studio function <code>GetAudit</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_1549014643485d6d2fd0ba657a6961ac> ssGetAudit(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1549014643485d6d2fd0ba657a6961ac outParamRecord;
outParamRecord = await ExtendedActions.GetAudit(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrigin</code> that represents the Service Studio function <code>GetOrigin</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_36c38bc61b6c1577adb85f09b017c138> ssGetOrigin(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_36c38bc61b6c1577adb85f09b017c138 outParamRecord;
outParamRecord = await ExtendedActions.GetOrigin(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSideMenuBehavior</code> that represents the Service Studio function
///  <code>GetSideMenuBehavior</code> <p> Description: </p>
/// </summary>

public static async Task<RC_e3607d6b92545e5793fbeb99fc16b7e7> ssGetSideMenuBehavior(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_e3607d6b92545e5793fbeb99fc16b7e7 outParamRecord;
outParamRecord = await ExtendedActions.GetSideMenuBehavior(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSize</code> that represents the Service Studio function <code>GetSize</code> <p>
///  Description: </p>
/// </summary>

public static async Task<RC_ca426fec0751e5b6dcf015e9fdc2120e> ssGetSize(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ca426fec0751e5b6dcf015e9fdc2120e outParamRecord;
outParamRecord = await ExtendedActions.GetSize(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetGutterSize</code> that represents the Service Studio function
///  <code>GetGutterSize</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a5018402fa6c90c5e826e54b2748cedc> ssGetGutterSize(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_a5018402fa6c90c5e826e54b2748cedc outParamRecord;
outParamRecord = await ExtendedActions.GetGutterSize(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetOrientation</code> that represents the Service Studio function
///  <code>GetOrientation</code> <p> Description: </p>
/// </summary>

public static async Task<RC_3ba1d238c8e0f0c3e875fb37f0381cc6> ssGetOrientation(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3ba1d238c8e0f0c3e875fb37f0381cc6 outParamRecord;
outParamRecord = await ExtendedActions.GetOrientation(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDatePickerTimeFormat</code> that represents the Service Studio function
///  <code>GetDatePickerTimeFormat</code> <p> Description: </p>
/// </summary>

public static async Task<RC_51b1c15949308af5f9b2dba7043d5ae6> ssGetDatePickerTimeFormat(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_51b1c15949308af5f9b2dba7043d5ae6 outParamRecord;
outParamRecord = await ExtendedActions.GetDatePickerTimeFormat(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetAccordionIconType</code> that represents the Service Studio function
///  <code>GetAccordionIconType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_73fae6920f82113320dccc89ef073c01> ssGetAccordionIconType(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_73fae6920f82113320dccc89ef073c01 outParamRecord;
outParamRecord = await ExtendedActions.GetAccordionIconType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDirection</code> that represents the Service Studio function
///  <code>GetDirection</code> <p> Description: </p>
/// </summary>

public static async Task<RC_070998dc6b3dc951b52d8108550fe380> ssGetDirection(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_070998dc6b3dc951b52d8108550fe380 outParamRecord;
outParamRecord = await ExtendedActions.GetDirection(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetBreakColumns</code> that represents the Service Studio function
///  <code>GetBreakColumns</code> <p> Description: </p>
/// </summary>

public static async Task<RC_261685da2c799bcc3b4873485e008694> ssGetBreakColumns(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_261685da2c799bcc3b4873485e008694 outParamRecord;
outParamRecord = await ExtendedActions.GetBreakColumns(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetShape</code> that represents the Service Studio function <code>GetShape</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_0a89eeb60fa1f44b6316ca69b462007b> ssGetShape(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0a89eeb60fa1f44b6316ca69b462007b outParamRecord;
outParamRecord = await ExtendedActions.GetShape(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetPosition</code> that represents the Service Studio function
///  <code>GetPosition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5f28219a5e30fb90023fcbc295513e7c> ssGetPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_5f28219a5e30fb90023fcbc295513e7c outParamRecord;
outParamRecord = await ExtendedActions.GetPosition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetTrigger</code> that represents the Service Studio function
///  <code>GetTrigger</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ab84a98a3ac9de80e9278e5b21681a23> ssGetTrigger(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ab84a98a3ac9de80e9278e5b21681a23 outParamRecord;
outParamRecord = await ExtendedActions.GetTrigger(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSpace</code> that represents the Service Studio function <code>GetSpace</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_9589ecc0629788c2aca6b47bcbae782c> ssGetSpace(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_9589ecc0629788c2aca6b47bcbae782c outParamRecord;
outParamRecord = await ExtendedActions.GetSpace(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetBooleanTypes</code> that represents the Service Studio function
///  <code>GetBooleanTypes</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1ea63146d7f1d969afc206832e751192> ssGetBooleanTypes(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_1ea63146d7f1d969afc206832e751192 outParamRecord;
outParamRecord = await ExtendedActions.GetBooleanTypes(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetAccordionIconPosition</code> that represents the Service Studio function
///  <code>GetAccordionIconPosition</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ab72f035aa34ddb5ec313dc02adb1f18> ssGetAccordionIconPosition(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_ab72f035aa34ddb5ec313dc02adb1f18 outParamRecord;
outParamRecord = await ExtendedActions.GetAccordionIconPosition(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetScrollbarStyle</code> that represents the Service Studio function
///  <code>GetScrollbarStyle</code> <p> Description: </p>
/// </summary>

public static async Task<RC_3d7c5be4055c8fe2c227afc40d8dee2f> ssGetScrollbarStyle(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_3d7c5be4055c8fe2c227afc40d8dee2f outParamRecord;
outParamRecord = await ExtendedActions.GetScrollbarStyle(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetColor</code> that represents the Service Studio function <code>GetColor</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_87351e3b0fa2ca59cf6c6749c6405006> ssGetColor(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_87351e3b0fa2ca59cf6c6749c6405006 outParamRecord;
outParamRecord = await ExtendedActions.GetColor(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSteps</code> that represents the Service Studio function <code>GetSteps</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_0d776a4e191faf321030d5ce57aa4167> ssGetSteps(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_0d776a4e191faf321030d5ce57aa4167 outParamRecord;
outParamRecord = await ExtendedActions.GetSteps(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetVideoState</code> that represents the Service Studio function
///  <code>GetVideoState</code> <p> Description: </p>
/// </summary>

public static async Task<RC_03619642a06de09478f0b8f506c364eb> ssGetVideoState(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_03619642a06de09478f0b8f506c364eb outParamRecord;
outParamRecord = await ExtendedActions.GetVideoState(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDatePickerWeekDay</code> that represents the Service Studio function
///  <code>GetDatePickerWeekDay</code> <p> Description: </p>
/// </summary>

public static async Task<RC_210f541f43ec6384ba59bfd8fe4b8837> ssGetDatePickerWeekDay(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_210f541f43ec6384ba59bfd8fe4b8837 outParamRecord;
outParamRecord = await ExtendedActions.GetDatePickerWeekDay(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRoleConcept</code> that represents the Service Studio function
///  <code>GetRoleConcept</code> <p> Description: </p>
/// </summary>

public static async Task<RC_51f0b789ef77b4d6d4002737fb63bbb9> ssGetRoleConcept(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_51f0b789ef77b4d6d4002737fb63bbb9 outParamRecord;
outParamRecord = await ExtendedActions.GetRoleConcept(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUserApplicationRole</code> that represents the Service Studio function
///  <code>GetUserApplicationRole</code> <p> Description: </p>
/// </summary>

public static async Task<RC_44a1416c6a0b117b6b7e5164f9d5147f> ssGetUserApplicationRole(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_44a1416c6a0b117b6b7e5164f9d5147f outParamRecord;
outParamRecord = await ExtendedActions.GetUserApplicationRole(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetConcept</code> that represents the Service Studio function
///  <code>GetConcept</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a70b8366666f6f8d6d35b774d39f9230> ssGetConcept(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a70b8366666f6f8d6d35b774d39f9230 outParamRecord;
outParamRecord = await ExtendedActions.GetConcept(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApplicationRole</code> that represents the Service Studio function
///  <code>GetApplicationRole</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ceec47435de563c2690b605ecca69a94> ssGetApplicationRole(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_ceec47435de563c2690b605ecca69a94 outParamRecord;
outParamRecord = await ExtendedActions.GetApplicationRole(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUserApplicationRoleTempByConcept</code> that represents the Service Studio
///  function <code>GetUserApplicationRoleTempByConcept</code> <p> Description: </p>
/// </summary>

public static async Task<RC_0ac1b5c675d1742c0ea797802ee62592> ssGetUserApplicationRoleTempByConcept(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_0ac1b5c675d1742c0ea797802ee62592 outParamRecord;
outParamRecord = await ExtendedActions.GetUserApplicationRoleTempByConcept(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetEntraRole</code> that represents the Service Studio function
///  <code>GetEntraRole</code> <p> Description: </p>
/// </summary>

public static async Task<RC_3ae851ff8b62d3b4ff8041de781ce47d> ssGetEntraRole(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_3ae851ff8b62d3b4ff8041de781ce47d outParamRecord;
outParamRecord = await ExtendedActions.GetEntraRole(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUserApplicationRoleTemp</code> that represents the Service Studio function
///  <code>GetUserApplicationRoleTemp</code> <p> Description: </p>
/// </summary>

public static async Task<RC_66c67d926e518c0b673d9119f62da193> ssGetUserApplicationRoleTemp(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_66c67d926e518c0b673d9119f62da193 outParamRecord;
outParamRecord = await ExtendedActions.GetUserApplicationRoleTemp(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRoleStatus</code> that represents the Service Studio function
///  <code>GetRoleStatus</code> <p> Description: </p>
/// </summary>

public static async Task<RC_e6c76727dae2b3bb5ec75f08f3bfbb21> ssGetRoleStatus(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_e6c76727dae2b3bb5ec75f08f3bfbb21 outParamRecord;
outParamRecord = await ExtendedActions.GetRoleStatus(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUserExtension</code> that represents the Service Studio function
///  <code>GetUserExtension</code> <p> Description: </p>
/// </summary>

public static async Task<RC_620c1ad5411dbb3ddbe0616529c19a2e> ssGetUserExtension(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_620c1ad5411dbb3ddbe0616529c19a2e outParamRecord;
outParamRecord = await ExtendedActions.GetUserExtension(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDeletedStorage</code> that represents the Service Studio function
///  <code>GetDeletedStorage</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1789507e695396bb66757dd83a78c4b5> ssGetDeletedStorage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1789507e695396bb66757dd83a78c4b5 outParamRecord;
outParamRecord = await ExtendedActions.GetDeletedStorage(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInternalConcept</code> that represents the Service Studio function
///  <code>GetInternalConcept</code> <p> Description: </p>
/// </summary>

public static async Task<RC_fe70e85a2080a52611f1c24f3043653c> ssGetInternalConcept(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_fe70e85a2080a52611f1c24f3043653c outParamRecord;
outParamRecord = await ExtendedActions.GetInternalConcept(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetStorage</code> that represents the Service Studio function
///  <code>GetStorage</code> <p> Description: </p>
/// </summary>

public static async Task<RC_b2edf1939202eb7e60eb499349388514> ssGetStorage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_b2edf1939202eb7e60eb499349388514 outParamRecord;
outParamRecord = await ExtendedActions.GetStorage(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetAccountingAccounts_ServiceType</code> that represents the Service Studio function
///  <code>GetAccountingAccounts_ServiceType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f52b5cefcfac404122195213ce1b53ba> ssGetAccountingAccounts_ServiceType(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f52b5cefcfac404122195213ce1b53ba outParamRecord;
outParamRecord = await ExtendedActions.GetAccountingAccounts_ServiceType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDepositType</code> that represents the Service Studio function
///  <code>GetDepositType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a8c523bc4a14ce1cf905293530597bc7> ssGetDepositType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a8c523bc4a14ce1cf905293530597bc7 outParamRecord;
outParamRecord = await ExtendedActions.GetDepositType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetAccountingDataType</code> that represents the Service Studio function
///  <code>GetAccountingDataType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a222d17a2b10e551d257fa2f5892499c> ssGetAccountingDataType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a222d17a2b10e551d257fa2f5892499c outParamRecord;
outParamRecord = await ExtendedActions.GetAccountingDataType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInsuranceType</code> that represents the Service Studio function
///  <code>GetInsuranceType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_e16f126ae5f7407d32d4a429fb32ca9a> ssGetInsuranceType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_e16f126ae5f7407d32d4a429fb32ca9a outParamRecord;
outParamRecord = await ExtendedActions.GetInsuranceType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetManuals</code> that represents the Service Studio function
///  <code>GetManuals</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5a839548c2b6676209dad9fb179bc76c> ssGetManuals(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5a839548c2b6676209dad9fb179bc76c outParamRecord;
outParamRecord = await ExtendedActions.GetManuals(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetPaymentOptions</code> that represents the Service Studio function
///  <code>GetPaymentOptions</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2813028c34d1b3ce080a3e2c9febe797> ssGetPaymentOptions(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2813028c34d1b3ce080a3e2c9febe797 outParamRecord;
outParamRecord = await ExtendedActions.GetPaymentOptions(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetManualFile</code> that represents the Service Studio function
///  <code>GetManualFile</code> <p> Description: </p>
/// </summary>

public static async Task<RC_6d042e8f6faf9c16a51afdc5d65092dd> ssGetManualFile(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_6d042e8f6faf9c16a51afdc5d65092dd outParamRecord;
outParamRecord = await ExtendedActions.GetManualFile(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetCustomSettings</code> that represents the Service Studio function
///  <code>GetCustomSettings</code> <p> Description: </p>
/// </summary>

public static async Task<RC_4cea68d4a46fbd7372d4f181e98bfcdb> ssGetCustomSettings(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_4cea68d4a46fbd7372d4f181e98bfcdb outParamRecord;
outParamRecord = await ExtendedActions.GetCustomSettings(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetServiceFormat</code> that represents the Service Studio function
///  <code>GetServiceFormat</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1356565a59d37b0a56b61edcf3cae9df> ssGetServiceFormat(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1356565a59d37b0a56b61edcf3cae9df outParamRecord;
outParamRecord = await ExtendedActions.GetServiceFormat(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoiceUsage</code> that represents the Service Studio function
///  <code>GetInvoiceUsage</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2512cd3cc7f986e36b4d5edf290d4383> ssGetInvoiceUsage(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2512cd3cc7f986e36b4d5edf290d4383 outParamRecord;
outParamRecord = await ExtendedActions.GetInvoiceUsage(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSubdirection</code> that represents the Service Studio function
///  <code>GetSubdirection</code> <p> Description: </p>
/// </summary>

public static async Task<RC_896ad3137023f533323e3fc3a800f331> ssGetSubdirection(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_896ad3137023f533323e3fc3a800f331 outParamRecord;
outParamRecord = await ExtendedActions.GetSubdirection(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApplicantTelcelDirection</code> that represents the Service Studio function
///  <code>GetApplicantTelcelDirection</code> <p> Description: </p>
/// </summary>

public static async Task<RC_67bdd68f4d7be547b9a3c6fcb61b6dc6> ssGetApplicantTelcelDirection(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_67bdd68f4d7be547b9a3c6fcb61b6dc6 outParamRecord;
outParamRecord = await ExtendedActions.GetApplicantTelcelDirection(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetCFDIType</code> that represents the Service Studio function
///  <code>GetCFDIType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2cc384f6ee3d7a04dad15c303ce7a7a4> ssGetCFDIType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_2cc384f6ee3d7a04dad15c303ce7a7a4 outParamRecord;
outParamRecord = await ExtendedActions.GetCFDIType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetPurchasingGroup</code> that represents the Service Studio function
///  <code>GetPurchasingGroup</code> <p> Description: </p>
/// </summary>

public static async Task<RC_786a35d6d77ea6f67817eb0f3988b828> ssGetPurchasingGroup(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_786a35d6d77ea6f67817eb0f3988b828 outParamRecord;
outParamRecord = await ExtendedActions.GetPurchasingGroup(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetTaxIndicator</code> that represents the Service Studio function
///  <code>GetTaxIndicator</code> <p> Description: </p>
/// </summary>

public static async Task<RC_680b4f2b38f7607d61faf8ef68fd2613> ssGetTaxIndicator(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_680b4f2b38f7607d61faf8ef68fd2613 outParamRecord;
outParamRecord = await ExtendedActions.GetTaxIndicator(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDistribution</code> that represents the Service Studio function
///  <code>GetDistribution</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a6482208c24ce2e6c9c6ba16e57b0185> ssGetDistribution(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a6482208c24ce2e6c9c6ba16e57b0185 outParamRecord;
outParamRecord = await ExtendedActions.GetDistribution(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRetentionTypes</code> that represents the Service Studio function
///  <code>GetRetentionTypes</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d25c749e180f28d5d6211e73984f17d9> ssGetRetentionTypes(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_d25c749e180f28d5d6211e73984f17d9 outParamRecord;
outParamRecord = await ExtendedActions.GetRetentionTypes(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUser_Extended_Internal</code> that represents the Service Studio function
///  <code>GetUser_Extended_Internal</code> <p> Description: </p>
/// </summary>

public static async Task<RC_d979b4500d349dbbb37ac9f2fd2a6d68> ssGetUser_Extended_Internal(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_d979b4500d349dbbb37ac9f2fd2a6d68 outParamRecord;
outParamRecord = await ExtendedActions.GetUser_Extended_Internal(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetIVAExceptionM9Suppliers</code> that represents the Service Studio function
///  <code>GetIVAExceptionM9Suppliers</code> <p> Description: </p>
/// </summary>

public static async Task<RC_7eea8dd886abe2f5de3217d378b871fd> ssGetIVAExceptionM9Suppliers(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_7eea8dd886abe2f5de3217d378b871fd outParamRecord;
outParamRecord = await ExtendedActions.GetIVAExceptionM9Suppliers(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUser_Preferences</code> that represents the Service Studio function
///  <code>GetUser_Preferences</code> <p> Description: </p>
/// </summary>

public static async Task<RC_8a18f13d5e920f1ccdf5a8a3416c783c> ssGetUser_Preferences(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
RC_8a18f13d5e920f1ccdf5a8a3416c783c outParamRecord;
outParamRecord = await ExtendedActions.GetUser_Preferences(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDocumentType</code> that represents the Service Studio function
///  <code>GetDocumentType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_10f704d4de8999e255a09f6b1b9b5668> ssGetDocumentType(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_10f704d4de8999e255a09f6b1b9b5668 outParamRecord;
outParamRecord = await ExtendedActions.GetDocumentType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSupplierUser</code> that represents the Service Studio function
///  <code>GetSupplierUser</code> <p> Description: </p>
/// </summary>

public static async Task<RC_33e6e9ec201f65e0eb7bd5d251178def> ssGetSupplierUser(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_33e6e9ec201f65e0eb7bd5d251178def outParamRecord;
outParamRecord = await ExtendedActions.GetSupplierUser(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetCompany</code> that represents the Service Studio function
///  <code>GetCompany</code> <p> Description: </p>
/// </summary>

public static async Task<RC_99a1fa6df481ec5b1908e770c81b73b1> ssGetCompany(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_99a1fa6df481ec5b1908e770c81b73b1 outParamRecord;
outParamRecord = await ExtendedActions.GetCompany(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetDepartment</code> that represents the Service Studio function
///  <code>GetDepartment</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a091342374a4b333cc44c9d3c7cd8caa> ssGetDepartment(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a091342374a4b333cc44c9d3c7cd8caa outParamRecord;
outParamRecord = await ExtendedActions.GetDepartment(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApplicant</code> that represents the Service Studio function
///  <code>GetApplicant</code> <p> Description: </p>
/// </summary>

public static async Task<RC_9fd4d8d4a1a7da3e37ee97c8163946e6> ssGetApplicant(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_9fd4d8d4a1a7da3e37ee97c8163946e6 outParamRecord;
outParamRecord = await ExtendedActions.GetApplicant(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetApprovalProcessType</code> that represents the Service Studio function
///  <code>GetApprovalProcessType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_66db0edcff7ea9b0aa258e335add1ccc> ssGetApprovalProcessType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_66db0edcff7ea9b0aa258e335add1ccc outParamRecord;
outParamRecord = await ExtendedActions.GetApprovalProcessType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSupplier</code> that represents the Service Studio function
///  <code>GetSupplier</code> <p> Description: </p>
/// </summary>

public static async Task<RC_4934ec74dc6a80637b84c0985f5b12ce> ssGetSupplier(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_4934ec74dc6a80637b84c0985f5b12ce outParamRecord;
outParamRecord = await ExtendedActions.GetSupplier(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetCostCenterSAP</code> that represents the Service Studio function
///  <code>GetCostCenterSAP</code> <p> Description: </p>
/// </summary>

public static async Task<RC_515e950fe4b29206769e5475135e301d> ssGetCostCenterSAP(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_515e950fe4b29206769e5475135e301d outParamRecord;
outParamRecord = await ExtendedActions.GetCostCenterSAP(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetAccountableGuide</code> that represents the Service Studio function
///  <code>GetAccountableGuide</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5529030b7e85f68f6007e4d32f650ef7> ssGetAccountableGuide(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5529030b7e85f68f6007e4d32f650ef7 outParamRecord;
outParamRecord = await ExtendedActions.GetAccountableGuide(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSpecialPostDeliveryAuthorization</code> that represents the Service Studio
///  function <code>GetSpecialPostDeliveryAuthorization</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a18bcaa92353126e3b75741517eabbdb> ssGetSpecialPostDeliveryAuthorization(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_a18bcaa92353126e3b75741517eabbdb outParamRecord;
outParamRecord = await ExtendedActions.GetSpecialPostDeliveryAuthorization(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetTelcelDirection</code> that represents the Service Studio function
///  <code>GetTelcelDirection</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f7c59318074340c0e230babd5ea62fb5> ssGetTelcelDirection(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f7c59318074340c0e230babd5ea62fb5 outParamRecord;
outParamRecord = await ExtendedActions.GetTelcelDirection(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFrequency</code> that represents the Service Studio function
///  <code>GetFrequency</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f2c609d858f8411e75fbedee60c5dddf> ssGetFrequency(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_f2c609d858f8411e75fbedee60c5dddf outParamRecord;
outParamRecord = await ExtendedActions.GetFrequency(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetManagement</code> that represents the Service Studio function
///  <code>GetManagement</code> <p> Description: </p>
/// </summary>

public static async Task<RC_97877e692c313605c09a0be8396b97b4> ssGetManagement(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_97877e692c313605c09a0be8396b97b4 outParamRecord;
outParamRecord = await ExtendedActions.GetManagement(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSegmentAccGroup</code> that represents the Service Studio function
///  <code>GetSegmentAccGroup</code> <p> Description: </p>
/// </summary>

public static async Task<RC_941bbff9017349761a37494fcd214b98> ssGetSegmentAccGroup(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_941bbff9017349761a37494fcd214b98 outParamRecord;
outParamRecord = await ExtendedActions.GetSegmentAccGroup(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetAppConcept</code> that represents the Service Studio function
///  <code>GetAppConcept</code> <p> Description: </p>
/// </summary>

public static async Task<RC_b1b68bfd06a9e65c076da1c0201cd9dd> ssGetAppConcept(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_b1b68bfd06a9e65c076da1c0201cd9dd outParamRecord;
outParamRecord = await ExtendedActions.GetAppConcept(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetInvoicesUsageAccounts</code> that represents the Service Studio function
///  <code>GetInvoicesUsageAccounts</code> <p> Description: </p>
/// </summary>

public static async Task<RC_a6177074bb5c56dd37245c971e55737e> ssGetInvoicesUsageAccounts(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_a6177074bb5c56dd37245c971e55737e outParamRecord;
outParamRecord = await ExtendedActions.GetInvoicesUsageAccounts(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetCustomSettingValue</code> that represents the Service Studio function
///  <code>GetCustomSettingValue</code> <p> Description: </p>
/// </summary>

public static async Task<RC_fef56662c61d7afd2d3c90e5f49cfcfa> ssGetCustomSettingValue(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_fef56662c61d7afd2d3c90e5f49cfcfa outParamRecord;
outParamRecord = await ExtendedActions.GetCustomSettingValue(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetEntryBlockDates</code> that represents the Service Studio function
///  <code>GetEntryBlockDates</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2cd8ef4429a3040401080390a43c2ddc> ssGetEntryBlockDates(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2cd8ef4429a3040401080390a43c2ddc outParamRecord;
outParamRecord = await ExtendedActions.GetEntryBlockDates(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProject_Asset_Service</code> that represents the Service Studio function
///  <code>GetProject_Asset_Service</code> <p> Description: </p>
/// </summary>

public static async Task<RC_1b08a2c1cecef1e3b3006a60b97fc68e> ssGetProject_Asset_Service(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_1b08a2c1cecef1e3b3006a60b97fc68e outParamRecord;
outParamRecord = await ExtendedActions.GetProject_Asset_Service(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetManualUserArea</code> that represents the Service Studio function
///  <code>GetManualUserArea</code> <p> Description: </p>
/// </summary>

public static async Task<RC_53bfb6ba3a8f9433f06f269f872b84c8> ssGetManualUserArea(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_53bfb6ba3a8f9433f06f269f872b84c8 outParamRecord;
outParamRecord = await ExtendedActions.GetManualUserArea(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetPaymentTerms</code> that represents the Service Studio function
///  <code>GetPaymentTerms</code> <p> Description: </p>
/// </summary>

public static async Task<RC_5526bab1a99740bd870dde6a69ba3d9a> ssGetPaymentTerms(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_5526bab1a99740bd870dde6a69ba3d9a outParamRecord;
outParamRecord = await ExtendedActions.GetPaymentTerms(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetPaymentWays</code> that represents the Service Studio function
///  <code>GetPaymentWays</code> <p> Description: </p>
/// </summary>

public static async Task<RC_4a8ab393337b882018e44511f7ddbaa8> ssGetPaymentWays(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_4a8ab393337b882018e44511f7ddbaa8 outParamRecord;
outParamRecord = await ExtendedActions.GetPaymentWays(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetUserArea</code> that represents the Service Studio function
///  <code>GetUserArea</code> <p> Description: </p>
/// </summary>

public static async Task<RC_908593a03afc462f5e9a47938601f707> ssGetUserArea(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_908593a03afc462f5e9a47938601f707 outParamRecord;
outParamRecord = await ExtendedActions.GetUserArea(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetAdvancePaymentType</code> that represents the Service Studio function
///  <code>GetAdvancePaymentType</code> <p> Description: </p>
/// </summary>

public static async Task<RC_ba5df53107d79696b2775256d21bdd62> ssGetAdvancePaymentType(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_ba5df53107d79696b2775256d21bdd62 outParamRecord;
outParamRecord = await ExtendedActions.GetAdvancePaymentType(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetPaymentMethods</code> that represents the Service Studio function
///  <code>GetPaymentMethods</code> <p> Description: </p>
/// </summary>

public static async Task<RC_45208e184b912aa1623cdf19760e8e7e> ssGetPaymentMethods(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_45208e184b912aa1623cdf19760e8e7e outParamRecord;
outParamRecord = await ExtendedActions.GetPaymentMethods(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSegmentAccGroupTelcelDir</code> that represents the Service Studio function
///  <code>GetSegmentAccGroupTelcelDir</code> <p> Description: </p>
/// </summary>

public static async Task<RC_78f8de95e867ccc81eabb054968cbf5b> ssGetSegmentAccGroupTelcelDir(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_78f8de95e867ccc81eabb054968cbf5b outParamRecord;
outParamRecord = await ExtendedActions.GetSegmentAccGroupTelcelDir(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSupplierDetail</code> that represents the Service Studio function
///  <code>GetSupplierDetail</code> <p> Description: </p>
/// </summary>

public static async Task<RC_2a6a47a042b2e84eddb6ad9d86f0a684> ssGetSupplierDetail(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_2a6a47a042b2e84eddb6ad9d86f0a684 outParamRecord;
outParamRecord = await ExtendedActions.GetSupplierDetail(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetFiscalYearExceptions</code> that represents the Service Studio function
///  <code>GetFiscalYearExceptions</code> <p> Description: </p>
/// </summary>

public static async Task<RC_341c7b677aa5a51a40f72189133871ba> ssGetFiscalYearExceptions(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_341c7b677aa5a51a40f72189133871ba outParamRecord;
outParamRecord = await ExtendedActions.GetFiscalYearExceptions(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetBusinessValueCategory</code> that represents the Service Studio function
///  <code>GetBusinessValueCategory</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c8382e0b08ee9d5965e5aae5b17d6261> ssGetBusinessValueCategory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c8382e0b08ee9d5965e5aae5b17d6261 outParamRecord;
outParamRecord = await ExtendedActions.GetBusinessValueCategory(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetSustainability</code> that represents the Service Studio function
///  <code>GetSustainability</code> <p> Description: </p>
/// </summary>

public static async Task<RC_f677954b3254ea60260cb7baa72dce4f> ssGetSustainability(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_f677954b3254ea60260cb7baa72dce4f outParamRecord;
outParamRecord = await ExtendedActions.GetSustainability(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetVirtualStore</code> that represents the Service Studio function
///  <code>GetVirtualStore</code> <p> Description: </p>
/// </summary>

public static async Task<RC_549f08e709528a6bf28106addf9f0382> ssGetVirtualStore(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_549f08e709528a6bf28106addf9f0382 outParamRecord;
outParamRecord = await ExtendedActions.GetVirtualStore(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetRegion</code> that represents the Service Studio function <code>GetRegion</code>
///  <p> Description: </p>
/// </summary>

public static async Task<RC_deb85dc36640fa928dae5df2493065d0> ssGetRegion(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_deb85dc36640fa928dae5df2493065d0 outParamRecord;
outParamRecord = await ExtendedActions.GetRegion(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetProcessTypeDatesAllowed</code> that represents the Service Studio function
///  <code>GetProcessTypeDatesAllowed</code> <p> Description: </p>
/// </summary>

public static async Task<RC_c808f777f2a76c70ea9a3f0e560c6a3b> ssGetProcessTypeDatesAllowed(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_c808f777f2a76c70ea9a3f0e560c6a3b outParamRecord;
outParamRecord = await ExtendedActions.GetProcessTypeDatesAllowed(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetBusinessValueSubcategory</code> that represents the Service Studio function
///  <code>GetBusinessValueSubcategory</code> <p> Description: </p>
/// </summary>

public static async Task<RC_87a3063e6674014b4b345dce21ff4d84> ssGetBusinessValueSubcategory(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
RC_87a3063e6674014b4b345dce21ff4d84 outParamRecord;
outParamRecord = await ExtendedActions.GetBusinessValueSubcategory(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>GetEntraDomain</code> that represents the Service Studio function
///  <code>GetEntraDomain</code> <p> Description: </p>
/// </summary>

public static async Task<RC_46822aff680dcd6a1139ef31b620e73d> ssGetEntraDomain(IRequestContext requestContext,int inParamId,CancellationToken cancellationToken) {
RC_46822aff680dcd6a1139ef31b620e73d outParamRecord;
outParamRecord = await ExtendedActions.GetEntraDomain(requestContext,inParamId,cancellationToken);

return outParamRecord;
}

/// <summary>
/// Function <code>CheckConectaProveedoresRole</code> that represents the Service Studio function
///  <code>CheckConectaProveedoresRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckConectaProveedoresRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckConectaProveedoresRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckHistoricoRole</code> that represents the Service Studio function
///  <code>CheckHistoricoRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckHistoricoRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckHistoricoRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckComissionesArrendamientosViewerRole</code> that represents the Service Studio
///  function <code>CheckComissionesArrendamientosViewerRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckComissionesArrendamientosViewerRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckComissionesArrendamientosViewerRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckConectaProveedoresAdminRole</code> that represents the Service Studio function
///  <code>CheckConectaProveedoresAdminRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckConectaProveedoresAdminRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckConectaProveedoresAdminRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckComissionesArrendamientosRole</code> that represents the Service Studio
///  function <code>CheckComissionesArrendamientosRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckComissionesArrendamientosRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckComissionesArrendamientosRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckFoliosRole</code> that represents the Service Studio function
///  <code>CheckFoliosRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckFoliosRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckFoliosRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckComissionesArrendamientosAdminRole</code> that represents the Service Studio
///  function <code>CheckComissionesArrendamientosAdminRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckComissionesArrendamientosAdminRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckComissionesArrendamientosAdminRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckAlmacenRole</code> that represents the Service Studio function
///  <code>CheckAlmacenRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckAlmacenRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckAlmacenRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckReportesRole</code> that represents the Service Studio function
///  <code>CheckReportesRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckReportesRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckReportesRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckConectaProveedoresAdminViewerRole</code> that represents the Service Studio
///  function <code>CheckConectaProveedoresAdminViewerRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckConectaProveedoresAdminViewerRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckConectaProveedoresAdminViewerRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckPedidosRole</code> that represents the Service Studio function
///  <code>CheckPedidosRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckPedidosRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckPedidosRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckTesoreriaRole</code> that represents the Service Studio function
///  <code>CheckTesoreriaRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckTesoreriaRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckTesoreriaRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckDesviacionesRole</code> that represents the Service Studio function
///  <code>CheckDesviacionesRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckDesviacionesRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckDesviacionesRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckProveedorRole</code> that represents the Service Studio function
///  <code>CheckProveedorRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckProveedorRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckProveedorRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckSAPImportOrdersRole</code> that represents the Service Studio function
///  <code>CheckSAPImportOrdersRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckSAPImportOrdersRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckSAPImportOrdersRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckRequisicionesRole</code> that represents the Service Studio function
///  <code>CheckRequisicionesRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckRequisicionesRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckRequisicionesRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

/// <summary>
/// Function <code>CheckTelcelUserAuditorRole</code> that represents the Service Studio function
///  <code>CheckTelcelUserAuditorRole</code> <p> Description: </p>
/// </summary>

public static async Task<bool> ssCheckTelcelUserAuditorRole(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
bool outParamHasRole;
outParamHasRole = await ExtendedActions.CheckTelcelUserAuditorRole(requestContext,inParamUserId,cancellationToken);

return outParamHasRole;
}

}
