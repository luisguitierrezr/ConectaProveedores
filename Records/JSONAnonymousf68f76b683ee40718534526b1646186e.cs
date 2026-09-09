using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyOrderMainRecord
public class JSONRC_a074711a91fd2441798a860685e4898b : AbstractRESTStructure<RC_a074711a91fd2441798a860685e4898b> {
[JsonProperty("Currency")]
[JsonPropertyName("Currency")]
public ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("OrderMain")]
[JsonPropertyName("OrderMain")]
public ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public JSONRC_a074711a91fd2441798a860685e4898b() { }

public JSONRC_a074711a91fd2441798a860685e4898b (RC_a074711a91fd2441798a860685e4898b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a074711a91fd2441798a860685e4898b, RC_a074711a91fd2441798a860685e4898b> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a074711a91fd2441798a860685e4898b s) => ToStructure(s, config);
}
public static RC_a074711a91fd2441798a860685e4898b ToStructure(ssConectaProveedores.RestRecords.JSONRC_a074711a91fd2441798a860685e4898b obj, IBehaviorsConfiguration config) { 
  RC_a074711a91fd2441798a860685e4898b s = new RC_a074711a91fd2441798a860685e4898b();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.JSONEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency, config);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.JSONEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain, config);
  }
  return s;
}

public static Func<RC_a074711a91fd2441798a860685e4898b, ssConectaProveedores.RestRecords.JSONRC_a074711a91fd2441798a860685e4898b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a074711a91fd2441798a860685e4898b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a074711a91fd2441798a860685e4898b FromStructure(RC_a074711a91fd2441798a860685e4898b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a074711a91fd2441798a860685e4898b(s, config);
}

}


