using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyRecord
public class RESTRC_0468f02f35e6ccd6a092f321c5d8a88e : AbstractRESTStructure<RC_0468f02f35e6ccd6a092f321c5d8a88e> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

public RESTRC_0468f02f35e6ccd6a092f321c5d8a88e() { }

public RESTRC_0468f02f35e6ccd6a092f321c5d8a88e (RC_0468f02f35e6ccd6a092f321c5d8a88e s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
  }
}

public static RC_0468f02f35e6ccd6a092f321c5d8a88e ToStructure(ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e obj) { 
  RC_0468f02f35e6ccd6a092f321c5d8a88e s = new RC_0468f02f35e6ccd6a092f321c5d8a88e();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  }
  return s;
}

public static Func<RC_0468f02f35e6ccd6a092f321c5d8a88e, ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0468f02f35e6ccd6a092f321c5d8a88e s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e FromStructure(RC_0468f02f35e6ccd6a092f321c5d8a88e s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e(s, config);
}

}


