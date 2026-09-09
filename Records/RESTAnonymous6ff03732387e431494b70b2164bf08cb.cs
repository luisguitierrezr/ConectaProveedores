using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// UploadValidationDataRecord
public class RESTRC_09565d86b693a4a01e3f6ffec1bd5add : AbstractRESTStructure<RC_09565d86b693a4a01e3f6ffec1bd5add> {
[JsonProperty("UploadValidationData")]
public ssConectaProveedores.RestRecords.RESTST_452088c4ad7c6718df20290248661783Structure AttrUploadValidationData;

public RESTRC_09565d86b693a4a01e3f6ffec1bd5add() { }

public RESTRC_09565d86b693a4a01e3f6ffec1bd5add (RC_09565d86b693a4a01e3f6ffec1bd5add s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrUploadValidationData = ConvertToRestWithoutDefaults(s.ssSTUploadValidationData, new ST_452088c4ad7c6718df20290248661783Structure(), ssConectaProveedores.RestRecords.RESTST_452088c4ad7c6718df20290248661783Structure.FromStructure, config);
  } else {
AttrUploadValidationData = ssConectaProveedores.RestRecords.RESTST_452088c4ad7c6718df20290248661783Structure.FromStructure(s.ssSTUploadValidationData, config);
  }
}

public static RC_09565d86b693a4a01e3f6ffec1bd5add ToStructure(ssConectaProveedores.RestRecords.RESTRC_09565d86b693a4a01e3f6ffec1bd5add obj) { 
  RC_09565d86b693a4a01e3f6ffec1bd5add s = new RC_09565d86b693a4a01e3f6ffec1bd5add();
  if(obj != null) {
  s.ssSTUploadValidationData = ssConectaProveedores.RestRecords.RESTST_452088c4ad7c6718df20290248661783Structure.ToStructure(obj.AttrUploadValidationData);
  }
  return s;
}

public static Func<RC_09565d86b693a4a01e3f6ffec1bd5add, ssConectaProveedores.RestRecords.RESTRC_09565d86b693a4a01e3f6ffec1bd5add> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_09565d86b693a4a01e3f6ffec1bd5add s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_09565d86b693a4a01e3f6ffec1bd5add FromStructure(RC_09565d86b693a4a01e3f6ffec1bd5add s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_09565d86b693a4a01e3f6ffec1bd5add(s, config);
}

}


