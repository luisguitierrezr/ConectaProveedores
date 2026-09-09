using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// StartUpdateEmailFailureReasonRecord
public class RESTRC_cd804aaddb98d881ac0e154d00c7a1ec : AbstractRESTStructure<RC_cd804aaddb98d881ac0e154d00c7a1ec> {
[JsonProperty("StartUpdateEmailFailureReason")]
public ssConectaProveedores.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure AttrStartUpdateEmailFailureReason;

public RESTRC_cd804aaddb98d881ac0e154d00c7a1ec() { }

public RESTRC_cd804aaddb98d881ac0e154d00c7a1ec (RC_cd804aaddb98d881ac0e154d00c7a1ec s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrStartUpdateEmailFailureReason = ConvertToRestWithoutDefaults(s.ssSTStartUpdateEmailFailureReason, new ST_265373b7ea713cad761986e9aec6548dStructure(), ssConectaProveedores.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure.FromStructure, config);
  } else {
AttrStartUpdateEmailFailureReason = ssConectaProveedores.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure.FromStructure(s.ssSTStartUpdateEmailFailureReason, config);
  }
}

public static RC_cd804aaddb98d881ac0e154d00c7a1ec ToStructure(ssConectaProveedores.RestRecords.RESTRC_cd804aaddb98d881ac0e154d00c7a1ec obj) { 
  RC_cd804aaddb98d881ac0e154d00c7a1ec s = new RC_cd804aaddb98d881ac0e154d00c7a1ec();
  if(obj != null) {
  s.ssSTStartUpdateEmailFailureReason = ssConectaProveedores.RestRecords.RESTST_265373b7ea713cad761986e9aec6548dStructure.ToStructure(obj.AttrStartUpdateEmailFailureReason);
  }
  return s;
}

public static Func<RC_cd804aaddb98d881ac0e154d00c7a1ec, ssConectaProveedores.RestRecords.RESTRC_cd804aaddb98d881ac0e154d00c7a1ec> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cd804aaddb98d881ac0e154d00c7a1ec s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cd804aaddb98d881ac0e154d00c7a1ec FromStructure(RC_cd804aaddb98d881ac0e154d00c7a1ec s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cd804aaddb98d881ac0e154d00c7a1ec(s, config);
}

}


