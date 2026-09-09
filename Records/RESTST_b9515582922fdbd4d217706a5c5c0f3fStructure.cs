using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_0250_FI_CREATE_RELATReq
public class RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure : AbstractRESTStructure<ST_b9515582922fdbd4d217706a5c5c0f3fStructure> {
[JsonProperty("IT_ATTACHMENT")]
public RestList<ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure> AttrIT_ATTACHMENT;

[JsonProperty("IV_ID")]
public string AttrIV_ID;

[JsonProperty("IV_SAP_OBJECT")]
public string AttrIV_SAP_OBJECT;

[JsonProperty("IV_SAP_OBJECT_ID")]
public string AttrIV_SAP_OBJECT_ID;

public RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure() { }

public RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure (ST_b9515582922fdbd4d217706a5c5c0f3fStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrIT_ATTACHMENT = s.ssIT_ATTACHMENT.ToRestList<ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure>(ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure.FromStructureDelegate(config));
AttrIV_ID = s.ssIV_ID;
AttrIV_SAP_OBJECT = s.ssIV_SAP_OBJECT;
AttrIV_SAP_OBJECT_ID = s.ssIV_SAP_OBJECT_ID;
  } else {
AttrIT_ATTACHMENT = s.ssIT_ATTACHMENT.ToRestList<ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure>(ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure.FromStructureDelegate(config));
AttrIV_ID = s.ssIV_ID;
AttrIV_SAP_OBJECT = s.ssIV_SAP_OBJECT;
AttrIV_SAP_OBJECT_ID = s.ssIV_SAP_OBJECT_ID;
  }
}

public static ST_b9515582922fdbd4d217706a5c5c0f3fStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure obj) { 
  ST_b9515582922fdbd4d217706a5c5c0f3fStructure s = new ST_b9515582922fdbd4d217706a5c5c0f3fStructure();
  if(obj != null) {
  s.ssIT_ATTACHMENT = RL_cff0038616a202f621fb7082f988995f.FromRestList(obj.AttrIT_ATTACHMENT, ssConectaProveedores.RestRecords.RESTST_7816c3c943d129234de46d39c32a618eStructure.ToStructure);
  s.ssIV_ID = obj.AttrIV_ID == null ? "" : obj.AttrIV_ID;
  s.ssIV_SAP_OBJECT = obj.AttrIV_SAP_OBJECT == null ? "" : obj.AttrIV_SAP_OBJECT;
  s.ssIV_SAP_OBJECT_ID = obj.AttrIV_SAP_OBJECT_ID == null ? "" : obj.AttrIV_SAP_OBJECT_ID;
  }
  return s;
}

public static Func<ST_b9515582922fdbd4d217706a5c5c0f3fStructure, ssConectaProveedores.RestRecords.RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b9515582922fdbd4d217706a5c5c0f3fStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure FromStructure(ST_b9515582922fdbd4d217706a5c5c0f3fStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b9515582922fdbd4d217706a5c5c0f3fStructure(s, config);
}

}


