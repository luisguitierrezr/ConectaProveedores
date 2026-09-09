using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaymentDateRecord
public class JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9 : AbstractRESTStructure<RC_6a021efe2f8dc2f10ec54998b1f4e9f9> {
[JsonProperty("PaymentDate")]
[JsonPropertyName("PaymentDate")]
public String AttrPaymentDate;

public JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9() { }

public JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9 (RC_6a021efe2f8dc2f10ec54998b1f4e9f9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaymentDate = ConvertDateToRestWithoutDefaults(s.ssPaymentDate, new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
  } else {
AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(s.ssPaymentDate);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9, RC_6a021efe2f8dc2f10ec54998b1f4e9f9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9 s) => ToStructure(s, config);
}
public static RC_6a021efe2f8dc2f10ec54998b1f4e9f9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9 obj, IBehaviorsConfiguration config) { 
  RC_6a021efe2f8dc2f10ec54998b1f4e9f9 s = new RC_6a021efe2f8dc2f10ec54998b1f4e9f9();
  if(obj != null) {
  s.ssPaymentDate = obj.AttrPaymentDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(obj.AttrPaymentDate);
  }
  return s;
}

public static Func<RC_6a021efe2f8dc2f10ec54998b1f4e9f9, ssConectaProveedores.RestRecords.JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6a021efe2f8dc2f10ec54998b1f4e9f9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9 FromStructure(RC_6a021efe2f8dc2f10ec54998b1f4e9f9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_6a021efe2f8dc2f10ec54998b1f4e9f9(s, config);
}

}


