using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CurrencyTotalAmountRecord
public class RESTRC_4d06af040e4a89ed9c35b745b328b97d : AbstractRESTStructure<RC_4d06af040e4a89ed9c35b745b328b97d> {
[JsonProperty("Currency")]
public ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord AttrCurrency;

[JsonProperty("TotalAmount")]
public decimal? AttrTotalAmount;

public RESTRC_4d06af040e4a89ed9c35b745b328b97d() { }

public RESTRC_4d06af040e4a89ed9c35b745b328b97d (RC_4d06af040e4a89ed9c35b745b328b97d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCurrency = ConvertToRestWithoutDefaults(s.ssENCurrency, new EN_327b52812b8badb247bde4975c10d441EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure, config);
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, 0.0M);
  } else {
AttrCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.FromStructure(s.ssENCurrency, config);
AttrTotalAmount = (decimal?) s.ssTotalAmount;
  }
}

public static RC_4d06af040e4a89ed9c35b745b328b97d ToStructure(ssConectaProveedores.RestRecords.RESTRC_4d06af040e4a89ed9c35b745b328b97d obj) { 
  RC_4d06af040e4a89ed9c35b745b328b97d s = new RC_4d06af040e4a89ed9c35b745b328b97d();
  if(obj != null) {
  s.ssENCurrency = ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord.ToStructure(obj.AttrCurrency);
  s.ssTotalAmount = obj.AttrTotalAmount == null ? 0.0M : obj.AttrTotalAmount.Value;
  }
  return s;
}

public static Func<RC_4d06af040e4a89ed9c35b745b328b97d, ssConectaProveedores.RestRecords.RESTRC_4d06af040e4a89ed9c35b745b328b97d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4d06af040e4a89ed9c35b745b328b97d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4d06af040e4a89ed9c35b745b328b97d FromStructure(RC_4d06af040e4a89ed9c35b745b328b97d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4d06af040e4a89ed9c35b745b328b97d(s, config);
}

}


