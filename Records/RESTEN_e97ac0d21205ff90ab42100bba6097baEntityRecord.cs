using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ApprovalStatus
public class RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord : AbstractRESTStructure<EN_e97ac0d21205ff90ab42100bba6097baEntityRecord> {
[JsonProperty("Id")]
public int? AttrId;

[JsonProperty("Label")]
public string AttrLabel;

[JsonProperty("Class")]
public string AttrClass;

[JsonProperty("Order")]
public int? AttrOrder;

[JsonProperty("Is_Active")]
public bool? AttrIs_Active;

[JsonProperty("IsCyA")]
public bool? AttrIsCyA;

[JsonProperty("IsCyAApproval")]
public bool? AttrIsCyAApproval;

[JsonProperty("IsReq")]
public bool? AttrIsReq;

[JsonProperty("IsInv")]
public bool? AttrIsInv;

[JsonProperty("LabelES")]
public string AttrLabelES;

public RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord() { }

public RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = ConvertToRestWithoutDefaults(s.ssClass, "");
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrIsCyA = ConvertToRestWithoutDefaults(s.ssIsCyA, false);
AttrIsCyAApproval = ConvertToRestWithoutDefaults(s.ssIsCyAApproval, false);
AttrIsReq = ConvertToRestWithoutDefaults(s.ssIsReq, false);
AttrIsInv = ConvertToRestWithoutDefaults(s.ssIsInv, false);
AttrLabelES = ConvertToRestWithoutDefaults(s.ssLabelES, "");
  } else {
AttrId = (int?) s.ssId;
AttrLabel = s.ssLabel;
AttrClass = s.ssClass;
AttrOrder = (int?) s.ssOrder;
AttrIs_Active = (bool?) s.ssIs_Active;
AttrIsCyA = (bool?) s.ssIsCyA;
AttrIsCyAApproval = (bool?) s.ssIsCyAApproval;
AttrIsReq = (bool?) s.ssIsReq;
AttrIsInv = (bool?) s.ssIsInv;
AttrLabelES = s.ssLabelES;
  }
}

public static EN_e97ac0d21205ff90ab42100bba6097baEntityRecord ToStructure(ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord obj) { 
  EN_e97ac0d21205ff90ab42100bba6097baEntityRecord s = new EN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
  if(obj != null) {
  s.ssId = obj.AttrId == null ? 0 : obj.AttrId.Value;
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  s.ssClass = obj.AttrClass == null ? "" : obj.AttrClass;
  s.ssOrder = obj.AttrOrder == null ? 0 : obj.AttrOrder.Value;
  s.ssIs_Active = obj.AttrIs_Active == null ? false : obj.AttrIs_Active.Value;
  s.ssIsCyA = obj.AttrIsCyA == null ? false : obj.AttrIsCyA.Value;
  s.ssIsCyAApproval = obj.AttrIsCyAApproval == null ? false : obj.AttrIsCyAApproval.Value;
  s.ssIsReq = obj.AttrIsReq == null ? false : obj.AttrIsReq.Value;
  s.ssIsInv = obj.AttrIsInv == null ? false : obj.AttrIsInv.Value;
  s.ssLabelES = obj.AttrLabelES == null ? "" : obj.AttrLabelES;
  }
  return s;
}

public static Func<EN_e97ac0d21205ff90ab42100bba6097baEntityRecord, ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_e97ac0d21205ff90ab42100bba6097baEntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord FromStructure(EN_e97ac0d21205ff90ab42100bba6097baEntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord(s, config);
}

}


