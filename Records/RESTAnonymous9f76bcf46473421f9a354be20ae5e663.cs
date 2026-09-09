using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionFileTypesStructRecord
public class RESTRC_fc2fa2d768001e70af464f961159f027 : AbstractRESTStructure<RC_fc2fa2d768001e70af464f961159f027> {
[JsonProperty("RequisitionFileTypesStruct")]
public ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure AttrRequisitionFileTypesStruct;

public RESTRC_fc2fa2d768001e70af464f961159f027() { }

public RESTRC_fc2fa2d768001e70af464f961159f027 (RC_fc2fa2d768001e70af464f961159f027 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionFileTypesStruct = ConvertToRestWithoutDefaults(s.ssSTRequisitionFileTypesStruct, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructure, config);
  } else {
AttrRequisitionFileTypesStruct = ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructure(s.ssSTRequisitionFileTypesStruct, config);
  }
}

public static RC_fc2fa2d768001e70af464f961159f027 ToStructure(ssConectaProveedores.RestRecords.RESTRC_fc2fa2d768001e70af464f961159f027 obj) { 
  RC_fc2fa2d768001e70af464f961159f027 s = new RC_fc2fa2d768001e70af464f961159f027();
  if(obj != null) {
  s.ssSTRequisitionFileTypesStruct = ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure.ToStructure(obj.AttrRequisitionFileTypesStruct);
  }
  return s;
}

public static Func<RC_fc2fa2d768001e70af464f961159f027, ssConectaProveedores.RestRecords.RESTRC_fc2fa2d768001e70af464f961159f027> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fc2fa2d768001e70af464f961159f027 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fc2fa2d768001e70af464f961159f027 FromStructure(RC_fc2fa2d768001e70af464f961159f027 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fc2fa2d768001e70af464f961159f027(s, config);
}

}


