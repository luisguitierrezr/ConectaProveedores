using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Entra_Workflow_Userlist
public class RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure : AbstractRESTStructure<ST_34625f5643caa3d12448dcec7dd4c7d3Structure> {
[JsonProperty("Name")]
public string AttrName;

[JsonProperty("Role")]
public string AttrRole;

[JsonProperty("CancelMessage")]
public string AttrCancelMessage;

[JsonProperty("ApprovalStatusId")]
public int? AttrApprovalStatusId;

[JsonProperty("ApproveAsAreaUsuaria")]
public bool? AttrApproveAsAreaUsuaria;

[JsonProperty("ModifyMessage")]
public string AttrModifyMessage;

[JsonProperty("IsNotMapped")]
public bool? AttrIsNotMapped;

[JsonProperty("IsReassigned")]
public bool? AttrIsReassigned;

[JsonProperty("IsSubstitute")]
public bool? AttrIsSubstitute;

public RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure() { }

public RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure (ST_34625f5643caa3d12448dcec7dd4c7d3Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrName = ConvertToRestWithoutDefaults(s.ssName, "");
AttrRole = ConvertToRestWithoutDefaults(s.ssRole, "");
AttrCancelMessage = ConvertToRestWithoutDefaults(s.ssCancelMessage, "");
AttrApprovalStatusId = ConvertToRestWithoutDefaults(s.ssApprovalStatusId, 0);
AttrApproveAsAreaUsuaria = ConvertToRestWithoutDefaults(s.ssApproveAsAreaUsuaria, false);
AttrModifyMessage = ConvertToRestWithoutDefaults(s.ssModifyMessage, "");
AttrIsNotMapped = ConvertToRestWithoutDefaults(s.ssIsNotMapped, false);
AttrIsReassigned = ConvertToRestWithoutDefaults(s.ssIsReassigned, false);
AttrIsSubstitute = ConvertToRestWithoutDefaults(s.ssIsSubstitute, false);
  } else {
AttrName = s.ssName;
AttrRole = s.ssRole;
AttrCancelMessage = s.ssCancelMessage;
AttrApprovalStatusId = (int?) s.ssApprovalStatusId;
AttrApproveAsAreaUsuaria = (bool?) s.ssApproveAsAreaUsuaria;
AttrModifyMessage = s.ssModifyMessage;
AttrIsNotMapped = (bool?) s.ssIsNotMapped;
AttrIsReassigned = (bool?) s.ssIsReassigned;
AttrIsSubstitute = (bool?) s.ssIsSubstitute;
  }
}

public static ST_34625f5643caa3d12448dcec7dd4c7d3Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure obj) { 
  ST_34625f5643caa3d12448dcec7dd4c7d3Structure s = new ST_34625f5643caa3d12448dcec7dd4c7d3Structure();
  if(obj != null) {
  s.ssName = obj.AttrName == null ? "" : obj.AttrName;
  s.ssRole = obj.AttrRole == null ? "" : obj.AttrRole;
  s.ssCancelMessage = obj.AttrCancelMessage == null ? "" : obj.AttrCancelMessage;
  s.ssApprovalStatusId = obj.AttrApprovalStatusId == null ? 0 : obj.AttrApprovalStatusId.Value;
  s.ssApproveAsAreaUsuaria = obj.AttrApproveAsAreaUsuaria == null ? false : obj.AttrApproveAsAreaUsuaria.Value;
  s.ssModifyMessage = obj.AttrModifyMessage == null ? "" : obj.AttrModifyMessage;
  s.ssIsNotMapped = obj.AttrIsNotMapped == null ? false : obj.AttrIsNotMapped.Value;
  s.ssIsReassigned = obj.AttrIsReassigned == null ? false : obj.AttrIsReassigned.Value;
  s.ssIsSubstitute = obj.AttrIsSubstitute == null ? false : obj.AttrIsSubstitute.Value;
  }
  return s;
}

public static Func<ST_34625f5643caa3d12448dcec7dd4c7d3Structure, ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_34625f5643caa3d12448dcec7dd4c7d3Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure FromStructure(ST_34625f5643caa3d12448dcec7dd4c7d3Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure(s, config);
}

}


