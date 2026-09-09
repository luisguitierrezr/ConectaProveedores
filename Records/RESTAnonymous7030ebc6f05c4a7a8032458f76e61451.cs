using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaymentTermsRecord
public class RESTRC_5526bab1a99740bd870dde6a69ba3d9a : AbstractRESTStructure<RC_5526bab1a99740bd870dde6a69ba3d9a> {
[JsonProperty("PaymentTerms")]
public ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord AttrPaymentTerms;

public RESTRC_5526bab1a99740bd870dde6a69ba3d9a() { }

public RESTRC_5526bab1a99740bd870dde6a69ba3d9a (RC_5526bab1a99740bd870dde6a69ba3d9a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaymentTerms = ConvertToRestWithoutDefaults(s.ssENPaymentTerms, new EN_17720044fda96c0c2d8d0760c429f48aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure, config);
  } else {
AttrPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.FromStructure(s.ssENPaymentTerms, config);
  }
}

public static RC_5526bab1a99740bd870dde6a69ba3d9a ToStructure(ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a obj) { 
  RC_5526bab1a99740bd870dde6a69ba3d9a s = new RC_5526bab1a99740bd870dde6a69ba3d9a();
  if(obj != null) {
  s.ssENPaymentTerms = ssConectaProveedores.RestRecords.RESTEN_17720044fda96c0c2d8d0760c429f48aEntityRecord.ToStructure(obj.AttrPaymentTerms);
  }
  return s;
}

public static Func<RC_5526bab1a99740bd870dde6a69ba3d9a, ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5526bab1a99740bd870dde6a69ba3d9a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a FromStructure(RC_5526bab1a99740bd870dde6a69ba3d9a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a(s, config);
}

}


