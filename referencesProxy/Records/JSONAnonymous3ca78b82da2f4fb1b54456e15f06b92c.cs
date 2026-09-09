using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// SustainabilityRecord
public class JSONRC_f677954b3254ea60260cb7baa72dce4f : AbstractRESTStructure<RC_f677954b3254ea60260cb7baa72dce4f> {
[JsonProperty("Sustainability")]
[JsonPropertyName("Sustainability")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord AttrSustainability;

public JSONRC_f677954b3254ea60260cb7baa72dce4f() { }

public JSONRC_f677954b3254ea60260cb7baa72dce4f (RC_f677954b3254ea60260cb7baa72dce4f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSustainability = ConvertToRestWithoutDefaults(s.ssENSustainability, new EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord.FromStructure, config);
  } else {
AttrSustainability = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord.FromStructure(s.ssENSustainability, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f677954b3254ea60260cb7baa72dce4f, RC_f677954b3254ea60260cb7baa72dce4f> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f677954b3254ea60260cb7baa72dce4f s) => ToStructure(s, config);
}
public static RC_f677954b3254ea60260cb7baa72dce4f ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f677954b3254ea60260cb7baa72dce4f obj, IBehaviorsConfiguration config) { 
  RC_f677954b3254ea60260cb7baa72dce4f s = new RC_f677954b3254ea60260cb7baa72dce4f();
  if(obj != null) {
  s.ssENSustainability = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord.ToStructure(obj.AttrSustainability, config);
  }
  return s;
}

public static Func<RC_f677954b3254ea60260cb7baa72dce4f, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f677954b3254ea60260cb7baa72dce4f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f677954b3254ea60260cb7baa72dce4f s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f677954b3254ea60260cb7baa72dce4f FromStructure(RC_f677954b3254ea60260cb7baa72dce4f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_f677954b3254ea60260cb7baa72dce4f(s, config);
}

}


