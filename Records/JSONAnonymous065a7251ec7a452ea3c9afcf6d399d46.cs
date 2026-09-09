using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationOutputRecord
public class JSONRC_67d1fce35b851f9d35f4c07471a88bc9 : AbstractRESTStructure<RC_67d1fce35b851f9d35f4c07471a88bc9> {
[JsonProperty("DocumentExtrationOutput")]
[JsonPropertyName("DocumentExtrationOutput")]
public ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure AttrDocumentExtrationOutput;

public JSONRC_67d1fce35b851f9d35f4c07471a88bc9() { }

public JSONRC_67d1fce35b851f9d35f4c07471a88bc9 (RC_67d1fce35b851f9d35f4c07471a88bc9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationOutput = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationOutput, new ST_37a6487c1fae199ee92f583d495139beStructure(), ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure.FromStructure, config);
  } else {
AttrDocumentExtrationOutput = ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure.FromStructure(s.ssSTDocumentExtrationOutput, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_67d1fce35b851f9d35f4c07471a88bc9, RC_67d1fce35b851f9d35f4c07471a88bc9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_67d1fce35b851f9d35f4c07471a88bc9 s) => ToStructure(s, config);
}
public static RC_67d1fce35b851f9d35f4c07471a88bc9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_67d1fce35b851f9d35f4c07471a88bc9 obj, IBehaviorsConfiguration config) { 
  RC_67d1fce35b851f9d35f4c07471a88bc9 s = new RC_67d1fce35b851f9d35f4c07471a88bc9();
  if(obj != null) {
  s.ssSTDocumentExtrationOutput = ssConectaProveedores.RestRecords.JSONST_37a6487c1fae199ee92f583d495139beStructure.ToStructure(obj.AttrDocumentExtrationOutput, config);
  }
  return s;
}

public static Func<RC_67d1fce35b851f9d35f4c07471a88bc9, ssConectaProveedores.RestRecords.JSONRC_67d1fce35b851f9d35f4c07471a88bc9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_67d1fce35b851f9d35f4c07471a88bc9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_67d1fce35b851f9d35f4c07471a88bc9 FromStructure(RC_67d1fce35b851f9d35f4c07471a88bc9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_67d1fce35b851f9d35f4c07471a88bc9(s, config);
}

}


