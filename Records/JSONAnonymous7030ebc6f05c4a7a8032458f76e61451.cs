using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaymentTermsRecord
public class JSONRC_5526bab1a99740bd870dde6a69ba3d9a : AbstractRESTStructure<RC_5526bab1a99740bd870dde6a69ba3d9a> {
[JsonProperty("PaymentTerms")]
[JsonPropertyName("PaymentTerms")]
public ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

public JSONRC_5526bab1a99740bd870dde6a69ba3d9a() { }

public JSONRC_5526bab1a99740bd870dde6a69ba3d9a (RC_5526bab1a99740bd870dde6a69ba3d9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
  } else {
AttrPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_5526bab1a99740bd870dde6a69ba3d9a, RC_5526bab1a99740bd870dde6a69ba3d9a> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_5526bab1a99740bd870dde6a69ba3d9a s) => ToStructure(s, config);
}
public static RC_5526bab1a99740bd870dde6a69ba3d9a ToStructure(ssConectaProveedores.RestRecords.JSONRC_5526bab1a99740bd870dde6a69ba3d9a obj, IBehaviorsConfiguration config) { 
  RC_5526bab1a99740bd870dde6a69ba3d9a s = new RC_5526bab1a99740bd870dde6a69ba3d9a();
  if(obj != null) {
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.JSONEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms, config);
  }
  return s;
}

public static Func<RC_5526bab1a99740bd870dde6a69ba3d9a, ssConectaProveedores.RestRecords.JSONRC_5526bab1a99740bd870dde6a69ba3d9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5526bab1a99740bd870dde6a69ba3d9a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_5526bab1a99740bd870dde6a69ba3d9a FromStructure(RC_5526bab1a99740bd870dde6a69ba3d9a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_5526bab1a99740bd870dde6a69ba3d9a(s, config);
}

}


