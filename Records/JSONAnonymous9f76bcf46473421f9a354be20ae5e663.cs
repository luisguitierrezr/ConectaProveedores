using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionFileTypesStructRecord
public class JSONRC_fc2fa2d768001e70af464f961159f027 : AbstractRESTStructure<RC_fc2fa2d768001e70af464f961159f027> {
[JsonProperty("RequisitionFileTypesStruct")]
[JsonPropertyName("RequisitionFileTypesStruct")]
public ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure AttrRequisitionFileTypesStruct;

public JSONRC_fc2fa2d768001e70af464f961159f027() { }

public JSONRC_fc2fa2d768001e70af464f961159f027 (RC_fc2fa2d768001e70af464f961159f027 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionFileTypesStruct = ConvertToRestWithoutDefaults(s.ssSTRequisitionFileTypesStruct, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructure, config);
  } else {
AttrRequisitionFileTypesStruct = ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructure(s.ssSTRequisitionFileTypesStruct, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_fc2fa2d768001e70af464f961159f027, RC_fc2fa2d768001e70af464f961159f027> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_fc2fa2d768001e70af464f961159f027 s) => ToStructure(s, config);
}
public static RC_fc2fa2d768001e70af464f961159f027 ToStructure(ssConectaProveedores.RestRecords.JSONRC_fc2fa2d768001e70af464f961159f027 obj, IBehaviorsConfiguration config) { 
  RC_fc2fa2d768001e70af464f961159f027 s = new RC_fc2fa2d768001e70af464f961159f027();
  if(obj != null) {
  s.ssSTRequisitionFileTypesStruct = ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.ToStructure(obj.AttrRequisitionFileTypesStruct, config);
  }
  return s;
}

public static Func<RC_fc2fa2d768001e70af464f961159f027, ssConectaProveedores.RestRecords.JSONRC_fc2fa2d768001e70af464f961159f027> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fc2fa2d768001e70af464f961159f027 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_fc2fa2d768001e70af464f961159f027 FromStructure(RC_fc2fa2d768001e70af464f961159f027 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_fc2fa2d768001e70af464f961159f027(s, config);
}

}


