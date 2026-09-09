using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyRecord
public class JSONRC_0468f02f35e6ccd6a092f321c5d8a88e : AbstractRESTStructure<RC_0468f02f35e6ccd6a092f321c5d8a88e> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

public JSONRC_0468f02f35e6ccd6a092f321c5d8a88e() { }

public JSONRC_0468f02f35e6ccd6a092f321c5d8a88e (RC_0468f02f35e6ccd6a092f321c5d8a88e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0468f02f35e6ccd6a092f321c5d8a88e, RC_0468f02f35e6ccd6a092f321c5d8a88e> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0468f02f35e6ccd6a092f321c5d8a88e s) => ToStructure(s, config);
}
public static RC_0468f02f35e6ccd6a092f321c5d8a88e ToStructure(ssConectaProveedores.RestRecords.JSONRC_0468f02f35e6ccd6a092f321c5d8a88e obj, IBehaviorsConfiguration config) { 
  RC_0468f02f35e6ccd6a092f321c5d8a88e s = new RC_0468f02f35e6ccd6a092f321c5d8a88e();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  }
  return s;
}

public static Func<RC_0468f02f35e6ccd6a092f321c5d8a88e, ssConectaProveedores.RestRecords.JSONRC_0468f02f35e6ccd6a092f321c5d8a88e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0468f02f35e6ccd6a092f321c5d8a88e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0468f02f35e6ccd6a092f321c5d8a88e FromStructure(RC_0468f02f35e6ccd6a092f321c5d8a88e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0468f02f35e6ccd6a092f321c5d8a88e(s, config);
}

}


