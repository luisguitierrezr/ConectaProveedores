using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UploadValidationDataRecord
public class JSONRC_09565d86b693a4a01e3f6ffec1bd5add : AbstractRESTStructure<RC_09565d86b693a4a01e3f6ffec1bd5add> {
[JsonProperty("UploadValidationData")]
[JsonPropertyName("UploadValidationData")]
public ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure AttrUploadValidationData;

public JSONRC_09565d86b693a4a01e3f6ffec1bd5add() { }

public JSONRC_09565d86b693a4a01e3f6ffec1bd5add (RC_09565d86b693a4a01e3f6ffec1bd5add s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUploadValidationData = ConvertToRestWithoutDefaults(s.ssSTUploadValidationData, new ST_452088c4ad7c6718df20290248661783Structure(), ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure.FromStructure, config);
  } else {
AttrUploadValidationData = ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure.FromStructure(s.ssSTUploadValidationData, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_09565d86b693a4a01e3f6ffec1bd5add, RC_09565d86b693a4a01e3f6ffec1bd5add> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_09565d86b693a4a01e3f6ffec1bd5add s) => ToStructure(s, config);
}
public static RC_09565d86b693a4a01e3f6ffec1bd5add ToStructure(ssConectaProveedores.RestRecords.JSONRC_09565d86b693a4a01e3f6ffec1bd5add obj, IBehaviorsConfiguration config) { 
  RC_09565d86b693a4a01e3f6ffec1bd5add s = new RC_09565d86b693a4a01e3f6ffec1bd5add();
  if(obj != null) {
  s.ssSTUploadValidationData = ssConectaProveedores.RestRecords.JSONST_452088c4ad7c6718df20290248661783Structure.ToStructure(obj.AttrUploadValidationData, config);
  }
  return s;
}

public static Func<RC_09565d86b693a4a01e3f6ffec1bd5add, ssConectaProveedores.RestRecords.JSONRC_09565d86b693a4a01e3f6ffec1bd5add> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_09565d86b693a4a01e3f6ffec1bd5add s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_09565d86b693a4a01e3f6ffec1bd5add FromStructure(RC_09565d86b693a4a01e3f6ffec1bd5add s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_09565d86b693a4a01e3f6ffec1bd5add(s, config);
}

}


