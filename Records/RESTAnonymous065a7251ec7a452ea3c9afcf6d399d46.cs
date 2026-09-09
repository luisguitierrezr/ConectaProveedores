using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationOutputRecord
public class RESTRC_67d1fce35b851f9d35f4c07471a88bc9 : AbstractRESTStructure<RC_67d1fce35b851f9d35f4c07471a88bc9> {
[JsonProperty("DocumentExtrationOutput")]
public ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure AttrDocumentExtrationOutput;

public RESTRC_67d1fce35b851f9d35f4c07471a88bc9() { }

public RESTRC_67d1fce35b851f9d35f4c07471a88bc9 (RC_67d1fce35b851f9d35f4c07471a88bc9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationOutput = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationOutput, new ST_37a6487c1fae199ee92f583d495139beStructure(), ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure.FromStructure, config);
  } else {
AttrDocumentExtrationOutput = ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure.FromStructure(s.ssSTDocumentExtrationOutput, config);
  }
}

public static RC_67d1fce35b851f9d35f4c07471a88bc9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_67d1fce35b851f9d35f4c07471a88bc9 obj) { 
  RC_67d1fce35b851f9d35f4c07471a88bc9 s = new RC_67d1fce35b851f9d35f4c07471a88bc9();
  if(obj != null) {
  s.ssSTDocumentExtrationOutput = ssConectaProveedores.RestRecords.RESTST_37a6487c1fae199ee92f583d495139beStructure.ToStructure(obj.AttrDocumentExtrationOutput);
  }
  return s;
}

public static Func<RC_67d1fce35b851f9d35f4c07471a88bc9, ssConectaProveedores.RestRecords.RESTRC_67d1fce35b851f9d35f4c07471a88bc9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_67d1fce35b851f9d35f4c07471a88bc9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_67d1fce35b851f9d35f4c07471a88bc9 FromStructure(RC_67d1fce35b851f9d35f4c07471a88bc9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_67d1fce35b851f9d35f4c07471a88bc9(s, config);
}

}


