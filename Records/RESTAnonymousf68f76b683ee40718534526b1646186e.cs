using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyOrderMainRecord
public class RESTRC_a074711a91fd2441798a860685e4898b : AbstractRESTStructure<RC_a074711a91fd2441798a860685e4898b> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_a074711a91fd2441798a860685e4898b() { }

public RESTRC_a074711a91fd2441798a860685e4898b (RC_a074711a91fd2441798a860685e4898b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_a074711a91fd2441798a860685e4898b ToStructure(ssConectaProveedores.RestRecords.RESTRC_a074711a91fd2441798a860685e4898b obj) { 
  RC_a074711a91fd2441798a860685e4898b s = new RC_a074711a91fd2441798a860685e4898b();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_a074711a91fd2441798a860685e4898b, ssConectaProveedores.RestRecords.RESTRC_a074711a91fd2441798a860685e4898b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a074711a91fd2441798a860685e4898b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a074711a91fd2441798a860685e4898b FromStructure(RC_a074711a91fd2441798a860685e4898b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a074711a91fd2441798a860685e4898b(s, config);
}

}


