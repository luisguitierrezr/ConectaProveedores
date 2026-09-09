using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SymbolImporteenMLSumRecord
public class RESTRC_46775da414dc909821822de65ba32d4b : AbstractRESTStructure<RC_46775da414dc909821822de65ba32d4b> {
[JsonProperty("Symbol")]
public string AttrSymbol;

[JsonProperty("ImporteenMLSum")]
public decimal? AttrImporteenMLSum;

public RESTRC_46775da414dc909821822de65ba32d4b() { }

public RESTRC_46775da414dc909821822de65ba32d4b (RC_46775da414dc909821822de65ba32d4b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSymbol = ConvertToRestWithoutDefaults(s.ssSymbol, "");
AttrImporteenMLSum = ConvertToRestWithoutDefaults(s.ssImporteenMLSum, 0.0M);
  } else {
AttrSymbol = s.ssSymbol;
AttrImporteenMLSum = (decimal?) s.ssImporteenMLSum;
  }
}

public static RC_46775da414dc909821822de65ba32d4b ToStructure(ssConectaProveedores.RestRecords.RESTRC_46775da414dc909821822de65ba32d4b obj) { 
  RC_46775da414dc909821822de65ba32d4b s = new RC_46775da414dc909821822de65ba32d4b();
  if(obj != null) {
  s.ssSymbol = obj.AttrSymbol == null ? "" : obj.AttrSymbol;
  s.ssImporteenMLSum = obj.AttrImporteenMLSum == null ? 0.0M : obj.AttrImporteenMLSum.Value;
  }
  return s;
}

public static Func<RC_46775da414dc909821822de65ba32d4b, ssConectaProveedores.RestRecords.RESTRC_46775da414dc909821822de65ba32d4b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_46775da414dc909821822de65ba32d4b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_46775da414dc909821822de65ba32d4b FromStructure(RC_46775da414dc909821822de65ba32d4b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_46775da414dc909821822de65ba32d4b(s, config);
}

}


