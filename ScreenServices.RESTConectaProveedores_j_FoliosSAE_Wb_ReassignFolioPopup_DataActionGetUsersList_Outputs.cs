using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_UsersList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca> outParamo_UsersList;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_4c313dd08c2e051e0c0310a6d05109b0 outParamo_UsersList) {RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs();
// Write the needed fields of the list outParamo_UsersList to the result.outParamo_UsersList
ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca tmpoutParamo_UsersListElement;
if(outParamo_UsersList.Empty) {
// Write the needed fields of the record outParamo_UsersList.CurrentRec to the tmpoutParamo_UsersListElement
tmpoutParamo_UsersListElement = new ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca();
// Write the needed fields of the record outParamo_UsersList.CurrentRec.ssENUser to the tmpoutParamo_UsersListElement.AttrUser
tmpoutParamo_UsersListElement.AttrUser = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
tmpoutParamo_UsersListElement.AttrUser.AttrId = outParamo_UsersList.CurrentRec.ssENUser.ssId;
tmpoutParamo_UsersListElement.AttrUser.AttrName = outParamo_UsersList.CurrentRec.ssENUser.ssName;
tmpoutParamo_UsersListElement.AttrUser.AttrEmail = outParamo_UsersList.CurrentRec.ssENUser.ssEmail;
// Write optimized tmpoutParamo_UsersListElement.AttrUser.AttrPhotoUrl
tmpoutParamo_UsersListElement.AttrUser.AttrPhotoUrl = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser.AttrUsername
tmpoutParamo_UsersListElement.AttrUser.AttrUsername = "";
// Write the needed fields of the record outParamo_UsersList.CurrentRec.ssENEntraRole to the tmpoutParamo_UsersListElement.AttrEntraRole
tmpoutParamo_UsersListElement.AttrEntraRole = new ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrId
tmpoutParamo_UsersListElement.AttrEntraRole.AttrId = (long?) 0L;
tmpoutParamo_UsersListElement.AttrEntraRole.AttrRoleName = outParamo_UsersList.CurrentRec.ssENEntraRole.ssRoleName;
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAreaUsuaria
tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAreaUsuaria = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAreaCxP
tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAreaCxP = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsSolicitante
tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsSolicitante = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAssistant
tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAssistant = (bool?) false;
// Write the needed fields of the record outParamo_UsersList.CurrentRec.ssENUser_Extended_Internal to the tmpoutParamo_UsersListElement.AttrUser_Extended_Internal
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal = new ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrId = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEmployeeNumber
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEmployeeNumber = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrManagedBy
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrManagedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrRegionId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrDepartmentId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrDepartmentId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrManagementId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrManagementId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrSubdirectionId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrSubdirectionId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrTelcelDirectionId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCity
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCity = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrJobTitle
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrJobTitle = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEntraRoleId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttronPremisesDistinguishedName
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttronPremisesDistinguishedName = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrHasRolesAssigned
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrHasRolesAssigned = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrLastSync
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrLastSync = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCreatedBy
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCreatedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCreatedOn
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrUpdatedBy
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrUpdatedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrUpdatedOn
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEntraId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEntraId = "";
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrTelcelDireccion = outParamo_UsersList.CurrentRec.ssENUser_Extended_Internal.ssTelcelDireccion;
// Write the needed fields of the record outParamo_UsersList.CurrentRec.ssENRegion to the tmpoutParamo_UsersListElement.AttrRegion
tmpoutParamo_UsersListElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrId
tmpoutParamo_UsersListElement.AttrRegion.AttrId = (long?) 0L;
tmpoutParamo_UsersListElement.AttrRegion.AttrCode = outParamo_UsersList.CurrentRec.ssENRegion.ssCode;
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrName
tmpoutParamo_UsersListElement.AttrRegion.AttrName = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrDivisionFI
tmpoutParamo_UsersListElement.AttrRegion.AttrDivisionFI = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrCentroRTP
tmpoutParamo_UsersListElement.AttrRegion.AttrCentroRTP = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrCommissionRegion
tmpoutParamo_UsersListElement.AttrRegion.AttrCommissionRegion = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrIsActive
tmpoutParamo_UsersListElement.AttrRegion.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrCreatedOn
tmpoutParamo_UsersListElement.AttrRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrCreatedBy
tmpoutParamo_UsersListElement.AttrRegion.AttrCreatedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrUpdatedOn
tmpoutParamo_UsersListElement.AttrRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrUpdatedBy
tmpoutParamo_UsersListElement.AttrRegion.AttrUpdatedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrIsFsP
tmpoutParamo_UsersListElement.AttrRegion.AttrIsFsP = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrIsFcP
tmpoutParamo_UsersListElement.AttrRegion.AttrIsFcP = (bool?) false;
result.outParamo_UsersList = new RestList<ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca>(new ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca[] {}, tmpoutParamo_UsersListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca>
 tmpoutParamo_UsersList1List = new List<ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca>
();
try {outParamo_UsersList.StartIteration();
while (!(outParamo_UsersList.Eof)) {
// Write the needed fields of the record outParamo_UsersList.CurrentRec to the tmpoutParamo_UsersListElement
tmpoutParamo_UsersListElement = new ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca();
// Write the needed fields of the record outParamo_UsersList.CurrentRec.ssENUser to the tmpoutParamo_UsersListElement.AttrUser
tmpoutParamo_UsersListElement.AttrUser = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
tmpoutParamo_UsersListElement.AttrUser.AttrId = outParamo_UsersList.CurrentRec.ssENUser.ssId;
tmpoutParamo_UsersListElement.AttrUser.AttrName = outParamo_UsersList.CurrentRec.ssENUser.ssName;
tmpoutParamo_UsersListElement.AttrUser.AttrEmail = outParamo_UsersList.CurrentRec.ssENUser.ssEmail;
// Write optimized tmpoutParamo_UsersListElement.AttrUser.AttrPhotoUrl
tmpoutParamo_UsersListElement.AttrUser.AttrPhotoUrl = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser.AttrUsername
tmpoutParamo_UsersListElement.AttrUser.AttrUsername = "";
// Write the needed fields of the record outParamo_UsersList.CurrentRec.ssENEntraRole to the tmpoutParamo_UsersListElement.AttrEntraRole
tmpoutParamo_UsersListElement.AttrEntraRole = new ssConectaProveedores.RestRecords.RESTEN_d27d6d10f66f82966903ca7fd33164f8EntityRecord();
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrId
tmpoutParamo_UsersListElement.AttrEntraRole.AttrId = (long?) 0L;
tmpoutParamo_UsersListElement.AttrEntraRole.AttrRoleName = outParamo_UsersList.CurrentRec.ssENEntraRole.ssRoleName;
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAreaUsuaria
tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAreaUsuaria = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAreaCxP
tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAreaCxP = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsSolicitante
tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsSolicitante = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAssistant
tmpoutParamo_UsersListElement.AttrEntraRole.AttrIsAssistant = (bool?) false;
// Write the needed fields of the record outParamo_UsersList.CurrentRec.ssENUser_Extended_Internal to the tmpoutParamo_UsersListElement.AttrUser_Extended_Internal
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal = new ssConectaProveedores.RestRecords.RESTEN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrId = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEmployeeNumber
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEmployeeNumber = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrManagedBy
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrManagedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrRegionId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrDepartmentId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrDepartmentId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrManagementId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrManagementId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrSubdirectionId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrSubdirectionId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrTelcelDirectionId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCity
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCity = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrJobTitle
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrJobTitle = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEntraRoleId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttronPremisesDistinguishedName
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttronPremisesDistinguishedName = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrHasRolesAssigned
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrHasRolesAssigned = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrLastSync
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrLastSync = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCreatedBy
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCreatedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCreatedOn
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrUpdatedBy
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrUpdatedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrUpdatedOn
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEntraId
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrEntraId = "";
tmpoutParamo_UsersListElement.AttrUser_Extended_Internal.AttrTelcelDireccion = outParamo_UsersList.CurrentRec.ssENUser_Extended_Internal.ssTelcelDireccion;
// Write the needed fields of the record outParamo_UsersList.CurrentRec.ssENRegion to the tmpoutParamo_UsersListElement.AttrRegion
tmpoutParamo_UsersListElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrId
tmpoutParamo_UsersListElement.AttrRegion.AttrId = (long?) 0L;
tmpoutParamo_UsersListElement.AttrRegion.AttrCode = outParamo_UsersList.CurrentRec.ssENRegion.ssCode;
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrName
tmpoutParamo_UsersListElement.AttrRegion.AttrName = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrDivisionFI
tmpoutParamo_UsersListElement.AttrRegion.AttrDivisionFI = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrCentroRTP
tmpoutParamo_UsersListElement.AttrRegion.AttrCentroRTP = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrCommissionRegion
tmpoutParamo_UsersListElement.AttrRegion.AttrCommissionRegion = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrIsActive
tmpoutParamo_UsersListElement.AttrRegion.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrCreatedOn
tmpoutParamo_UsersListElement.AttrRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrCreatedBy
tmpoutParamo_UsersListElement.AttrRegion.AttrCreatedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrUpdatedOn
tmpoutParamo_UsersListElement.AttrRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrUpdatedBy
tmpoutParamo_UsersListElement.AttrRegion.AttrUpdatedBy = "";
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrIsFsP
tmpoutParamo_UsersListElement.AttrRegion.AttrIsFsP = (bool?) false;
// Write optimized tmpoutParamo_UsersListElement.AttrRegion.AttrIsFcP
tmpoutParamo_UsersListElement.AttrRegion.AttrIsFcP = (bool?) false;
tmpoutParamo_UsersList1List.Add(tmpoutParamo_UsersListElement);
outParamo_UsersList.Advance();
}

} finally {
outParamo_UsersList.EndIteration();
}

result.outParamo_UsersList = new RestList<ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca>(tmpoutParamo_UsersList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca));
}

return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Model result = new ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Model();
result.outParamo_UsersList = variables == null ? new RL_4c313dd08c2e051e0c0310a6d05109b0() : RL_4c313dd08c2e051e0c0310a6d05109b0.FromRestList(variables.outParamo_UsersList, ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca.ToStructure);
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_ReassignFolioPopup_DataActionGetUsersList_Outputs();
result.outParamo_UsersList = screenModel.outParamo_UsersList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca>(ssConectaProveedores.RestRecords.RESTRC_a32d2d6effb998fa5a8e4b01f03a15ca.FromStructureDelegate(conf));
return result;
}

}
