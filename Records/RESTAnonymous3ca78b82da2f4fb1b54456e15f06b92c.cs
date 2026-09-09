using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SustainabilityRecord
public class RESTRC_f677954b3254ea60260cb7baa72dce4f : AbstractRESTStructure<RC_f677954b3254ea60260cb7baa72dce4f> {
[JsonProperty("Sustainability")]
public ssConectaProveedores.RestRecords.RESTEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord AttrSustainability;

public RESTRC_f677954b3254ea60260cb7baa72dce4f() { }

public RESTRC_f677954b3254ea60260cb7baa72dce4f (RC_f677954b3254ea60260cb7baa72dce4f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSustainability = ConvertToRestWithoutDefaults(s.ssENSustainability, new EN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord.FromStructure, config);
  } else {
AttrSustainability = ssConectaProveedores.RestRecords.RESTEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord.FromStructure(s.ssENSustainability, config);
  }
}

public static RC_f677954b3254ea60260cb7baa72dce4f ToStructure(ssConectaProveedores.RestRecords.RESTRC_f677954b3254ea60260cb7baa72dce4f obj) { 
  RC_f677954b3254ea60260cb7baa72dce4f s = new RC_f677954b3254ea60260cb7baa72dce4f();
  if(obj != null) {
  s.ssENSustainability = ssConectaProveedores.RestRecords.RESTEN_9a75c3f9d1545f2094763e7c965e9d81EntityRecord.ToStructure(obj.AttrSustainability);
  }
  return s;
}

public static Func<RC_f677954b3254ea60260cb7baa72dce4f, ssConectaProveedores.RestRecords.RESTRC_f677954b3254ea60260cb7baa72dce4f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f677954b3254ea60260cb7baa72dce4f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f677954b3254ea60260cb7baa72dce4f FromStructure(RC_f677954b3254ea60260cb7baa72dce4f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f677954b3254ea60260cb7baa72dce4f(s, config);
}

}


