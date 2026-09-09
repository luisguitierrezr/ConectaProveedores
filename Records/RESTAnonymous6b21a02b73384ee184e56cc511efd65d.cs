using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_CECO_COSMOZ_Response_StructRecord
public class RESTRC_6e09c12efbeb44db58e002e7a26051ab : AbstractRESTStructure<RC_6e09c12efbeb44db58e002e7a26051ab> {
[JsonProperty("EM_SM_CECO_COSMOZ_Response_Struct")]
public ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure AttrEM_SM_CECO_COSMOZ_Response_Struct;

public RESTRC_6e09c12efbeb44db58e002e7a26051ab() { }

public RESTRC_6e09c12efbeb44db58e002e7a26051ab (RC_6e09c12efbeb44db58e002e7a26051ab s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrEM_SM_CECO_COSMOZ_Response_Struct = ConvertToRestWithoutDefaults(s.ssSTEM_SM_CECO_COSMOZ_Response_Struct, new ST_b6cef14925f799164fc3167fe695008bStructure(), ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure.FromStructure, config);
  } else {
AttrEM_SM_CECO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure.FromStructure(s.ssSTEM_SM_CECO_COSMOZ_Response_Struct, config);
  }
}

public static RC_6e09c12efbeb44db58e002e7a26051ab ToStructure(ssConectaProveedores.RestRecords.RESTRC_6e09c12efbeb44db58e002e7a26051ab obj) { 
  RC_6e09c12efbeb44db58e002e7a26051ab s = new RC_6e09c12efbeb44db58e002e7a26051ab();
  if(obj != null) {
  s.ssSTEM_SM_CECO_COSMOZ_Response_Struct = ssConectaProveedores.RestRecords.RESTST_b6cef14925f799164fc3167fe695008bStructure.ToStructure(obj.AttrEM_SM_CECO_COSMOZ_Response_Struct);
  }
  return s;
}

public static Func<RC_6e09c12efbeb44db58e002e7a26051ab, ssConectaProveedores.RestRecords.RESTRC_6e09c12efbeb44db58e002e7a26051ab> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6e09c12efbeb44db58e002e7a26051ab s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6e09c12efbeb44db58e002e7a26051ab FromStructure(RC_6e09c12efbeb44db58e002e7a26051ab s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6e09c12efbeb44db58e002e7a26051ab(s, config);
}

}


